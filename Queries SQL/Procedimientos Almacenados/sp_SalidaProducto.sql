
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
			SELECT @err = dbo.fValidaStockSalProd(@ventID ,@bodDest, @detalle);
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


go
-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Salida Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spAddUpdateSalidaDet @salID int,  @ventID int, @bodDest int,
@detalle TipoSalidaProducto READONLY
as
	begin
		declare @cantPrev float


		--select @cantPrev = Cantidad from
		--pruebas.SalidaProductoDetalle where 

		/*
		IF @ventID = 0 or @ventID IS NULL
			begin
			--> transferencia interna, reduce el stock libre osea el stock total
				
				-->decrementa stock en bodega origen
				update pruebas.BodegaDetalle set TotalExistencias = TotalExistencias + ISNULL(spd.Cantidad,0) - d.Cantidad
				from pruebas.BodegaDetalle bd
				inner join @detalle d on bd.BodegaID = d.BodegaID and bd.ProductoID = d.ProductoID
				left join pruebas.SalidaProductoDetalle spd on bd.BodegaID = spd.BodegaID

				----> incrementa stock en bodega destino
				--update pruebas.BodegaDetalle set TotalExistencias = TotalExistencias + ISNULL(spd.Cantidad,0) - d.Cantidad
				--from pruebas.BodegaDetalle bd
				--inner join @detalle d on bd.BodegaID = d.BodegaID and bd.ProductoID = d.ProductoID
				--left join pruebas.SalidaProductoDetalle spd on bd.BodegaID = spd.BodegaID

				

			end
		else
			begin
			--> transferencia basada en venta, reduce el stock total y comprometido
				update pruebas.BodegaDetalle set Comprometido = Comprometido + ISNULL(spd.Cantidad,0) - d.Cantidad,
				TotalExistencias = TotalExistencias + ISNULL(spd.Cantidad,0) - d.Cantidad
				from pruebas.BodegaDetalle bd
				inner join @detalle d on bd.BodegaID = d.BodegaID
				left join pruebas.SalidaProductoDetalle spd on bd.BodegaID = spd.BodegaID
			end
			*/
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