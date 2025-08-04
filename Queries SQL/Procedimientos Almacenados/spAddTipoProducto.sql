
create or alter procedure spAddTipoProducto 
    @nom varchar(100),
    @cat varchar(25)
as
begin
    insert into Pruebas.TipoProducto (NombreTipo, Categoria) 
    values (@nom, @cat)
end
go
