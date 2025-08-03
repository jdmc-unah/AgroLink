-- VISTAS PARA PANTALLA RECIBO Y RECIBO DETALLE

-- trae los recibos

create or alter view vTraeRecibos 
as
	select r.ReciboID, r.CodigoRecibo, r.Fecha, s.Nombre as 'Socio', s.TipoSocio, lp.Nombre as 'ListaPrecio', r.MetodoPago, r.Estado, e.Nombre as 'Empleado',
		   sum((rd.Cantidad * rd.Precio) * (1 + I.Valor)) as 'Total',

    -- campos adicionales para referencia interna
    r.SocioID, r.ListaPreciosID, r.CompraID, r.EmpleadoID

	from Pruebas.Recibo r
    inner join Pruebas.ReciboDetalle rd on r.ReciboID = rd.ReciboID
    inner join Pruebas.Socio s on r.SocioID = s.SocioID
    inner join Pruebas.ListaPrecios lp on r.ListaPreciosID = lp.ListaPreciosID
    inner join Pruebas.Impuesto i on RD.ImpuestoID = I.ImpuestoID
    inner join Pruebas.Empleado e on R.EmpleadoID = E.EmpleadoID
	group by
    r.ReciboID, r.CodigoRecibo, r.Fecha, s.SocioID, s.Nombre, s.TipoSocio, lp.ListaPreciosID, lp.Nombre, r.MetodoPago, r.Estado, 
	r.SocioID, r.ListaPreciosID, r.CompraID, r.EmpleadoID, e.Nombre
go

select * from vTraeRecibos