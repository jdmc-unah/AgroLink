


use agrolinkdb

go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda por Codigo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarFactura @cod varchar(10)
as
	BEGIN 
		SELECT * FROM vTraeFacturas WHERE CodigoFactura LIKE '%' + @cod + '%' or Socio like '%' + @cod + '%'
	END

go



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Factura Filtrada >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spTraeFacturaFiltrada @factID int, @ventID int 
as
	begin
		
		IF @factID = 0
			begin
				SELECT VentaID, SocioID, ListaPreciosID, '' [CodigoFactura], '' [CAI], GETDATE() [Fecha], 
				1 [EmpleadoID],1 [NumFiscalID], '' [MetodoPago], 'Abierto' [Estado]
				FROM Pruebas.Venta WHERE VentaID = @ventID
			end
		ELSE
			SELECT FacturaID, CodigoFactura, Fecha, SocioID, ListaPreciosID, EmpleadoID, MetodoPago, CAI ,Estado,VentaID, NumFiscalID
			FROM vTraeFacturas WHERE FacturaID = @factID 

	end
go

exec spTraeFacturaFiltrada 0, 1


select * from pruebas.Factura
select * from pruebas.Venta



go



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Factura Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeFacturaDetalle @factID int , @ventID int
as
	begin
		
		declare @ventaDetalle as table (VentaID int, CodigoProducto varchar(50), ProductoID int, BodegaID int, Cantidad int , 
		Precio decimal(10,2), ImpuestoID int, Subtotal decimal(10,2), Total decimal(10,2))

	-->Valida si es una nueva factura
		IF @factID = 0
			begin
				--Trae los datos de la venta en la cual esta basada la factura
				INSERT INTO @ventaDetalle
				exec spTraeVentaDetalle @ventID

				SELECT @factID [FacturaID], CodigoProducto, ProductoID, BodegaID, Cantidad, Precio, ImpuestoID, Subtotal, Total
				FROM @ventaDetalle
			end
		ELSE
			BEGIN
				--Trae los datos de la factura ya existente
				SELECT FD.FacturaID,  P.CodigoProducto , FD.ProductoID , FD.BodegaID,
				FD.Cantidad, FD.Precio,  FD.ImpuestoID, (FD.Cantidad * FD.Precio) as 'Subtotal' , FD.Total 

				FROM (SELECT * FROM Pruebas.FacturaDetalle WHERE FacturaID = @factID) FD 
				INNER JOIN Pruebas.Producto P ON FD.ProductoID = P.ProductoID
				INNER JOIN Pruebas.Impuesto I ON FD.ImpuestoID = I.ImpuestoID
				INNER JOIN Pruebas.Bodega B ON FD.BodegaID = B.BodegaID
			END
	end
go


exec spTraeFacturaDetalle 0, 0

go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Cancelar Factura >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spCancelarFactura @factID int, @error varchar(50) OUTPUT
as
	begin		
		SET @error = ''

		IF @factID <> 0
			begin
			--> Actualiza el estado a cancelado
				UPDATE Pruebas.Factura SET Estado = 'Cancelado' WHERE FacturaID = @factID
			end
		ELSE
			SET @error = 'No puede usar estado Cancelado en nueva factura'

		return
	
	end
	

GO




-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Factura >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE TYPE TipoFacturaDetalle as TABLE(
	FacturaID int ,	
	Codigo varchar(15),
	ProductoID int not null,
	BodegaID int not null,
	Cantidad int not null,
	Precio decimal(10,2) not null ,
	SubTotal decimal(10,2),
	ImpuestoID int not null,
	Total decimal(10,2) not null 
)

go

select * from pruebas.Factura

go


