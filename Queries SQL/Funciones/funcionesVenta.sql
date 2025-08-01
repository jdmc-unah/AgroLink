
	-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Validacion de Stock Venta>>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER FUNCTION dbo.fValidaStock( @detalle TipoVentaDetalle READONLY   ) returns varchar(50)
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

	
go
--Para probar el sp anterior
begin transaction
-- Declarar la variable tipo tabla
DECLARE @DatosPrueba AS TipoVentaDetalle;

-- Insertar datos de prueba
INSERT INTO @DatosPrueba (VentaID,Codigo,  ProductoID, BodegaID, Cantidad,	Precio, SubTotal, ImpuestoID, Total)
VALUES
(1,'PRO11',1,2,1,25.00,25,1,28.75)

SELECT dbo.fValidaStock(@DatosPrueba) 

rollback

go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Calculo Subtotal y Total de Factura >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER FUNCTION dbo.fCalcularTotalesVenta (@tablaTotales TipoVentaDetalle READONLY  )  
returns @resultado table (Subtotal decimal(10, 2), Total decimal(10, 2))
as  
	begin
		
		INSERT INTO @resultado 
		SELECT SUM(TT.Subtotal), SUM(TT.Total) FROM @tablaTotales TT

		return
	end

GO 
