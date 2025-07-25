


use agrolinkdb

go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda por Codigo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarFactura @cod varchar(10)
as
	BEGIN 
		SELECT * FROM vTraeFacturas WHERE CodigoFactura LIKE '%' + @cod + '%' or Socio like '%' + @cod + '%'
	END

go



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Factura Filtrada >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spTraeFacturaFiltrada @factID int
as
	begin
		SELECT FacturaID, CodigoFactura, Fecha, SocioID, ListaPreciosID, EmpleadoID, MetodoPago, CAI ,Estado
		FROM vTraeFacturas WHERE FacturaID = @factID

	end
go

--exec spTraeFacturaFiltrada 1



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Venta Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeFacturaDetalle @factID int
as
	begin
		SELECT FD.FacturaID,  P.CodigoProducto , FD.ProductoID , FD.BodegaID,
		FD.Cantidad, FD.Precio,  FD.ImpuestoID, (FD.Cantidad * FD.Precio) as 'Subtotal' , FD.Total 

		FROM (SELECT * FROM Pruebas.FacturaDetalle WHERE FacturaID = @factID) FD 
		INNER JOIN Pruebas.Producto P ON FD.ProductoID = P.ProductoID
		INNER JOIN Pruebas.Impuesto I ON FD.ImpuestoID = I.ImpuestoID
		INNER JOIN Pruebas.Bodega B ON FD.BodegaID = B.BodegaID

	end
go


exec spTraeFacturaDetalle 1

go



update pruebas.Factura set Estado = 'Abierto' where FacturaID = 3


-->>>>>>>>>>>>>>>>>>>>>>>>>>>>
SELECT * FROM PRUEBAS.Factura
SELECT * FROM PRUEBAS.FacturaDetalle

SELECT * FROM PRUEBAS.Socio











