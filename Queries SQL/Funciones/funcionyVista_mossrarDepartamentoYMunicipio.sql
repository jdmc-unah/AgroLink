create or alter view vTraerDepartamento
as
select DepartamentoID,Nombre as Departamento from pruebas.Departamento
go

--- ahora que muestre los municipios ;-;

create or alter procedure spObtenerMunicipios @DepartamentoID int
as

select m.MunicipioID,m.Nombre as Municipios  from Pruebas.Municipio m where m.DepartamentoID=@DepartamentoID 

go

exec spObtenerMunicipios 6



