
create or alter procedure spAddProducto 
    @nom varchar(50), @tipProdID int, @uniMedID int
as
begin
    -- Insertar el nuevo producto
    insert into Pruebas.Producto (TipoID, UnidadMedidaID, Nombre)
    values (@tipProdID, @uniMedID, @nom)

    -- Devolver el ID del producto insertado
    select SCOPE_IDENTITY() as ProductoID
end
go
