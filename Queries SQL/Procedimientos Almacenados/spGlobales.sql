use agrolinkdb

go


CREATE OR ALTER PROCEDURE spBorrarRegistro @id int, @tabla varchar(25)
as
	begin
		IF @tabla = 'NumFiscal'
			DELETE FROM PRUEBAS.NumFiscal WHERE NumFiscalID = @id

		IF @tabla = 'Impuesto'
			DELETE FROM Pruebas.Impuesto WHERE ImpuestoID = @id


	end









