
-- Vista para mostrar todas las direcciones disponibles
create or alter view vDirecciones
as
select 
    d.DireccionID,
    concat(d.MunicipioID, ' - ', d.Colonia, ' - ', d.Detalle) as DireccionCompleta
from Pruebas.Direccion d
go
