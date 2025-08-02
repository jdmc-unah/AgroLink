create or alter view vPantallaTipoProducto as
select
    tp.TipoID,
    tp.NombreTipo as TipoProducto,
    tp.Categoria
from Pruebas.TipoProducto tp;
go

create or alter view vTraeTipoProducto
as
	select TipoID, NombreTipo as 'Tipo producto' from pruebas.TipoProducto 
go