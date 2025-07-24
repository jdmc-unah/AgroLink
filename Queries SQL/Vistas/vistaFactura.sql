
USE AgroLinkDB

go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae todas las facturas >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeFacturas
as

	SELECT F.FacturaID, F.CodigoFactura , F.Fecha , S.Nombre as 'Socio' , S.TipoSocio , 
	LP.Nombre as 'ListaPrecio', F.MetodoPago , F.Estado,  SUM( (FD.Cantidad * FD.Precio) * (1+I.Valor) ) as 'Total'	
	

	FROM Pruebas.Factura F
	INNER JOIN Pruebas.FacturaDetalle FD  ON F.FacturaID = FD.FacturaID
	INNER JOIN Pruebas.Socio S ON F.SocioID = S.SocioID
	INNER JOIN Pruebas.ListaPrecios LP ON F.ListaPreciosID = LP.ListaPreciosID
	INNER JOIN Pruebas.Impuesto I ON FD.ImpuestoID = I.ImpuestoID
	GROUP BY  F.FacturaID, F.CodigoFactura , F.Fecha , S.SocioID,  S.Nombre  , S.TipoSocio , LP.ListaPreciosID, LP.Nombre,  F.MetodoPago , F.Estado

go	


SELECT * FROM vTraeFacturas


SELECT * FROM PRUEBAS.Factura
SELECT * FROM PRUEBAS.FacturaDetalle

SELECT * FROM PRUEBAS.Socio




