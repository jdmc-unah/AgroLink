

use AgroLinkDB

go




go
	-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Validaciones salida producto >>>>>>>>>>>>>>>>>>>>>>>>>>>>
	

CREATE OR ALTER FUNCTION dbo.fValidaStockSalProd(@salID int, @ventID int, @detalle TipoSalidaProducto READONLY ,@bodDest int= null  ) returns varchar(50)
as
	begin	
		
		declare @prod int,  @bodID int, @cant float 
		declare @error varchar(50) = '', @stckTotal float , @stckComprometido float, @cantVent float, @cantSalPrev float = 0

		declare crsTablaDetalle cursor for
		select ProductoID, BodegaID, Cantidad  
		from @detalle d
		
	
		open crsTablaDetalle; fetch next from crsTablaDetalle into  @prod , @bodID , @cant  

		WHILE @@FETCH_STATUS = 0
			begin
				
				select @stckComprometido = ISNULL(Comprometido, 0)  , @stckTotal = ISNULL(TotalExistencias,0) 
				from pruebas.BodegaDetalle where ProductoID = @prod and BodegaID = @bodID


				IF @ventID = 0 or @ventID IS NULL
					begin
					--> validaciones para transferencias internas		
						IF  @bodDest = @bodID
							SET @error = 'La bodega origen debe ser distinta a la bodega destino'
							return @error 

						IF (@stckTotal - @stckComprometido) - @cant < 0
							SET @error = 'La cantidad a transferir sobrepasa el stock libre'
							return @error 
					end
				

				IF @salID = 0
					begin
					--> validaciones para salidas basadas en ventas
						IF (@stckComprometido - @cant) < 0 
							begin
								SET @error = 'El stock comprometido para vender es menor que la cantidad requerida'
								return @error 
							end

					end
				fetch next from crsTablaDetalle into  @prod , @bodID , @cant 
			end
		
		deallocate crsTablaDetalle

		return @error
	end

go











