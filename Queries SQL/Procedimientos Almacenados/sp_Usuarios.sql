-- PROCEDIMIENTOS ALMACENADOS PARA PANTALLA USUARIOS


-- procedimiento para iniciar sesion/validar usuario
create procedure spValidarUsuario
    @usuario varchar(50),
    @clave varchar(50)
as
begin
    -- se devuelven datos del usuario si coinciden usuario y clave
    select Usuario, Nombre, TipoUsuario
    from Pruebas.Usuario
    where usuario = @usuario and clave = @clave
end
go

-- procedimiento para agregar nuevos usuarios
create procedure spAgregarUsuario
    @usuario varchar(50),
    @clave varchar(50),
    @nombre varchar(100),
    @tipousuario varchar(50)
as
begin

    begin try
        -- verificar si el usuario ya existe
        if exists (select 1 from Pruebas.Usuario where usuario = @usuario)
        begin
			select 'El usuario ya existe.' as mensaje, 0 as Exito
            return
        end

        -- se inserta un nuevo usuario
        insert into Pruebas.Usuario (Usuario, Clave, Nombre, TipoUsuario)
        values (@usuario, @clave, @nombre, @tipousuario)

		declare @nuevoid int = scope_identity()

		select 'Usuario agregado exitosamente.' as Mensaje, 1 as Exito, @nuevoid as UsuarioID
    end try
    begin catch
        -- en caso de un error
		select ERROR_MESSAGE() as Mensaje, 0 as Exito
    end catch
end
go

-- procedimiento para reestablecer contraseña
create procedure spResetearClave
    @usuario varchar(50),
    @nuevaclave varchar(50)
as
begin
begin try
        if exists (select 1 from Pruebas.Usuario where Usuario = @usuario)
        begin
            update Pruebas.Usuario
            set Clave = @nuevaclave
            where Usuario = @usuario
        end
	end try
    begin catch
	end catch
end
go
