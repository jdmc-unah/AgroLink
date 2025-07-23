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

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Venta Filtrada >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeVentaFiltrada @ventID int
as
	begin
		SELECT VentaID, CodigoVenta, Fecha, SocioID, ListaPreciosID, TipoPago, Estado
		FROM vTraeVentas WHERE VentaID = @ventID

	end


go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Venta >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spAddUpdateVenta 
@ventID int , @fecha date,  @socID int , @listPrecID int , @tipoPago varchar(50) , @estado varchar(50)
as 
	begin
		
		--IF @ventID = 0
		--	--aqui va lo del insert
		--	INSERT INTO Pruebas.Venta (Fecha, SocioID, ListaPreciosID, TipoPago, Estado) VALUES
		--	(@fecha ,  @socID  , @listPrecID  , @tipoPago  , @estado )

		--ELSE
			UPDATE Pruebas.Venta SET Fecha = @fecha , SocioID = @socID , ListaPreciosID = @listPrecID, 
			TipoPago = @tipoPago , Estado = @estado
			WHERE VentaID = @ventID
			
	
	end
go

select * from pruebas.Venta

--pruebas del sp
begin transaction

--exec spAddUpdateVenta 0, '20250723' , 1,2,'Credito', 'Abierto'
exec spAddUpdateVenta 
3,
'2025/07/09',
4,
1,
'Credito',
'Abierto'

select * from pruebas.Venta

rollback









-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Venta Detalle >>>>>>>>>>>>*************PENDIENTE*************>>>>>>>>>>>>>>>>

CREATE TYPE TipoVentaDetalle as TABLE(
	VentaID int not null,
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
		
		declare @ventDetID int, @prodNuevo int, @impID int,  @bodID int, @cant int, @prec float ,  @tot float , @prodViejo int

		select ISNULL(VentaID, 0) as 'VentaProdViejo', ISNULL(ProductoID, 0) as 'ProdViejo' into #tablaProd from Pruebas.VentaDetalle Where VentaID = @ventID

		declare crsVentaDet cursor for
		select d.VentaID,  d.ProductoID as 'ProdNuevo', ImpuestoID, BodegaID, Cantidad, Precio, Total, tp.ProdViejo
		from @detalle d inner join #tablaProd tp on d.VentaID = tp.VentaProdViejo
			   
		open crsVentaDet; fetch next from crsVentaDet into  @ventDetID, @prodNuevo , @impID, @bodID , @cant , @prec , @tot , @prodViejo

		WHILE @@FETCH_STATUS = 0
			begin
			--el id por defecto en c# es 0 asi que si es una nueva fila se va a insertar, de lo contrario se actualiza
				IF @ventDetID = 0 
					insert into Pruebas.VentaDetalle (VentaID, ProductoID,	ImpuestoID,	BodegaID,	Cantidad,	Precio,	Total)  VALUES
					(@ventID, @prodNuevo, @impID, @bodID , @cant , @prec , @tot ) ;	
				
				ELSE
					print(@prodViejo)

					update Pruebas.VentaDetalle set 
					ProductoID = @prodNuevo, ImpuestoID = @impID, BodegaID = @bodID, Cantidad = @cant, Precio = @prec , Total = @tot
					WHERE VentaID = @ventID  AND ProductoID = @prodViejo;  --queda adaptar esto bien
				
				fetch next from crsVentaDet into   @ventDetID, @prodNuevo , @impID, @bodID , @cant , @prec , @tot , @prodViejo
			end
		
		deallocate crsVentaDet

	end
go




go
--Para probar el sp anterior
begin transaction
-- Declarar la variable tipo tabla
DECLARE @DatosPrueba AS TipoVentaDetalle;

-- Insertar datos de prueba
INSERT INTO @DatosPrueba (VentaID,Codigo,  ProductoID, BodegaID, Cantidad,	Precio, SubTotal, ImpuestoID, Total)
VALUES
(1,'PRO11',11,1,1,25.00,25,1,28.75),
(1,'PRO14',14,1,1,850.00,850,1,977.5)
EXEC spAddUpdateVentaDet 1, @DatosPrueba;


update Pruebas.VentaDetalle set 
ProductoID = 14, ImpuestoID = 1, BodegaID = 1, Cantidad = 25, Precio = 25 , Total = 28.75
WHERE VentaID = 1  AND ProductoID = 11; 


select * from pruebas.VentaDetalle 



(3, 10, 2, 2, 15, 25, 431.25),	--tomate
(0, 9, 1, 1, 15, 25, 431.25)	--tomate


-- Ejecutar el procedimiento con la tabla como parámetro


--insert into Pruebas.VentaDetalle (VentaID, ProductoID,	ImpuestoID,	BodegaID,	Cantidad,	Precio,	Total) values
--(3, 11, 1, 1, 2, 850 , 1955)


select * from pruebas.Venta
select * from pruebas.produ

select * from pruebas.Bodega

rollback













select * from Pruebas.Venta
select * from Pruebas.Producto

	select * from Pruebas.VentaDetalle 

	SELECT *
	FROM Pruebas.Venta V
	INNER JOIN Pruebas.VentaDetalle VD ON V.VentaID = VD.VentaID


	SELECT * --V.VentaID, V.CodigoVenta, V.Fecha , S.Nombre as 'Socio' , LP.Nombre as 'ListaPrecio', V.TipoPago, V.Estado,  SUM( (VD.Cantidad * VD.Precio) * (1+I.Valor) ) as 'Total'
	FROM Pruebas.Venta V
	INNER JOIN Pruebas.VentaDetalle VD ON V.VentaID = VD.VentaID
	INNER JOIN Pruebas.Socio S ON V.SocioID = S.SocioID
	INNER JOIN Pruebas.ListaPrecios LP ON V.ListaPreciosID = LP.ListaPreciosID
	INNER JOIN Pruebas.Impuesto I ON VD.ImpuestoID = I.ImpuestoID
	GROUP BY  V.VentaID, V.CodigoVenta, V.Fecha , S.Nombre , LP.Nombre, V.TipoPago, V.Estado



rollback