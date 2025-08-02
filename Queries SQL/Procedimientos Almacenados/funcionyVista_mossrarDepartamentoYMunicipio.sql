create or alter view vTraerDepartamento
as
select DepartamentoID,Nombre as Departamento from pruebas.Departamento
go

--- ahora que muestre los municipios ;-;

create or alter procedure spObtenerMunicipios @cod int
as

select m.MunicipioID,m.Nombre as Municipios  from Pruebas.Municipio m where m.DepartamentoID=@cod 

go

exec spObtenerMunicipios 6




