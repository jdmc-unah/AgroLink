use AgroLinkDB


create or alter view vMostrarAgricultores
as
select PS.CodigoSocio,ps.Nombre,ps.Identidad,ps.Correo,ps.Telefono,ps.saldo
from Pruebas.Socio PS where ps.CodigoSocio like 'AGR%'
go


