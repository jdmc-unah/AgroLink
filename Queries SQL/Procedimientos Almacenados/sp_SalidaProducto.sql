
USE AgroLinkDB
go



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda por Codigo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarSalidaProd @cod varchar(10)
as
	BEGIN 
		SELECT * FROM vTraeSalidaProducto WHERE CodigoSalida LIKE '%' + @cod + '%' or Socio like '%' + @cod + '%'
	END

go

exec spBuscarSalidaProd 'col'
go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Salida Filtrada >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spTraeSalidaFiltrada @salID int, @ventID int
as
	begin
		IF @salID = 0
			begin
				SELECT  '' [CodigoSalida], GETDATE() [Fecha], SocioID, VentaID, 0 [BodegaDestinoID]
				FROM Pruebas.Venta WHERE VentaID = @ventID
			end
		ELSE
			SELECT SalidaID, CodigoSalida, Fecha, SocioID, VentaID, BodegaDestinoID
			FROM vTraeSalidaProducto WHERE SalidaID = @salID


	end
go


exec spTraeSalidaFiltrada 1, 0
select * from pruebas.Venta

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Salida Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeSalidaDetalle @salID int , @ventID int
as
	begin
		
		declare @ventaDetalle as table(VentaID int, CodigoProducto varchar(50), ProductoID int, BodegaID int, Cantidad int , 
		Precio decimal(10,2), ImpuestoID int, Subtotal decimal(10,2), Total decimal(10,2))

	-->Valida si es una nueva salida
		IF @salID = 0
			BEGIN
				--Trae los datos de la venta en la cual esta basada la salida
				INSERT INTO @ventaDetalle
				exec spTraeVentaDetalle @ventID

				SELECT @salID [SalidaID], CodigoProducto, ProductoID, BodegaID, Cantidad
				FROM @ventaDetalle
			END
		ELSE
			BEGIN
				SELECT SalidaID, P.CodigoProducto, SPD.ProductoID, Cantidad, BodegaID --bodega de origen
				FROM Pruebas.SalidaProductoDetalle SPD
				INNER JOIN Pruebas.Producto P ON SPD.ProductoID = P.ProductoID
				WHERE SPD.SalidaID = @salID
			END
	end
go


exec spTraeSalidaDetalle 1, 1



go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae salidas (solo id y codigo) >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeSalidasCode @filtro varchar
as
	declare @salidasConEntrega as table (EntregaID int, SalidaID int)
	
	insert into @salidasConEntrega 
	SELECT E.EntregaID , E.SalidaID 
	FROM Pruebas.Entrega  E
	INNER JOIN Pruebas.SalidaProducto SP ON E.SalidaID = SP.SalidaID

	IF @filtro = 'P' --Pendientes de Entrega
		SELECT  SalidaID, CodigoSalida 
		FROM Pruebas.SalidaProducto WHERE SalidaID NOT IN (SELECT SalidaID from @salidasConEntrega)
		AND SocioID IS NOT NULL
	
		
	IF @filtro = 'E' --Entregadas (osea salidas que ya tienen creadas una entrega)
		SELECT  SalidaID, CodigoSalida 
		FROM Pruebas.SalidaProducto WHERE SalidaID IN (SELECT SalidaID from @salidasConEntrega)
		AND SocioID IS NOT NULL


go

exec spTraeSalidasCode 'p'
go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Salida >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE TYPE TipoSalidaProducto as TABLE(

	SalidaID int ,
	Codigo varchar(10),
	ProductoID int not null,
	Cantidad int ,
	BodegaID int 
)


go

