create or alter view vPantallaBodega as
select 
    b.BodegaID,
    b.CodigoBodega,
    b.Nombre,
    b.Capacidad,
    d.DireccionID,
    concat(d.MunicipioID, ' - ', d.Colonia, ' - ', d.Detalle) as Direccion
from Pruebas.Bodega b
left join Pruebas.Direccion d on b.DireccionID = d.DireccionID;
    go