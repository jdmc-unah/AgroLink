use agrolinkdb

go

CREATE OR ALTER VIEW vTraeSalidaProducto
as 
	SELECT SalidaID, SP.Fecha, S.Nombre as 'Socio', V.CodigoVenta as 'Venta'
	FROM PRUEBAS.SalidaProducto SP
	INNER JOIN PRUEBAS.Socio S ON SP.SocioID = S.SocioID
	INNER JOIN PRUEBAS.Venta  V ON SP.VentaID = V.VentaID
	
go




