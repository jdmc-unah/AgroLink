use AgroLinkDB


go


CREATE OR ALTER FUNCTION dbo.fSecuenciaCAI () returns varchar(50)
as
	begin
		
		declare @ultimoCAI varchar(50), @rangoFin varchar(50)  , @cont int = 1 , @nuevoCAINum varchar(50), @nuevoCAI varchar(50)

		SELECT TOP 1 @ultimoCAI = RIGHT( F.CAI , 6 ) , @rangoFin = RIGHT(N.RangoFin, 6)
		FROM Pruebas.Factura F INNER JOIN Pruebas.NumFiscal N ON F.NumFiscalID = N.NumFiscalID
		ORDER BY FacturaID DESC
		
		WHILE @cont <= 6
			BEGIN

				 IF SUBSTRING(@ultimoCAI, @cont , 1) <> 0
					BEGIN
						SET @nuevoCAINum = (SUBSTRING(@ultimoCAI, @cont , 6 - @cont + 1  )) + 1
						
						SET @nuevoCai =  CONCAT( LEFT(@ultimoCAI, 6 - LEN(@nuevoCAINum) )  ,  @nuevoCAINum)

						return @nuevoCai

					END

				set @cont = @cont + 1
			END



			return @ultimoCAI
	end


go

/* queda validar que esta dentro del rango y que devuelva bien como vrchar con los guiones*/
SELECT TOP 1 F.CAI , N.RangoFin
FROM Pruebas.Factura F INNER JOIN Pruebas.NumFiscal N ON F.NumFiscalID = N.NumFiscalID
ORDER BY FacturaID DESC




begin transaction
update pruebas.Factura set CAI = '001-001-01-105231' 
select dbo.fSecuenciaCAI () 

rollback