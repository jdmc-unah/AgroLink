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


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Venta Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE TYPE TipoVentaDetalle as TABLE(
	VentaID int not null,
	ProductoID int not null,
	ImpuestoID int not null,
	BodegaID int not null,
	Cantidad int not null,
	Precio decimal(10,2) not null ,
	Total decimal(10,2) not null 
)

go

CREATE OR ALTER PROCEDURE spAddUpdateVentaDet @ventID int, @detalle TipoVentaDetalle READONLY
as
	begin
		
		declare @ventDetID int, @prodID int, @impID int,  @bodID int, @cant int, @prec float ,  @tot float

		declare crsVentaDet cursor for
		select VentaID,  ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total  from @detalle

		open crsVentaDet; fetch next from crsVentaDet into  @ventDetID, @prodID , @impID, @bodID , @cant , @prec , @tot 

		WHILE @@FETCH_STATUS = 0
			begin
			--el id por defecto en c# es 0 asi que si es una nueva fila se va a insertar, de lo contrario se actualiza
				IF @ventDetID = 0 
					insert into Pruebas.VentaDetalle (VentaID, ProductoID,	ImpuestoID,	BodegaID,	Cantidad,	Precio,	Total)  VALUES
					(@ventID, @prodID, @impID, @bodID , @cant , @prec , @tot ) ;	
				ELSE	
					update Pruebas.VentaDetalle set 
					ProductoID = @prodID, ImpuestoID = @impID, BodegaID = @bodID, Cantidad = @cant, Precio = @prec , Total = @tot
					WHERE VentaID = @ventID;
				


				fetch next from crsVentaDet into   @ventDetID, @prodID , @impID, @bodID , @cant , @prec , @tot 
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
INSERT INTO @DatosPrueba (VentaID, ProductoID,	ImpuestoID,	BodegaID,	Cantidad,	Precio,	Total)
VALUES (3, 11, 1, 1, 2, 850 , 1955),

(0, 10, 1, 1, 15, 25, 431.25),	--tomate
(0, 9, 1, 1, 15, 25, 431.25)	--tomate


-- Ejecutar el procedimiento con la tabla como parámetro
EXEC spAddUpdateVentaDet 3, @DatosPrueba;


--insert into Pruebas.VentaDetalle (VentaID, ProductoID,	ImpuestoID,	BodegaID,	Cantidad,	Precio,	Total) values
--(3, 11, 1, 1, 2, 850 , 1955)


select * from pruebas.VentaDetalle 

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