
create or alter procedure spBuscarTipoProducto @cod varchar(100)
as
begin

select * from vPantallaTipoProducto a where a.TipoProducto like '%' + @cod + '%'

end
go

