---vista bodega detalle

create view vPantallaBodegaDetalle as
select 
    bd.BodegaID,
    b.CodigoBodega,
    b.Nombre as 'Bodega',
    p.Nombre as 'Producto',
    bd.Comprometido,
    bd.TotalExistencias,
    (bd.TotalExistencias - bd.Comprometido) as 'Disponible'
from Pruebas.BodegaDetalle bd
inner join Pruebas.Bodega b on bd.BodegaID = b.BodegaID
inner join Pruebas.Producto p on bd.ProductoID = p.ProductoID;
go
