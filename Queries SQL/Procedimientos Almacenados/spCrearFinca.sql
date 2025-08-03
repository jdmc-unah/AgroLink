
create or alter procedure spCrearFinca
@socioID int,@NombreFinca varchar(60),@MunicipioID int,@Colonia VARCHAR(100) = NULL,@Detalle VARCHAR(150) = NULL,@CapacidadAgua VARCHAR(50)
as
begin 
-- creamos la direccion (los vcampos no boligatorios pueden ir nulos )
insert into Pruebas.Direccion (Colonia, Detalle, MunicipioID)
    values (@Colonia, @Detalle, @MunicipioID)

-- obtenemos el valor generado por la nueva direccion(la direccion Id)
declare @DireccionID int =SCOPE_IDENTITY()

--inserccion de la finca
insert into pruebas.Finca(SocioID,Nombre,CapacidadAgua,DireccionID)
values(@socioID,@NombreFinca,@CapacidadAgua,@DireccionID)

--devolvemos el id de la finca insertada
select SCOPE_IDENTITY() as FincaID

end

go

select * from pruebas.Direccion

