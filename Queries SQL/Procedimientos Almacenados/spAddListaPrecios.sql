-- Procedimiento almacenado para insertar una nueva lista de precios
create or alter procedure spAddListaPrecios 
    @nombre varchar(100),
    @activo bit
as
begin
    insert into Pruebas.ListaPrecios (Nombre, Activo)
    values (@nombre, @activo)
    
    select SCOPE_IDENTITY() as ListaPreciosID
end
go