CREATE OR ALTER PROCEDURE spAddUpdateFactura
@factID int , @ventID int , @socID int , @listPrecID int , @fecha date, @metodoPago varchar(50) , 
@cai varchar(50) , @empleadoID int , @numFiscalID int , @estado varchar(50),@detalle TipoFacturaDetalle READONLY
as 
	begin
		
		begin transaction

			DECLARE @err varchar(50) = '', @resCancelacion varchar(50)


	--> Valida si la factura lleva estado Cancelado
			IF @estado = 'Cancelado'
				begin
					exec spCancelarFactura @factID, @error = @resCancelacion OUTPUT
					IF ISNULL(@resCancelacion, '') <> '' THROW 50001, @resCancelacion, 1; --devuelve error personalizado
					
					commit;
					select @factID ;
					return;
				end



	-->Valida Stock
			--SELECT @err = dbo.fValidaStockF(@detalle);
			--IF ISNULL(@err, '') <> '' THROW 50001, @err, 1; --devuelve error personalizado
				

	-->Crea o Edita Factura
			IF @factID = 0
				begin	--nueva Factura
					--Asigna Siguiente Numero CAI
					SELECT @cai = dbo.fSecuenciaCAI(@numFiscalID)  --obtiene siguiente numeracion cai

					INSERT INTO Pruebas.Factura (VentaID, SocioID, ListaPreciosID, EmpresaID, Fecha,  MetodoPago, 
					CAI, EmpleadoID, Estado, NumFiscalID) VALUES

					(@ventID, @socID , @listPrecID, 1 , @fecha, @metodoPago, @cai, @empleadoID, @estado,@numFiscalID  )
					IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
				end
			ELSE
				begin	--editar Factura
					UPDATE Pruebas.Factura SET VentaID = @ventID, SocioID = @socID , ListaPreciosID = @listPrecID, EmpresaID = 1,
					Fecha = @fecha , MetodoPago = @metodoPago, CAI = @cai, EmpleadoID = @empleadoID, Estado = @estado , NumFiscalID = @numFiscalID
					WHERE FacturaID = @factID
					IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
				end	

	-->Valida si hubieron errores en la Factura
		IF @err = ''   
			begin
				
				IF @factID = 0  --si es una nueva fact trae la nueva fact creada
					select top 1 @factID = facturaID from pruebas.Factura order by facturaID desc;

		-->Ejecuta y valida si hubieron errores en la Factura detalle
				exec spAddUpdateFactDet @factID, @ventID, @estado, @detalle 
				IF @@ERROR = 0   --valida error al ingresar la Factura detalle
					begin
						commit;
						select @factID  --devuelve la venta que se agrego o editó
					end
				ELSE
					rollback;
			end
		ELSE
			rollback;

	end
go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Factura Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spAddUpdateFactDet @factID int,  @ventID int, @estadoFact varchar(20),  
@detalle TipoFacturaDetalle READONLY
as
	begin
		declare  @tipoPago varchar(50), @socID int, @nuevoTotalFact float, @totalVenta float, @totFactsPagadas float,    @saldo float		


	-->Llena variables a utilizar
		select @tipoPago = TipoPago, @socID = SocioID from pruebas.Venta where VentaID = @ventID --credito o contado para afectar el saldo

		select @nuevoTotalFact = ISNULL(SUM(Total), 0) from @detalle   --lo que se esta pagando en la transaccion actual
		
		select @totalVenta = ISNULL(SUM(Total), 0) from pruebas.VentaDetalle where  VentaID = @ventID --total a pagar

		select @totFactsPagadas = ISNULL(SUM(FD.Total), 0)  --total que se ha pagado hasta el momento
		from pruebas.FacturaDetalle FD inner join pruebas.Factura F ON FD.FacturaID = F.FacturaID  
		WHERE F.VentaID = @ventID and F.Estado = 'Cerrado' AND F.FacturaID <> @factID


	--> Actualiza saldo de socio con ventas al credito
		IF @tipoPago = 'Credito' AND @estadoFact = 'Cerrado'
			begin
				--valida que no quede negativo
				select @saldo = ( CASE  WHEN Saldo - @nuevoTotalFact < 0 THEN 0 ELSE Saldo - @nuevoTotalFact  END ) 
				from pruebas.Socio where SocioID = @socID 
				
				update pruebas.Socio set Saldo = @saldo where SocioID = @socID
			end

	--> Cierra la venta en la que esta basada la factura una vez se confirme que se pago por completo
		IF @estadoFact = 'Cerrado' AND (@totFactsPagadas + @nuevoTotalFact) = @totalVenta
			update pruebas.Venta set Estado = 'Cerrado' where VentaID = @ventID


	--> Actualiza factura detalle
		delete from pruebas.FacturaDetalle where FacturaID= @factID
		insert into Pruebas.FacturaDetalle
		SELECT @factID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total FROM @detalle
		

	end
go
	



select * from pruebas.socio where socioid = 2

select * from pruebas.Venta f
inner join pruebas.VentaDetalle fd on f.VentaID = fd.VentaID 
where f.SocioID = 5

select * from pruebas.Factura f
inner join pruebas.FacturaDetalle fd on f.FacturaID = fd.FacturaID 
where f.SocioID = 5

select * from pruebas.BodegaDetalle





