


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
CREATE OR ALTER PROCEDURE spTraeFacturaFiltrada @factID int
as
	begin
		SELECT FacturaID, CodigoFactura, Fecha, SocioID, ListaPreciosID, EmpleadoID, MetodoPago, CAI ,Estado,VentaID, NumFiscalID
		FROM vTraeFacturas WHERE FacturaID = @factID

	end
go

exec spTraeFacturaFiltrada 1

select * from vTraeFacturas



go




-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Factura Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeFacturaDetalle @factID int
as
	begin
		SELECT FD.FacturaID,  P.CodigoProducto , FD.ProductoID , FD.BodegaID,
		FD.Cantidad, FD.Precio,  FD.ImpuestoID, (FD.Cantidad * FD.Precio) as 'Subtotal' , FD.Total 

		FROM (SELECT * FROM Pruebas.FacturaDetalle WHERE FacturaID = @factID) FD 
		INNER JOIN Pruebas.Producto P ON FD.ProductoID = P.ProductoID
		INNER JOIN Pruebas.Impuesto I ON FD.ImpuestoID = I.ImpuestoID
		INNER JOIN Pruebas.Bodega B ON FD.BodegaID = B.BodegaID

	end
go


exec spTraeFacturaDetalle 1

go




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

			DECLARE @err varchar(50) = ''

	-->Valida Stock
			SELECT @err = dbo.fValidaStockF(@detalle);
			IF ISNULL(@err, '') <> '' THROW 50001, @err, 1; --devuelve error personalizado
				
		--Asigna Siguiente Numero CAI

	-->Crea o Edita Factura
			IF @factID = 0
				
				--nueva Factura

				SELECT @cai = dbo.fSecuenciaCAI(@numFiscalID)  --obtiene siguiente numeracion cai

				INSERT INTO Pruebas.Factura (VentaID, SocioID, ListaPreciosID, EmpresaID, Fecha,  MetodoPago, 
				CAI, EmpleadoID, Estado, NumFiscalID) VALUES

				(@ventID, @socID , @listPrecID, 1 , @fecha, @metodoPago, @cai, @empleadoID, @estado,@numFiscalID  )
				IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
			ELSE

				--editar Factura
				UPDATE Pruebas.Factura SET VentaID = @ventID, SocioID = @socID , ListaPreciosID = @listPrecID, EmpresaID = 1,
				Fecha = @fecha , MetodoPago = @metodoPago, CAI = @cai, EmpleadoID = @empleadoID, Estado = @estado , NumFiscalID = @numFiscalID
				WHERE FacturaID = @factID
				IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
					

	-->Valida si hubieron errores en la Factura
		IF @err = ''   
			begin
				
				IF @factID = 0  --si es una nueva fact trae la nueva fact creada
					select top 1 @factID = facturaID from pruebas.Factura order by facturaID desc;

		-->Ejecuta y valida si hubieron errores en la Factura detalle
			--	exec spAddUpdateVentaDet @ventID,  @detalle   ----------------***********PENDIENTE DE CREARLO 
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























-->>>>>>>>>>>>>>>>>>>>>>>>>>>>
SELECT * FROM PRUEBAS.Factura
SELECT * FROM PRUEBAS.FacturaDetalle

SELECT * FROM PRUEBAS.Socio











