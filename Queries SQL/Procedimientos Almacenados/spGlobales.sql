use agrolinkdb


go


-----------------------Borrar registros------------------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE spBorrarRegistro @id int, @tabla varchar(25)
as
	begin
		IF @tabla = 'NumFiscal'
			DELETE FROM PRUEBAS.NumFiscal WHERE NumFiscalID = @id

		IF @tabla = 'Impuesto'
			DELETE FROM Pruebas.Impuesto WHERE ImpuestoID = @id

				--aqui hay que ir agregando lo de las demas tablas y tal 
	end


go

-----------------------Traer Municipio por Departamento------------------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE spTraeDeptoMunicipio @depto int
as
	begin
		SELECT MunicipioID, Nombre FROM Pruebas.Municipio WHERE DepartamentoID =  @depto
	end

go
sELECT * FROM Pruebas.Municipio where DepartamentoID = 4









