use agrolinkdb
go

create or alter procedure spBuscarProducto
    @cod nvarchar(100)
as
begin
    set nocount on;

    select 
        P.ProductoID,
        P.CodigoProducto,
        P.Nombre,
        TP.NombreTipo as TipoProducto,
        UM.Nombre as UnidadMedida,
        PD.Precio
    from Pruebas.Producto P
    inner join Pruebas.TipoProducto TP on P.TipoID = TP.TipoID
    inner join Pruebas.UnidadMedida UM on P.UnidadMedidaID = UM.UnidadMedidaID
    left join Pruebas.ProductoDetalle PD on P.ProductoID = PD.ProductoID
    where P.CodigoProducto like '%' + @cod + '%'
       or P.Nombre like '%' + @cod + '%'
end
go

create or alter procedure spEliminarProducto
    @ProductoID int
as
begin
    set nocount on;

    delete from Pruebas.ProductoDetalle where ProductoID = @ProductoID;
    delete from Pruebas.VentaDetalle where ProductoID = @ProductoID;
    delete from Pruebas.CompraDetalle where ProductoID = @ProductoID;
    delete from Pruebas.EntradaProductoDetalle where ProductoID = @ProductoID;
    delete from Pruebas.FacturaDetalle where ProductoID = @ProductoID;
    delete from Pruebas.ReciboDetalle where ProductoID = @ProductoID;
    delete from Pruebas.SalidaProductoDetalle where ProductoID = @ProductoID;
    delete from Pruebas.BodegaDetalle where ProductoID = @ProductoID;
    delete from Pruebas.Lote where ProductoID = @ProductoID;
    delete from Pruebas.EntregaDetalle where ProductoID = @ProductoID;

    delete from Pruebas.Producto
    where ProductoID = @ProductoID;
end
go
