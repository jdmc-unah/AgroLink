-- FUNCIONES PARA PANTALLA RECIBO Y RECIBO DETALLE

-- validar stock recibo

CREATE OR ALTER FUNCTION dbo.fValidaStockR (@detalle TipoReciboDetalle READONLY)
RETURNS VARCHAR(50)
AS
BEGIN	
	DECLARE @prod INT, @bodID INT, @cant FLOAT
	DECLARE @error VARCHAR(50) = '', @stockTot FLOAT

	DECLARE crsTablaDetalle CURSOR FOR
		SELECT d.ProductoID, d.BodegaID, d.Cantidad
		FROM @detalle d
			   	   
	OPEN crsTablaDetalle
	FETCH NEXT FROM crsTablaDetalle INTO @prod, @bodID, @cant

	WHILE @@FETCH_STATUS = 0
	BEGIN
		-- Solo valida el stock total disponible (sin considerar comprometido)
		SELECT @stockTot = ISNULL(TotalExistencias, 0)
		FROM Pruebas.BodegaDetalle
		WHERE ProductoID = @prod AND BodegaID = @bodID

		IF @stockTot < @cant OR @stockTot IS NULL
		BEGIN
			SET @error = 'El stock disponible es menor que la cantidad requerida'
			RETURN @error
		END
				
		FETCH NEXT FROM crsTablaDetalle INTO @prod, @bodID, @cant
	END
	
	DEALLOCATE crsTablaDetalle

	RETURN @error
END
GO

-- calcular subtotal y total de recibo

CREATE OR ALTER FUNCTION dbo.fCalcularTotalesRecibo (@tablaTotales TipoReciboDetalle READONLY)
RETURNS @resultado TABLE (Subtotal DECIMAL(10, 2), Total DECIMAL(10, 2))
AS
BEGIN
	INSERT INTO @resultado 
	SELECT SUM(TT.Subtotal), SUM(TT.Total)
	FROM @tablaTotales TT

	RETURN
END
GO
