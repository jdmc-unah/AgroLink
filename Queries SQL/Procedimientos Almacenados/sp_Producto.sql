use agrolinkdb
go

create or alter procedure spBuscarProducto @cod varchar(100)
as
begin

select * from vPantallaProductos a where a.CodigoProducto=@cod or a.Nombre  like '%' + @cod + '%'

end
go



--> Producto Detalle
-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Producto Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
create or alter procedure spTraeProdDet @prodID int
as
	begin

		select LP.Nombre as Lista, PD.Precio, CASE lP.Activo WHEN 1 THEN 'Activo' ELSE 'Inactivo' END AS 'Estado'
		from pruebas.producto p
		INNER join pruebas.ProductoDetalle pd on p.ProductoID = pd.ProductoID
		INNER join pruebas.ListaPrecios lp on pd.ListaPreciosID = lp.ListaPreciosID
		where PD.ProductoID = @prodID

	end
go

exec spTraeProdDet 2

go

create or alter procedure spTraePrecioProd @prodID int, @listPrecID int
as
	begin
		select P.Precio, LP.Activo
		from pruebas.productodetalle p
		inner join pruebas.ListaPrecios lp on p.ListaPreciosID = lp.ListaPreciosID
		where productoid = @prodID and P.ListaPreciosID = @listPrecID
	end

go
exec spTraePrecioProd 2, 1


go

create or alter procedure spAddUpdtProdDet @prodID int, @listPrecID int, @precio float
as
	begin
		declare @existe bit

		IF EXISTS( select Precio from pruebas.ProductoDetalle where productoid = @prodID and ListaPreciosID = @listPrecID)
			begin
				update pruebas.ProductoDetalle set Precio = @precio
				where ProductoID = @prodID and ListaPreciosID = @listPrecID			
			end
		ELSE
			begin
				insert into pruebas.ProductoDetalle VALUES ( @prodID, @listPrecID , @precio )
			end
	end

go

exec spAddUpdtProdDet 3,2,800

select * from pruebas.ProductoDetalle
