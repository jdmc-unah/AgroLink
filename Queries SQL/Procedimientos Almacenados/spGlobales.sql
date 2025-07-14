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




-----------------------Traer Departamento y Municipio------------------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE spTraeDeptoMunicipio 
as
	begin



select * from Pruebas.Direccion

select * from Pruebas.Departamento
select * from Pruebas.Municipio

	end








