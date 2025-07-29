use agrolinkdb

go

CREATE OR ALTER VIEW vTraeSalidaProducto
as 
	SELECT SP.SalidaID, SP.CodigoSalida,  SP.Fecha, S.Nombre as 'Socio', S.TipoSocio, V.CodigoVenta as 'Venta',
	SP.VentaID, SP.SocioID

	FROM PRUEBAS.SalidaProducto SP
	INNER JOIN PRUEBAS.Socio S ON SP.SocioID = S.SocioID
	INNER JOIN PRUEBAS.Venta  V ON SP.VentaID = V.VentaID
	
go


select * from vTraeSalidaProducto

select * from PRUEBAS.SalidaProducto
select * from PRUEBAS.SalidaProductodetalle


