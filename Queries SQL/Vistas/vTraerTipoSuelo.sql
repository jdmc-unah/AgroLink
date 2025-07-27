create or alter view vTraerTipoSuelo
as
select TipoSueloID,NombreComun as TipoSuelo from Pruebas.TipoSuelo
go


select * from vTraerTipoSuelo
