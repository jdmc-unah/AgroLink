
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

select * from pruebas.NumFiscal

go

CREATE OR ALTER PROCEDURE spAddUpdateNumFiscal @tabla TipoTablaNumFiscal READONLY
as
	begin
		declare @numId int -- , @rIni date , @rFin date, @estado varchar(20), @fVen varchar(20)

		declare crsNumFiscal cursor for
		select NumFiscalID from @tabla

		open crsNumFiscal
		fetch next from crsNumFiscal into @numId  --, @rIni,@rFin, @estado, @fVen

		WHILE @@FETCH_STATUS = 0
			begin
				IF @numId = 0
					
					insert into Pruebas.NumFiscal (RangoInicio, RangoFin, Estado , FechaVencimiento, EmpresaID)
					SELECT RangoInicio, RangoFin, Estado, FechaVencimiento, 1  FROM @tabla WHERE NumFiscalID = @numId
					--VALUES (@rIni,@rFin, @estado, @fVen, 1)

				ELSE
					update Pruebas.NumFiscal set RangoInicio = T.RangoInicio, RangoFin = T.RangoFin, Estado = T.Estado, FechaVencimiento = T.FechaVencimiento 
					FROM Pruebas.NumFiscal NF
					INNER JOIN @tabla T ON NF.NumFiscalID = T.NumFiscalID WHERE T.NumFiscalID = @numId
			end

	end
























