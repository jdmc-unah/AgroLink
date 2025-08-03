-- VISTAS PARA PANTALLA COMPRA Y COMPRA DETALLE

-- trae todas las compras

create or alter view pruebas.vTraeCompras
as
	select 
		c.compraid, 
		c.codigocompra, 
		c.fecha, 
		s.socioid,  
		s.nombre as 'Socio', 
		s.tiposocio, 
		lp.listapreciosid, 
		lp.nombre as 'ListaPrecio', 
		c.tipopago, 
		c.estado, 
		cast(sum((cd.cantidad * cd.precio) * (1 + i.valor)) as float) as 'Total'
	from 
		pruebas.compra c
		inner join pruebas.compradetalle cd on c.compraid = cd.compraid
		inner join pruebas.socio s on c.socioid = s.socioid
		inner join pruebas.listaprecios lp on c.listapreciosid = lp.listapreciosid
		inner join pruebas.impuesto i on cd.impuestoid = i.impuestoid
	group by
		c.compraid, 
		c.codigocompra, 
		c.fecha, 
		s.socioid,  
		s.nombre,  
		s.tiposocio, 
		lp.listapreciosid, 
		lp.nombre,  
		c.tipopago, 
		c.estado
go
