--procedimiento para mostrar un socio

create or alter procedure spBuscarSocio @cod varchar(60) 
as

select * from vTraerSocios s where s.Codigo=@cod or s.Socios  like '%' + @cod + '%'

go