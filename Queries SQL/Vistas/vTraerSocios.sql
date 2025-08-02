select * from Pruebas.Socio
go

create or alter view vTraerSocios
as
select ps.CodigoSocio as Codigo,ps.Nombre as Socios,ps.TipoSocio as 'Tipo Socio',ps.Identidad,ps.RTN,Correo,Telefono,ps.saldo from Pruebas.Socio ps
go



