
--Procedimientos Almacenados Modulo Empresa

use AgroLinkDB

go
------------------Notas---------------------
-->>
------------------------------------------------------


-->>>>>>>>>>>>>>>>>>> Actualizar Datos de Empresa >>>>>>>>>>>>>>>>>>>

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



-->>>>>>>>>>>>>>>>>>> Agregar o Actualizar Numero Fiscal >>>>>>>>>>>>>>>>>>>


--Se crea tipo para tabla numfiscal

CREATE TYPE TipoTablaNumFiscal as TABLE (
	NumFiscalID		int not null,
	RangoInicio		varchar(20) not null,
	RangoFin		varchar(20) not null,
	Estado			varchar(20) not null,
	FechaVencimiento	date not null
)

go


-- Se crea sp para ejecutar 
CREATE OR ALTER PROCEDURE spAddUpdateNumFiscal @tabla TipoTablaNumFiscal READONLY
as
	begin
		declare @numId int, @rIni varchar(20) , @rFin varchar(20), @estado varchar(20), @fVen date

		declare crsNumFiscal cursor for
		select NumFiscalID, RangoInicio , RangoFin, Estado, FechaVencimiento from @tabla

		open crsNumFiscal; fetch next from crsNumFiscal into @numId , @rIni,@rFin, @estado, @fVen

		WHILE @@FETCH_STATUS = 0
			begin
			--el id por defecto en c# es 0 asi que si es una nueva fila se va a insertar, de lo contrario se actualiza
				IF @numId = 0 
					insert into Pruebas.NumFiscal (RangoInicio, RangoFin, Estado , FechaVencimiento, EmpresaID) VALUES
					( @rIni,@rFin, @estado, @fVen, 1) 
					
				ELSE	
					update Pruebas.NumFiscal set RangoInicio = @rIni, RangoFin = @rFin, Estado = @estado, FechaVencimiento = @fVen 
					WHERE NumFiscalID = @numId
				
				fetch next from crsNumFiscal into @numId , @rIni,@rFin, @estado, @fVen
			end
		
		deallocate crsNumFiscal

		select NumFiscalID, RangoInicio ,RangoFin, Estado, FechaVencimiento from Pruebas.NumFiscal
	end


go

select * from Pruebas.NumFiscal

go
--Para probar el sp anterior
begin transaction
-- Declarar la variable tipo tabla
DECLARE @DatosPrueba AS TipoTablaNumFiscal;

-- Insertar datos de prueba
INSERT INTO @DatosPrueba (NumFiscalID, RangoInicio, RangoFin, Estado, FechaVencimiento)
VALUES 
(1, '1111111', '2222222222', 'Activo', '2025-12-31'),
(2, '3333333333', '444444444', 'Inactivo', '2024-06-30');

-- Ejecutar el procedimiento con la tabla como parámetro
EXEC spAddUpdateNumFiscal @DatosPrueba;

rollback




-->>>>>>>>>>>>>>>>>>> Agregar o Actualizar Impuesto >>>>>>>>>>>>>>>>>>>


go

CREATE TYPE TipoTablaImpuesto as TABLE (
	ImpuestoID	int not null,
	Nombre		varchar(50) not null,
	Valor		decimal(2,2) not null
)

go


CREATE OR ALTER PROCEDURE spAddUpdateImpuesto @tabla TipoTablaImpuesto READONLY
as
	begin
		declare @impId int, @nom varchar(50) , @val decimal(2,2)

		declare crsImpuesto cursor for
		select ImpuestoID, Nombre , Valor from @tabla

		open crsImpuesto; fetch next from crsImpuesto into @impId , @nom, @val

		WHILE @@FETCH_STATUS = 0
			begin
				IF @impId = 0 
					insert into Pruebas.Impuesto (Nombre, Valor) VALUES (@nom, @val) 
					
				ELSE	
					update Pruebas.Impuesto set Nombre = @nom, Valor = @val WHERE ImpuestoID = @impId
				
				fetch next from crsImpuesto into @impId , @nom, @val
			end
		
		deallocate crsImpuesto

		select Nombre, Valor from Pruebas.Impuesto
	end

go
	
	select * from pruebas.Impuesto
go
--Para probar el sp anterior
begin transaction
-- Declarar la variable tipo tabla
DECLARE @DatosPrueba AS TipoTablaImpuesto;

-- Insertar datos de prueba
INSERT INTO @DatosPrueba (ImpuestoID, Nombre, Valor) VALUES 
(0,'imp1', 0.12 ),
(1,'imp2', 0.30)

-- Ejecutar el procedimiento con la tabla como parámetro
EXEC spAddUpdateImpuesto @DatosPrueba;

rollback





