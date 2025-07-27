use AgroLinkDB

create or alter view vTraerTipoRiego
as
select TipoRiegoID,Nombre as TipoRiego from Pruebas.TipoRiego

