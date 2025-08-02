use AgroLinkDB


create or alter view vMostrarAgricultores
as
select PS.CodigoSocio,ps.Nombre,ps.Identidad,ps.Correo,ps.Telefono
from Pruebas.Socio PS inner join Pruebas.Finca PF  on PS.SocioID=PF.SocioID inner join Pruebas.Direccion PD on PD.DireccionID=PF.DireccionID
inner join Pruebas.Municipio PM on pm.MunicipioID=pd.MunicipioID
go


