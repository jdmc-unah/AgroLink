use agrolinkdb

go

CREATE OR ALTER VIEW vTraeSalidaProducto
as 
	SELECT SP.SalidaID, SP.CodigoSalida,  SP.Fecha, ISNULL(S.Nombre, 'Transferencia Interna' )as 'Socio', S.TipoSocio, V.CodigoVenta as 'Venta',
	ISNULL(SP.VentaID,0) AS 'VentaID' , ISNULL(SP.SocioID, 0) as 'SocioID' , ISNULL( SP.BodegaDestino, 0) as 'BodegaDestinoID', ISNULL(B.Nombre, 'No Aplica') as 'BodegaDestino' 

	FROM PRUEBAS.SalidaProducto SP
	LEFT JOIN PRUEBAS.Socio S ON SP.SocioID = S.SocioID
	LEFT JOIN PRUEBAS.Venta  V ON SP.VentaID = V.VentaID
	LEFT JOIN PRUEBAS.Bodega B ON SP.BodegaDestino = B.BodegaID
go


select * from vTraeSalidaProducto

select * from PRUEBAS.SalidaProducto
select * from PRUEBAS.SalidaProductodetalle

insert into PRUEBAS.SalidaProducto values (GETDATE(), null,null, 1 ) 




