
-- Procedimiento almacenado para insertar una nueva bodega
create or alter procedure spAddBodega 
    @nombre varchar(50),
    @capacidad decimal(6,2),
    @direccionID int
as
begin
    insert into Pruebas.Bodega (Nombre, Capacidad, DireccionID)
    values (@nombre, @capacidad, @direccionID)
    
    select SCOPE_IDENTITY() as BodegaID
end
go
