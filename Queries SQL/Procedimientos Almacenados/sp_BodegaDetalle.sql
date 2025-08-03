
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
        bd.Comprometido,
        bd.TotalExistencias,
        (bd.TotalExistencias - bd.Comprometido) as 'Disponible'
    from Pruebas.BodegaDetalle bd
    inner join Pruebas.Producto p on bd.ProductoID = p.ProductoID
    where bd.BodegaID = @bodegaID;
end
go
