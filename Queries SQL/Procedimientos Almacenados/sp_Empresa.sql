
--Procedimientos Almacenados Modulo Empresa

use AgroLinkDB

go
------------------Notas---------------------
-->>
------------------------------------------------------



CREATE OR ALTER PROCEDURE spUpdateEmpresa @nombre varchar(100), @rtn varchar(14), @correo varchar(100),
@tel varchar(20) , @det varchar(50), @col varchar(50), @muni varchar(50)
as
	begin
		
		UPDATE Pruebas.Direccion SET MunicipioID = @muni , Colonia = @col , Detalle = @det
		WHERE DireccionID = 1

		UPDATE Pruebas.Empresa SET RTN = @rtn , Correo = @correo , Telefono = @tel 
		WHERE EmpresaID = 1

	end

go


CREATE TYPE TipoTablaNumFiscal as TABLE (
	NumFiscalID		int primary key not null,
	RangoInicio		varchar(20) not null,
	RangoFin		varchar(20) not null,
	Estado			bit not null,
	FechaVencimiento	date not null
)

go



CREATE OR ALTER PROCEDURE spAddUpdateNumFiscal @tabla TipoTablaNumFiscal READONLY
as
	begin
		

	end
























