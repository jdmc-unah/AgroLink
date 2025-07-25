


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
		SELECT FacturaID, CodigoFactura, Fecha, SocioID, ListaPreciosID, EmpleadoID, MetodoPago, CAI ,Estado
		FROM vTraeFacturas WHERE FacturaID = @factID

	end
go

--exec spTraeFacturaFiltrada 1



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Venta Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


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

select * from pruebas.factura

go


CREATE OR ALTER PROCEDURE spAddUpdateFactura
@factID int , @ventID int , @socID int , @listPrecID int , @fecha date, @metodoPago varchar(50) , 
@cai varchar(50) , @empleadoID int , @estado varchar(50),@detalle TipoVentaDetalle READONLY
as 
	begin
		
		begin transaction

			DECLARE @err varchar(50) = ''

	-->Valida Stock
			SELECT @err = dbo.fValidaStock(@detalle);
			IF ISNULL(@err, '') <> '' THROW 50001, @err, 1; --devuelve error personalizado
				







	-->Crea o Edita Ventas
			IF @factID = 0
				--nueva venta
				INSERT INTO Pruebas.Factura (VentaID, SocioID, ListaPreciosID, EmpresaID, Fecha,  MetodoPago, 
				CAI, EmpleadoID, Estado, NumFiscalID) VALUES

				(@ventID, @socID , @listPrecID, 1 , @fecha, @metodoPago, @cai, @empleadoID, @estado, /*pendeinte*/ 1 /*pendeinte*/   )
				IF @@ERROR <> 0 AND @err = '' select @err = 'Error'












			ELSE
				--editar venta
				UPDATE Pruebas.Factura SET Fecha = @fecha , SocioID = @socID , ListaPreciosID = @listPrecID, 
				TipoPago = @tipoPago , Estado = @estado
				WHERE VentaID = @factID
				IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
					




	-->Valida si hubieron errores en la venta
		IF @err = ''   
			begin
				
				IF @factID = 0  --si es una nueva venta trae la nueva venta creada
					select top 1 @factID = facturaID from pruebas.Factura order by facturaID desc;

		-->Ejecuta y valida si hubieron errores en la venta detalle
			--	exec spAddUpdateVentaDet @ventID,  @detalle   ----------------***********PENDIENTE DE CREARLO 
				IF @@ERROR = 0   --valida error al ingresar la venta detalle
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




--pruebas del sp
begin transaction
--exec spAddUpdateVenta 0, '20250723' , 1,2,'Credito', 'Abierto'
exec spAddUpdateVenta 0,'2025/07/09',4,null , 'Credito','Abierto'

select * from pruebas.VentaDetalle
rollback






















-->>>>>>>>>>>>>>>>>>>>>>>>>>>>
SELECT * FROM PRUEBAS.Factura
SELECT * FROM PRUEBAS.FacturaDetalle

SELECT * FROM PRUEBAS.Socio











