use AgroLinkDB
create or alter procedure spBuscarAgricultor @cod varchar(100)
as
begin

select * from vTraerAgricultores a where a.CodigoSocio=@cod or a.Nombre  like '%' + @cod + '%'

end
go


