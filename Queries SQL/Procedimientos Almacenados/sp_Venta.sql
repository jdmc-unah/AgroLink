use agrolinkdb


begin transaction
go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda por Codigo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarVenta @cod varchar(10)
as
	BEGIN 
		SELECT * FROM vTraeVentas WHERE CodigoVenta LIKE '%' + @cod + '%' or Socio like '%' + @cod + '%'
	END

go




-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Venta Filtrada >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spTraeVentaFiltrada @ventID int
as
	begin
		SELECT VentaID, CodigoVenta, Fecha, SocioID, ListaPreciosID, TipoPago, Estado
		FROM vTraeVentas WHERE VentaID = @ventID

	end
go




-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Venta Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeVentaDetalle @ventID int
as
	begin
		SELECT VD.VentaID,  P.CodigoProducto , VD.ProductoID , VD.BodegaID,
		VD.Cantidad, VD.Precio,  VD.ImpuestoID, (VD.Cantidad * VD.Precio) as 'Subtotal' , VD.Total 

		FROM (SELECT * FROM Pruebas.VentaDetalle WHERE VentaID = @ventID) VD 
		INNER JOIN Pruebas.Producto P ON VD.ProductoID = P.ProductoID
		INNER JOIN Pruebas.Impuesto I ON VD.ImpuestoID = I.ImpuestoID
		INNER JOIN Pruebas.Bodega B ON VD.BodegaID = B.BodegaID

	end
go


exec spTraeVentaDetalle 1

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae ventas (solo id y codigo) filtrado >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spTraeVentasCode @filtro varchar = null
as
	IF @filtro = 'T' OR @filtro IS NULL  --todas
		SELECT VentaID, CodigoVenta FROM Pruebas.Venta

	IF @filtro = 'A' --solo abiertas
		SELECT VentaID, CodigoVenta FROM Pruebas.Venta WHERE Estado = 'Abierto'
	
	IF @filtro = 'X' --solo canceladas y cerradas
		SELECT VentaID, CodigoVenta FROM Pruebas.Venta WHERE Estado <> 'Abierto'

go	

exec spTraeVentasCode 'x'

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Venta >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spAddUpdateVenta 
@ventID int , @fecha date,  @socID int , @listPrecID int , @tipoPago varchar(50) , @estado varchar(50),
@detalle TipoVentaDetalle READONLY
as 
	begin
		
		begin transaction

			DECLARE @err varchar(50) = ''

	-->Valida Stock
			SELECT @err = dbo.fValidaStock(@detalle);
			IF ISNULL(@err, '') <> '' THROW 50001, @err, 1; --devuelve error personalizado
				
	-->Crea o Edita Ventas
			IF @ventID = 0
				--nueva venta
				INSERT INTO Pruebas.Venta (Fecha, SocioID, ListaPreciosID, TipoPago, Estado) VALUES
				(@fecha ,  @socID  , @listPrecID  , @tipoPago  , @estado )
				IF @@ERROR <> 0 AND @err = '' select @err = 'Error'

			ELSE
				--editar venta
				UPDATE Pruebas.Venta SET Fecha = @fecha , SocioID = @socID , ListaPreciosID = @listPrecID, 
				TipoPago = @tipoPago , Estado = @estado
				WHERE VentaID = @ventID
				IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
					

	-->Valida si hubieron errores en la venta
		IF @err = ''   
			begin
				
				IF @ventID = 0  --si es una nueva venta trae la nueva venta creada
					select top 1 @ventID = ventaid from pruebas.Venta order by ventaid desc;

		-->Ejecuta y valida si hubieron errores en la venta detalle
				exec spAddUpdateVentaDet @ventID,  @detalle 
				IF @@ERROR = 0   --valida error al ingresar la venta detalle
					begin
						commit;
						select @ventID  --devuelve la venta que se agrego o editó
					end
				ELSE
					rollback;
			end
		ELSE
			rollback;

	end
go




--pruebas del sp
begin transaction
--exec spAddUpdateVenta 0, '20250723' , 1,2,'Credito', 'Abierto'
exec spAddUpdateVenta 0,'2025/07/09',4,null , 'Credito','Abierto'

select * from pruebas.VentaDetalle
rollback



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Venta Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>
--drop PROCEDURE spAddUpdateVentaDet
--drop TYPE TipoVentaDetalle 

CREATE TYPE TipoVentaDetalle as TABLE(
	VentaID int ,
	Codigo varchar(15),
	ProductoID int not null,
	BodegaID int not null,
	Cantidad int not null,
	Precio decimal(10,2) not null ,
	SubTotal decimal(10,2),
	ImpuestoID int not null,
	Total decimal(10,2) not null 
)

go

