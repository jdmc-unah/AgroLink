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
		
		IF @ventID = 0
				--aqui va lo del insert
			INSERT INTO Pruebas.Venta (Fecha, SocioID, ListaPreciosID, TipoPago, Estado) VALUES
			(@fecha ,  @socID  , @listPrecID  , @tipoPago  , @estado )
		ELSE
			UPDATE Pruebas.Venta SET Fecha = @fecha , SocioID = @socID , ListaPreciosID = @listPrecID, 
			TipoPago = @tipoPago , Estado = @estado
			WHERE VentaID = @ventID
			
		
		select top 1 ventaid from pruebas.Venta order by ventaid desc

	end
go

select * from pruebas.Venta

--pruebas del sp
begin transaction

--exec spAddUpdateVenta 0, '20250723' , 1,2,'Credito', 'Abierto'
exec spAddUpdateVenta 
0,
'2025/07/09',
4,
1,
'Credito',
'Abierto'

select * from pruebas.Venta

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
		
		IF @ventID = 0
			insert into Pruebas.VentaDetalle
			SELECT @ventID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total FROM @detalle
		ELSE
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
INSERT INTO @DatosPrueba (VentaID,Codigo,  ProductoID, BodegaID, Cantidad,	Precio, SubTotal, ImpuestoID, Total)
VALUES
(1,'PRO11',11,1,1,25.00,25,1,28.75),
(1,'PRO14',14,1,1,850.00,850,1,977.5),
(0,'PRO14',6,1,1,850.00,850,1,977.5)

EXEC spAddUpdateVentaDet 1, @DatosPrueba;


select * from pruebas.VentaDetalle 

rollback




















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


