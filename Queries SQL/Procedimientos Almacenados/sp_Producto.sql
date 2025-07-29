use agrolinkdb
go

create or alter procedure spBuscarProducto @cod varchar(100)
as
begin

select * from vPantallaProductos a where a.CodigoProducto=@cod or a.Nombre  like '%' + @cod + '%'

end
go

