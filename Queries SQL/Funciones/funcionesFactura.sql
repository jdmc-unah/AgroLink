use AgroLinkDB


go


CREATE OR ALTER FUNCTION dbo.fSecuenciaCAI (@numFiscalID int) returns varchar(50)
as
	begin
		
		declare @ultimoCAI varchar(50), @ultimoCAIRec varchar(50), @nuevoCAI varchar(50) = NULL, @nuevoCAINum varchar(50),
		@rangoFin varchar(50), @rangoFinNum int, @rangoFinRec varchar(50) ,
		@cont int = 1  
		
		SELECT TOP 1 @ultimoCAI = F.CAI  , @rangoFin = N.RangoFin
		FROM Pruebas.Factura F INNER JOIN Pruebas.NumFiscal N ON F.NumFiscalID = N.NumFiscalID
		WHERE F.NumFiscalID = @numFiscalID
		ORDER BY FacturaID DESC
		
		
		--Valida si es el primer numero fiscal que sera creado de ese rango
		IF @ultimoCAI IS NULL 
			SELECT @ultimoCAI = RangoInicio ,  @rangoFin = RangoFin  
			FROM Pruebas.NumFiscal WHERE NumFiscalID = @numFiscalID


		SET @ultimoCAIRec  =  RIGHT(@ultimoCAI, 6 ) 
		SET @rangoFinRec =  RIGHT(@rangoFin, 6 ) 

		--Convierte rango fin a numero
		WHILE @cont <= 6
			BEGIN
				IF SUBSTRING(@rangoFinRec , @cont , 1) <> 0 
				BEGIN
					SET @rangoFinNum = (SUBSTRING(@rangoFinRec, @cont , 6 - @cont + 1  )) 
					break;
				END
				set @cont = @cont + 1
			END

		--Resetea el contador
		set @cont = 1

		--Convierte nuevo cai a numero
		WHILE @cont <= 6
			BEGIN
				IF SUBSTRING(@ultimoCAIRec , @cont , 1) <> 0
					BEGIN
						SET @nuevoCAINum = (SUBSTRING(@ultimoCAIRec, @cont , 6 - @cont + 1  )) + 1

						IF LEN(@nuevoCAINum) <= 6 AND @nuevoCAINum <= @rangoFinNum
							SET @nuevoCai =  CONCAT( LEFT(@ultimoCAIRec, 6 - LEN(@nuevoCAINum) )  ,  @nuevoCAINum)
							
							SET @nuevoCAI = CONCAT( LEFT( @ultimoCAI, LEN(@ultimoCAI)- LEN(@nuevoCAI)) , @nuevoCAI )

						return @nuevoCai
					END
				set @cont = @cont + 1
			END

			return @nuevoCai  --nulo si es incorrecto
	end

go

/* queda validar que esta dentro del rango y que devuelva bien como vrchar con los guiones*/
SELECT TOP 1 F.CAI , N.RangoFin
FROM Pruebas.Factura F FULL OUTER JOIN Pruebas.NumFiscal N ON F.NumFiscalID = N.NumFiscalID
WHERE F.NumFiscalID = 2
ORDER BY FacturaID DESC

select * from pruebas.NumFiscal


begin transaction
update pruebas.Factura set CAI = '001-001-01-000900' , NumFiscalID = 2 
--update pruebas.Factura set CAI = '001-001-01-999999' 
select dbo.fSecuenciaCAI (2) 

rollback



go

	-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Validacion de Stock Factura>>>>>>>>>>>>>>>>>>>>>>>>>>>>
drop FUNCTION dbo.fValidaStockF
go
CREATE OR ALTER FUNCTION dbo.fValidaStockF( @detalle TipoFacturaDetalle READONLY   ) returns varchar(50)
as
	begin	
		
		declare @prod int,  @bodID int, @cant float 
		declare @error varchar(50) = '', @stockLibre float, @stockTot float

		declare crsTablaDetalle cursor for
		select d.ProductoID, BodegaID, Cantidad  
		from @detalle d
			   
		open crsTablaDetalle; fetch next from crsTablaDetalle into  @prod , @bodID , @cant  

		WHILE @@FETCH_STATUS = 0
			begin
				
				select @stockLibre = (ISNULL(TotalExistencias, 0) - ISNULL(Comprometido, 0) ) , @stockTot = ISNULL(TotalExistencias,0) 
				from pruebas.BodegaDetalle where ProductoID = @prod and BodegaID = @bodID
		
				IF @stockLibre < @cant OR  @stockLibre IS NULL
					begin
						SET @error = 'El stock disponible es menor que la cantidad requerida'
						return @error 
					end
				
				fetch next from crsTablaDetalle into  @prod , @bodID , @cant 
			end
		
		deallocate crsTablaDetalle

		return @error
	end

go




-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Calculo Subtotal y Total de Factura >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER FUNCTION dbo.fCalcularTotalesFact (@tablaTotales TipoFacturaDetalle READONLY  )  
returns @resultado table (Subtotal decimal(10, 2), Total decimal(10, 2))
as  
	begin
		
		INSERT INTO @resultado 
		SELECT SUM(TT.Subtotal), SUM(TT.Total) FROM @tablaTotales TT

		return
	end

GO 



go