CREATE OR ALTER PROCEDURE spAddUpdateVentaDet @ventID int,  @detalle TipoVentaDetalle READONLY
as
	begin
		declare  @tipoPago varchar(50), @socID int, @totalNuevo float, @totalAnterior float, @saldo float		

		select @tipoPago = TipoPago, @socID = SocioID from pruebas.Venta where VentaID = @ventID


		--Actualiza saldo de socio con ventas al credito
		IF @tipoPago = 'Credito'
			begin
				select @totalNuevo = ISNULL(SUM(Total), 0) from @detalle 
				select @totalAnterior = ISNULL(SUM(Total), 0) from pruebas.VentaDetalle where VentaID = @ventID 
			
				--valida que no quede negativo
				select @saldo = ( CASE  WHEN Saldo - @totalAnterior < 0 THEN 0 ELSE Saldo - @totalAnterior  END ) 
				from pruebas.Socio where SocioID = @socID 

				update pruebas.Socio set Saldo = @saldo + @totalNuevo
				where SocioID = @socID
			
			end

		
		--Actualiza Stock
	
		declare @prod int,  @bodID int, @cantNueva float , @cantAnterior float, @compromet float

		declare crsVentaDet cursor for
		select ProductoID, BodegaID, Cantidad from @detalle 
			   
		open crsVentaDet; fetch next from crsVentaDet into  @prod , @bodID , @cantNueva  

		WHILE @@FETCH_STATUS = 0
			begin
				select @cantAnterior = Cantidad from pruebas.VentaDetalle where VentaID = @ventID and ProductoID = @prod

				print( @cantAnterior)

				--valida que no quede negativo ni nulo
				select @compromet  = ( 
				CASE  
					WHEN Comprometido - isnull(@cantAnterior,0) < 0 THEN 0 
					ELSE Comprometido - isnull(@cantAnterior,0)
				END ) from pruebas.BodegaDetalle WHERE BodegaID = @bodID AND ProductoID = @prod

				print( @compromet)
				print( @cantNueva)

				UPDATE Pruebas.BodegaDetalle SET Comprometido = @compromet + @cantNueva
				WHERE BodegaID = @bodID AND ProductoID = @prod
				
				fetch next from crsVentaDet into  @prod , @bodID , @cantNueva 
			end
		
		deallocate crsVentaDet

		--hace la actualizacion 
		delete from pruebas.VentaDetalle where VentaID = @ventID
		insert into Pruebas.VentaDetalle
		SELECT @ventID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total FROM @detalle
		
	end
go


--select Cantidad from pruebas.VentaDetalle where VentaID = 46 and ProductoID = 3

				--select ( 	
				--CASE  
				--	--WHEN NULL IS NULL THEN Comprometido
				--	WHEN Comprometido - 0 < 0 THEN 0 
				--	ELSE Comprometido - 0
				--END ) from pruebas.BodegaDetalle WHERE BodegaID = 3 AND ProductoID = 3




go
--Para probar el sp anterior
begin transaction
-- Declarar la variable tipo tabla
DECLARE @DatosPrueba AS TipoVentaDetalle;
	
-- Insertar datos de prueba
INSERT INTO @DatosPrueba (VentaID,Codigo,  ProductoID, ImpuestoID, BodegaID, Cantidad,	Precio, SubTotal, Total)
VALUES
(54,'PRO2',	2	, 2,	2,	1,	4.00, 4.00,	5.00 ),
(54,'PRO3',	3	, 1,	3,	2,	2.00, 4.00,	4.60 ),
(54,'PRO4',	4	, 1,	4,	6,	2.00, 8.00,	9.20 )

--insert into pruebas.Venta values (GETDATE(), 3,6,'Contado' , 'Abierto' )

EXEC spAddUpdateVentaDet 54, @DatosPrueba;


rollback


select * from pruebas.Venta where ventaid = 54
select * from pruebas.VentaDetalle where ventaid = 54

select * from pruebas.BodegaDetalle


INSERT INTO  pruebas.Venta (fecha, SocioID, ListaPreciosID, TipoPago, Estado) 
values (GETDATE(), 2,1,'Credito','Cerrado' )

rollback


--update pruebas.BodegaDetalle set Comprometido = 5 where BodegaID = 2
--update pruebas.socio set saldo = 0 where SocioID = 2
select * from pruebas.Socio where socioid=1

select * from pruebas.ventaDetalle --where VentaID = 22
select * from pruebas.venta --where VentaID = 22

select * from pruebas.BodegaDetalle
select * from pruebas.Bodega

select * from pruebas.Producto

















rollback


--posoible codigo para agregar editar tabla venta detalle
		/*
		declare @ventDetID int, @prodNuevo int, @impID int,  @bodID int, @cant int, @prec float ,  @tot float 

		declare crsVentaDet cursor for
		select d.VentaID,  d.ProductoID as 'ProdNuevo', ImpuestoID, BodegaID, Cantidad, Precio, Total 
		from @detalle d
			   
		open crsVentaDet; fetch next from crsVentaDet into  @ventDetID, @prodNuevo , @impID, @bodID , @cant , @prec , @tot 

		WHILE @@FETCH_STATUS = 0
			begin
			--el id por defecto en c# es 0 asi que si es una nueva fila se va a insertar, de lo contrario se actualiza
				IF @ventDetID = 0 
					insert into Pruebas.VentaDetalle (VentaID, ProductoID,	ImpuestoID,	BodegaID,	Cantidad,	Precio,	Total)  VALUES
					(@ventID, @prodNuevo, @impID, @bodID , @cant , @prec , @tot ) ;	
				
				ELSE
					
					update Pruebas.VentaDetalle set 
					ProductoID = @prodNuevo, ImpuestoID = @impID, BodegaID = @bodID, Cantidad = @cant, Precio = @prec , Total = @tot
					WHERE VentaID = @ventID -- AND ProductoID = @prodViejo;  --queda adaptar esto bien
				
				fetch next from crsVentaDet into   @ventDetID, @prodNuevo , @impID, @bodID , @cant , @prec , @tot , @prodViejo
			end
		
		deallocate crsVentaDet
		*/


