use agrolinkdb

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Calculo Subtotal y Total por linea >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER FUNCTION dbo.fCalcularTotales (@cant int , @precio float , @impID int) returns @resultado table (Subtotal decimal(10, 2), Total decimal(10, 2))
as
	begin
		declare @subtotal decimal(10, 2) , @total decimal(10, 2) , @impVal float

		IF @impID = 0
			SET @impVal = 0
		ELSE
			select @impVal = valor FROM pruebas.Impuesto where ImpuestoID = @impID

		SET @subtotal = ( @cant * @precio) 
		SET @total = (@subtotal * (1+ @impVal))

		INSERT INTO @resultado VALUES (@subtotal, @total )

		return
	end

GO

SELECT * FROM dbo.fCalcularTotales(1,1,0) 


go








GO











