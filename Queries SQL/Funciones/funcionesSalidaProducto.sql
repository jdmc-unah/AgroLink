

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
							begin
								SET @error = 'Bodega origen debe ser distinta a Bodega destino' --validar porque cuando la bod dest es igual a la bod origen no tira el error 
								return @error 
							end

						IF (@stckTotal - @stckComprometido) - @cant < 0 OR ISNULL(@stckTotal,0) = 0
							begin
								SET @error = 'Cantidad a transferir sobrepasa el stock libre'
								return @error 
							end
					end
				ELSE
					begin
					--> validaciones para salidas basadas en ventas
						IF (@stckComprometido - @cant) < 0 
							begin
								SET @error = 'Insuficiencia de stock en bodega origen'
								return @error 
							end

					end
				fetch next from crsTablaDetalle into  @prod , @bodID , @cant 
			end
		
		deallocate crsTablaDetalle

		return @error
	end

go





--Para probar el sp con tabla
begin transaction
-- Declarar la variable tipo tabla
DECLARE @DatosPrueba AS TipoSalidaProducto;
	
-- Insertar datos de prueba
INSERT INTO @DatosPrueba (SalidaID , Codigo ,	ProductoID ,	Cantidad  ,	BodegaID )
VALUES
(48,'PRO2',	3	,5000,	3)


--insert into pruebas.Venta values (GETDATE(), 3,6,'Contado' , 'Abierto' )
select dbo.fValidaStockSalProd(48, 0 , @DatosPrueba, 3 )

select * from pruebas.SalidaProductoDetalle
select * from pruebas.SalidaProducto

rollback

SalidaID int ,	Codigo varchar(10),	ProductoID int not null,	Cantidad int ,	BodegaID i




select ISNULL(Comprometido, 0)  , ISNULL(TotalExistencias,0) 
from pruebas.BodegaDetalle where ProductoID = 3 and BodegaID = 3

