use agrolinkdb



go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae todas las ventas >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeVentas 
as

	SELECT V.VentaID, V.CodigoVenta, V.Fecha , S.SocioID,  S.Nombre as 'Socio' , S.TipoSocio , 
	LP.ListaPreciosID, LP.Nombre as 'ListaPrecio', V.TipoPago, V.Estado,  SUM( (VD.Cantidad * VD.Precio) * (1+I.Valor) ) as 'Total'	FROM Pruebas.Venta V
	INNER JOIN Pruebas.VentaDetalle VD ON V.VentaID = VD.VentaID
	INNER JOIN Pruebas.Socio S ON V.SocioID = S.SocioID
	INNER JOIN Pruebas.ListaPrecios LP ON V.ListaPreciosID = LP.ListaPreciosID
	INNER JOIN Pruebas.Impuesto I ON VD.ImpuestoID = I.ImpuestoID
	GROUP BY  V.VentaID, V.CodigoVenta, V.Fecha , S.SocioID,  S.Nombre  , S.TipoSocio , LP.ListaPreciosID, LP.Nombre,  V.TipoPago, V.Estado

go	


-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


select * from vtraeventas where VentaID =3


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










