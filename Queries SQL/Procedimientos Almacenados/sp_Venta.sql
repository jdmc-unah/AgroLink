use agrolinkdb



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
		SELECT VD.VentaID, P.ProductoID , P.CodigoProducto , P.Nombre as 'Producto', I.ImpuestoID, I.Nombre as 'NomImpuesto', I.Valor as 'Impuesto', B.BodegaID, 
		B.Nombre as 'Bodega', VD.Cantidad, VD.Precio, (VD.Cantidad * VD.Precio) as 'Subtotal' , VD.Total 

		FROM (SELECT * FROM Pruebas.VentaDetalle WHERE VentaID = @ventID) VD 
		INNER JOIN Pruebas.Producto P ON VD.ProductoID = P.ProductoID
		INNER JOIN Pruebas.Impuesto I ON VD.ImpuestoID = I.ImpuestoID
		INNER JOIN Pruebas.Bodega B ON VD.BodegaID = B.BodegaID

	end
go


exec spTraeVentaDetalle 1

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



