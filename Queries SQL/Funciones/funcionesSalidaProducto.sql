

use AgroLinkDB

go




go
	-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Validacion de Stock Factura>>>>>>>>>>>>>>>>>>>>>>>>>>>>
	

CREATE OR ALTER FUNCTION dbo.fValidaStockSalProd( @detalle TipoSalidaProducto READONLY   ) returns varchar(50)
as
	begin	
		
		declare @prod int,  @bodID int, @cant float 
		declare @error varchar(50) = '', @stockLibre float, @stockTot float , @stockCompr float

		declare crsTablaDetalle cursor for
		select ProductoID, BodegaID, Cantidad  
		from @detalle d
			   
		open crsTablaDetalle; fetch next from crsTablaDetalle into  @prod , @bodID , @cant  

		WHILE @@FETCH_STATUS = 0
			begin
				
				select @stockCompr = ISNULL(Comprometido, 0)  , @stockTot = ISNULL(TotalExistencias,0) 
				from pruebas.BodegaDetalle where ProductoID = @prod and BodegaID = @bodID
		
				IF (@stockCompr - @cant) < 0 OR  (@stockTot - @cant) < 0 
					begin
						SET @error = 'El stock es menor que la cantidad requerida'
						return @error 
					end
				
				fetch next from crsTablaDetalle into  @prod , @bodID , @cant 
			end
		
		deallocate crsTablaDetalle

		return @error
	end

go