CREATE OR ALTER PROCEDURE spAddUpdateSalProd
@salID int = null , @ventID int = null , @socID int = null , @fecha date, @bodDest int = null,  @detalle TipoSalidaProducto READONLY
as 
	begin
		
		begin transaction

			DECLARE @err varchar(50) = ''

	-->Valida Stock
		SELECT @err = dbo.fValidaStockSalProd(@salID, @ventID , @detalle ,@bodDest);
			IF ISNULL(@err, '') <> '' THROW 50001, @err, 1; --devuelve error personalizado
				

	-->Crea o Edita 
			IF @salID = 0 or @salID IS NULL
				begin	--nueva SALIDA
					INSERT INTO Pruebas.SalidaProducto (Fecha,SocioID,VentaID, BodegaDestino) VALUES
					(@fecha, @socID ,  @ventID,   @bodDest)
					IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
				end
			ELSE
				begin	--editar Factura
					UPDATE Pruebas.SalidaProducto SET Fecha = @fecha, SocioID = @socID , VentaID = @ventID, BodegaDestino = @bodDest
					WHERE SalidaID = @salID
					IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
				end	

	-->Valida si hubieron errores en la Factura
		IF @err = ''   
			begin
				
				IF @salID = 0 or @salID IS NULL --si es una nueva trae la mas reciente
					select top 1 @salID = SalidaID from pruebas.SalidaProducto order by SalidaID desc;

		-->Ejecuta y valida si hubieron errores en la SALIDA detalle
				exec spAddUpdateSalidaDet @salID, @ventID, @bodDest, @detalle  --************PENDIENTE
				IF @@ERROR = 0   --valida error al ingresar la SALIDA detalle
					begin
						commit;
						select @salID  
					end
				ELSE
					rollback;
			end
		ELSE
			rollback;

	end
go


select * from pruebas.SalidaProducto


GO


select * from pruebas.SalidaProductoDetalle

go
-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Salida Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spAddUpdateSalidaDet @salID int,  @ventID int, @bodDest int,
@detalle TipoSalidaProducto READONLY
as
	begin
		
		declare @prod int,  @bodID int, @cantNueva float , @cantAnterior float, @compromet float, @totExist float, @valBodDest int

		declare crsSalDet cursor for
		select ProductoID, BodegaID, Cantidad from @detalle 
		
		open crsSalDet; fetch next from crsSalDet into  @prod , @bodID , @cantNueva  


		IF @ventID = 0 or @ventID IS NULL 	-->Transferencias internas
			begin

				WHILE @@FETCH_STATUS = 0 
					begin
					
						select @cantAnterior = Cantidad from pruebas.SalidaProductoDetalle where SalidaID = @salID and ProductoID = @prod
					
					--> reduce stock bodega origen
						UPDATE Pruebas.BodegaDetalle SET TotalExistencias = TotalExistencias + ISNULL(@cantAnterior,0) - @cantNueva
						WHERE BodegaID = @bodID AND ProductoID = @prod

					--> valida bodega destino
						select @valBodDest = TotalExistencias
						from pruebas.BodegaDetalle where BodegaID =  @bodDest  and ProductoID = @prod

						IF @valBodDest IS NULL
							INSERT INTO Pruebas.BodegaDetalle VALUES (@bodDest, @prod , 0, @cantNueva)

						ELSE
							UPDATE Pruebas.BodegaDetalle SET TotalExistencias = TotalExistencias - ISNULL(@cantAnterior,0) + @cantNueva
							WHERE BodegaID = @bodDest AND ProductoID = @prod
							
						fetch next from crsSalDet into  @prod , @bodID , @cantNueva 
					end
		
				deallocate crsSalDet

		
			end
		ELSE 	-->Salidas Basadas en Ventas
			begin
				WHILE @@FETCH_STATUS = 0 
					begin
						select @cantAnterior = ISNULL( Cantidad, 0) from pruebas.SalidaProductoDetalle where SalidaID = @salID and ProductoID = @prod

						--valida que no quede negativo ni nulo 
						--select @totExist = TotalExistencias , @compromet = Comprometido
						--from pruebas.BodegaDetalle WHERE BodegaID = @bodID AND ProductoID = @prod

						UPDATE Pruebas.BodegaDetalle SET TotalExistencias = TotalExistencias +  ISNULL(@cantAnterior,0) - @cantNueva, 
						Comprometido = Comprometido +  ISNULL(@cantAnterior,0) - @cantNueva
						WHERE BodegaID = @bodID AND ProductoID = @prod
				
						fetch next from crsSalDet into  @prod , @bodID , @cantNueva 
					end
		
				deallocate crsSalDet
			end
		
	--> Actualiza factura detalle
		delete from pruebas.SalidaProductoDetalle where SalidaID = @salID
		insert into Pruebas.SalidaProductoDetalle
		SELECT @salID, ProductoID, Cantidad, BodegaID FROM @detalle
		

	end
go
	


	select * from pruebas.SalidaProductoDetalle



	select * from pruebas.Venta v
	inner join pruebas.VentaDetalle vd on v.VentaID = vd.VentaID 
	where v.VentaID = 20

	select * from pruebas.bodega
	select * from pruebas.BodegaDetalle 

	select * from pruebas.Producto