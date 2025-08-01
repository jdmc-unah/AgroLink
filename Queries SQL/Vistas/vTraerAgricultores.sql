use AgroLinkDB

create or alter view vTraerAgricultores
as
select SocioID,Nombre as NombreAgricultor from pruebas.Socio where Pruebas.Socio.TipoSocio='Agricultor'
go