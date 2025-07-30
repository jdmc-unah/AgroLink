use AgroLinkDB


go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda por Codigo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarEntrega @cod varchar(10)
as
	BEGIN 
		SELECT * FROM vTraeEntrega WHERE CodigoEntrega LIKE '%' + @cod + '%' or Socio like '%' + @cod + '%'
	END

go

exec spBuscarEntrega 'col'
go





-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Entrega Filtrada >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spTraeEntregaFiltrada @entrID int, @ventID int
as
	begin
		IF @entrID = 0
			begin
				SELECT  '' [CodigoEntrega], GETDATE() [Fecha], SocioID, VentaID, 0 [DireccionID], 0 [Repartidor],
				0 [DepartamentoID], 0 [MunicipioID] , '' [Colonia], '' [Detalle]
				FROM Pruebas.Venta WHERE VentaID = @ventID
			end
		ELSE
			SELECT * FROM vTraeEntregaDir WHERE EntregaID = @entrID


	end
go

exec  spTraeEntregaFiltrada 1 , 1

select * from PRUEBAS.entrega
select * from PRUEBAS.EntregaDetalle


go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Entrega Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeEntregaDetalle @entrID int , @ventID int
as
	begin
		
		declare @ventaDetalle as table(VentaID int, CodigoProducto varchar(50), ProductoID int, BodegaID int, Cantidad int , 
		Precio decimal(10,2), ImpuestoID int, Subtotal decimal(10,2), Total decimal(10,2))

	-->Valida si es una nueva salida
		IF @entrID = 0
			BEGIN
				--Trae los datos de la venta en la cual esta basada la salida
				INSERT INTO @ventaDetalle
				exec spTraeVentaDetalle @ventID

				SELECT @entrID [EntregaID], CodigoProducto, ProductoID, Cantidad
				FROM @ventaDetalle
			END
		ELSE
			BEGIN
				SELECT ED.EntregaID, P.CodigoProducto, ED.ProductoID, ED.Cantidad
				FROM Pruebas.EntregaDetalle ED
				INNER JOIN Pruebas.Producto P ON ED.ProductoID = P.ProductoID
				WHERE ED.EntregaID = @entrID
			END
	end
go

exec  spTraeEntregaDetalle 2 , 1




