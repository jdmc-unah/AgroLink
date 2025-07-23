use AgroLinkDB
create or alter procedure spBuscarAgricultor @NomCodigo varchar(100)
as
begin

select * from vTraerAgricultores a where a.CodigoSocio=@NomCodigo or a.Nombre  like '%' + @NomCodigo + '%'

end
go


