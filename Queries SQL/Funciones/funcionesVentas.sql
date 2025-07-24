use agrolinkdb

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Calculo Subtotal y Total >>>>>>>>>>>>>>>>>>>>>>>>>>>>



CREATE OR ALTER FUNCTION dbo.fCalcularTotales (@cant int , @precio float , @impID int) returns @resultado table (Subtotal float, Total float)
as
	begin
		declare @subtotal float, @total float, @impVal float

		
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



	-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Validaciones >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER FUNCTION dbo.fValidaVenta( @detalle TipoVentaDetalle READONLY   ) returns varchar(50)
as
	begin	
		
		declare @ventDetID int, @prod int, @impID int,  @bodID int, @cant int, @prec float ,  @tot float 

		declare @error varchar(50) = '', @stockLibre float, @stockTot float

		declare crsVentaDet cursor for
		select d.VentaID,  d.ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total 
		from @detalle d
			   
		open crsVentaDet; fetch next from crsVentaDet into  @ventDetID, @prod , @impID, @bodID , @cant , @prec , @tot 

		WHILE @@FETCH_STATUS = 0
			begin
				
				select @stockLibre = (ISNULL(TotalExistencias, 0) - ISNULL(Comprometido, 0) ) , @stockTot = ISNULL(TotalExistencias,0) 
				from pruebas.BodegaDetalle where ProductoID = @prod and BodegaID = @bodID
		
				IF @stockLibre < @cant OR  @stockLibre IS NULL
					begin
						SET @error = 'El stock disponible es menor que la cantidad requerida'
						return @error 
					end
				
				fetch next from crsVentaDet into   @ventDetID, @prod , @impID, @bodID , @cant , @prec , @tot 
			end
		
		deallocate crsVentaDet


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
(1,'PRO11',2,2,1,25.00,25,1,28.75)


SELECT top 1 dbo.fValidaVenta(1, @DatosPrueba) FROM pruebas.VentaDetalle  

rollback



















