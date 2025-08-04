use agrolinkdb


go

-->> Reportes Inventario

CREATE OR ALTER VIEW vProdRecibidaxProductor
as
	
	select S.CodigoSocio as 'Código Agricultor', S.Nombre as 'Agricultor', P.CodigoProducto as 'Código Producto', 
	P.Nombre as 'Producto', --, F.Nombre as 'Finca', L.CodigoLote as 'Lote',
	YEAR(C.Fecha) as 'Periodo', SUM(CD.Cantidad) as 'Cantidad Total'  
	from pruebas.Compra C
	inner join pruebas.CompraDetalle CD on C.CompraID = CD.CompraID
	inner join pruebas.Socio s on C.SocioID = s.SocioID
	inner join pruebas.Producto p on CD.ProductoID = p.ProductoID
	inner join pruebas.TipoProducto TP on p.TipoID = tp.TipoID
	--inner join pruebas.Lote l on l.LoteID = ep.LoteID
	--inner join pruebas.Finca f on f.FincaID = l.FincaID
	where TipoSocio = 'Agricultor'and TP.Categoria <> 'Insumo'
	group by   S.CodigoSocio,S.Nombre, P.CodigoProducto, P.Nombre ,C.Fecha  --,  F.Nombre, L.CodigoLote 
	
go

SELECT * FROM vProdRecibidaxProductor
SELECT * FROM pruebas.EntradaProducto
SELECT * FROM pruebas.Compra
SELECT * FROM pruebas.EntradaProductoDetalle
SELECT * FROM pruebas.Socio
SELECT * FROM pruebas.Lote
SELECT * FROM pruebas.Finca
SELECT * FROM pruebas.Producto
SELECT * FROM pruebas.TipoProducto

go



CREATE OR ALTER VIEW vInsumosEntrxProductor
as
	select S.CodigoSocio as 'Código Agricultor', S.Nombre as 'Agricultor', P.CodigoProducto as 'Código Producto', 
	P.Nombre as 'Producto', --, F.Nombre as 'Finca', L.CodigoLote as 'Lote',
	YEAR(E.Fecha) as 'Periodo', SUM(ED.Cantidad) as 'Cantidad Total'  
	
	from pruebas.Entrega E
	inner join pruebas.EntregaDetalle ED on E.EntregaID = ED.EntregaID
	inner join pruebas.Socio s on E.SocioID = s.SocioID
	inner join pruebas.Producto p on ED.ProductoID = p.ProductoID
	inner join pruebas.TipoProducto TP on p.TipoID = tp.TipoID
	
	--inner join pruebas.Lote l on l.LoteID = ep.LoteID
	--inner join pruebas.Finca f on f.FincaID = l.FincaID
	
	where TipoSocio = 'Agricultor'and TP.Categoria = 'Insumo'
	group by   S.CodigoSocio,S.Nombre, P.CodigoProducto, P.Nombre ,E.Fecha  --,  F.Nombre, L.CodigoLote 

go

select * from vInsumosEntrxProductor

select * from pruebas.Entrega	
SELECT * FROM pruebas.Socio
SELECT * FROM pruebas.BodegaDetalle
SELECT *  
from pruebas.Entrega E
inner join pruebas.EntregaDetalle ED on E.EntregaID = ED.EntregaID
inner join pruebas.Socio s on E.SocioID = s.SocioID
inner join pruebas.Producto p on ED.ProductoID = p.ProductoID


go


-->> Reportes Saldo