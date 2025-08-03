use AgroLinkDB


create or alter view vMostrarAgricultores
as
select PS.CodigoSocio,ps.Nombre,ps.Identidad,ps.Correo,ps.Telefono,ps.saldo,pf.CodigoFinca as 'Codigo Finca',pf.Nombre as 'NombreFinca',pf.CapacidadAgua,pdi.Nombre as Departamento,pm.Nombre as Municipio,pd.Colonia,pd.Detalle as ' Detalle Ubicacion'
from Pruebas.Socio PS inner join pruebas.finca pf on ps.SocioID=pf.SocioID
inner join Pruebas.Direccion pd on pf.DireccionID=pd.DireccionID
inner join Pruebas.Municipio pm on pd.MunicipioID=pm.MunicipioID
inner join pruebas.Departamento pdi on pm.DepartamentoID=pdi.DepartamentoID
go

select * from pruebas.Municipio
