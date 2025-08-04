use AgroLinkDB

select * from Pruebas.Socio
go

create or alter procedure spAgrearSocio @Nombre varchar(150),@TipoSocio varchar(100),@identidad varchar(60),@RTN varchar(60),@correo varchar(100),@telefono varchar(20),
@MunicipioID int,@Colonia VARCHAR(100) = NULL,@Detalle VARCHAR(150) = NULL,@Notas varchar(150),@saldo decimal(10, 2)
as
begin

-- creamos la dirrecion deel socio
insert into Pruebas.Direccion (Colonia, Detalle, MunicipioID)
    values (@Colonia, @Detalle, @MunicipioID)

-- obtenemos el valor generado por la nueva direccion(la direccion Id)
declare @DireccionID int =SCOPE_IDENTITY()

--creamos nuevo socio
insert into Pruebas.Socio(Nombre,TipoSocio,Identidad,RTN,Correo,Telefono,DireccionID,Notas,Saldo)
values(@Nombre,@TipoSocio,@identidad,@RTN,@correo,@telefono,@DireccionID,@Notas,@saldo)

--devolvemos el id del socio que se acaba de crear
select SCOPE_IDENTITY() as SocioID


end
go

select * from Pruebas.Socio