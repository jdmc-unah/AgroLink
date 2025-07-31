create or alter view vPantallaTipoProducto as
selct
    tp.TipoID,
    tp.NombreTipoProducto as TipoProducto,
    tp.Categoria
from Pruebas.TipoProducto tp;
go
