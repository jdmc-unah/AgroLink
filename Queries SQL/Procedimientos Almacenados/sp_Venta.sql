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

CREATE OR ALTER PROCEDURE spTraeVentasCode  @ventID int = null
as
	declare @estadoVent varchar(20)

			
	select @estadoVent = Estado from  Pruebas.Venta where VentaID = @ventID
			
	IF @estadoVent = 'Abierto' or @ventID = 0
		SELECT VentaID, CodigoVenta FROM Pruebas.Venta WHERE Estado = 'Abierto'
	ELSE
		SELECT VentaID, CodigoVenta FROM Pruebas.Venta WHERE Estado <> 'Abierto'



go


exec spTraeVentasCode 0
select * from pruebas.Venta
go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae ventas (solo id y codigo) pendientes de sacar producto completo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spTraeVentasSalidaComp 
as
	
	declare @ventasConSalidaCompleta as table (SalidaID int, VentaID int)

	insert into @ventasConSalidaCompleta
	select DISTINCT SPD.SalidaID, VD.VentaID
	from pruebas.SalidaProducto SP
	inner join pruebas.SalidaProductoDetalle SPD on sp.SalidaID = spd.SalidaID
	inner join pruebas.Venta v on sp.VentaID= v.VentaID
	inner join pruebas.VentaDetalle vd on vd.VentaID = v.VentaID
	where vd.Cantidad = spd.Cantidad and vd.ProductoID = spd.ProductoID 
	

	SELECT VentaID, CodigoVenta FROM Pruebas.Venta 
	WHERE VentaID NOT IN (SELECT VentaID FROM @ventasConSalidaCompleta)
	and Estado <> 'Cancelado'

go

exec spTraeVentasSalidaComp

select * from pruebas.Venta


go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Cancelar Venta >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spCancelarVenta @ventID int, @socID int, @error varchar(50) OUTPUT
as
	begin
		declare  @totalAnterior float, @saldo float, @tipoPago varchar(50)
		
		SET @error = ''

		IF @ventID <> 0
			begin
			-->Reduce el saldo pendiente por pagar del cliente creado por la venta
				
				select @tipoPago = TipoPago from pruebas.Venta where VentaID = @ventID

				IF @tipoPago = 'Credito'
					begin
						select @totalAnterior = ISNULL(SUM(Total), 0) from pruebas.VentaDetalle where VentaID = @ventID 
			
						--valida que no quede negativo
						select @saldo = ( CASE  WHEN Saldo - @totalAnterior < 0 THEN 0 ELSE Saldo - @totalAnterior  END ) 
						from pruebas.Socio where SocioID = @socID 

						update pruebas.Socio set Saldo = @saldo 
						where SocioID = @socID
						IF @@ERROR <> 0 SET @error = 'Ocurrio un error al actualizar el saldo del cliente';
					end

			-->Reduce el comprometido que habia apartado la creacion de la venta
				UPDATE Pruebas.BodegaDetalle SET Comprometido = Comprometido - vd.Cantidad
				FROM Pruebas.BodegaDetalle bd
				inner join Pruebas.VentaDetalle vd on bd.BodegaID = vd.BodegaID and bd.ProductoID = vd.ProductoID
				where vd.VentaID =  @ventID
				IF @@ERROR <> 0 SET @error = 'Ocurrio un error al actualizar el stock comprometido';


			--> Actualiza el estado a cancelado
				UPDATE Pruebas.Venta SET Estado = 'Cancelado' WHERE VentaID = @ventID

			end
		ELSE
			SET @error = 'No puede usar estado Cancelado en nueva venta'

		return
	
	end
	

GO



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Venta >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spAddUpdateVenta 
@ventID int , @fecha date,  @socID int , @listPrecID int , @tipoPago varchar(50) , @estado varchar(50),
@detalle TipoVentaDetalle READONLY
as 
	begin
		
		begin transaction

			DECLARE @err varchar(50) = '', @resCancelacion varchar(50)

	--> Valida si la venta lleva estado Cancelado
			IF @estado = 'Cancelado'
				begin
					exec spCancelarVenta @ventID, @socID, @error = @resCancelacion OUTPUT
					IF ISNULL(@resCancelacion, '') <> '' THROW 50001, @resCancelacion, 1; --devuelve error personalizado
					
					commit;
					select @ventID ;
					return;
				end

	-->Valida Stock
			SELECT @err = dbo.fValidaStock(@detalle);
			IF ISNULL(@err, '') <> '' THROW 50002, @err, 1; --devuelve error personalizado
				
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

CREATE TYPE TipoVentaDetalle as TABLE(
	VentaID int ,
	Codigo varchar(15),
	ProductoID int ,
	BodegaID int ,
	Cantidad int ,
	Precio decimal(10,2) ,
	SubTotal decimal(10,2),
	ImpuestoID int ,
	Total decimal(10,2) 
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

		
		--Actualiza Stock  --
	
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

				UPDATE Pruebas.BodegaDetalle SET Comprometido = ISNULL(@compromet,0) + @cantNueva
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


select * from pruebas.Venta where ventaid = 55
select * from pruebas.VentaDetalle where ventaid = 55

select * from pruebas.BodegaDetalle
select * from pruebas.Socio where socioid=8

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


