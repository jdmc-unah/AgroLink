
---sp para datos en el primer panel de bodega detalle, se muestra los datos de la bodega

create procedure spObtenerBodegaPorID @bodegaID int
as
begin
    select 
        b.BodegaID,
        b.CodigoBodega,
        b.Nombre,
        b.Capacidad,
        concat(d.MunicipioID, ' - ', d.Colonia, ' - ', d.Detalle) as Direccion
    from Pruebas.Bodega b
    left join Pruebas.Direccion d on b.DireccionID = d.DireccionID
    where b.BodegaID = @bodegaID;
end
go

---sp para obtener el detalle de la bodega por ID, muestra los productos y sus cantidades

create procedure spObtenerDetalleBodegaPorID @bodegaID int
as
begin
    select 
        p.Nombre as 'Producto',
        s.Nombre as 'Proveedor',
        bd.Comprometido,
        bd.TotalExistencias,
        (bd.TotalExistencias - bd.Comprometido) as 'Disponible'
    from Pruebas.BodegaDetalle bd
    inner join Pruebas.Producto p on bd.ProductoID = p.ProductoID
    left join (
        -- Get the most recent purchase for each product in this warehouse
        select cd.ProductoID, c.SocioID, c.Fecha,
               ROW_NUMBER() OVER (PARTITION BY cd.ProductoID ORDER BY c.Fecha DESC) as rn
        from Pruebas.CompraDetalle cd
        inner join Pruebas.Compra c on cd.CompraID = c.CompraID
        where cd.BodegaID = @bodegaID
    ) latest_purchase on p.ProductoID = latest_purchase.ProductoID and latest_purchase.rn = 1
    left join Pruebas.Socio s on latest_purchase.SocioID = s.SocioID
    where bd.BodegaID = @bodegaID;
end
go
