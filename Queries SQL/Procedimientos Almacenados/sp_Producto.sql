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