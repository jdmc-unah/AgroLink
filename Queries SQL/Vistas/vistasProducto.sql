create or alter view vPantallaProductos
as
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
go

