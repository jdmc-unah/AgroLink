



use AgroLinkDB

begin transaction

go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Agrega Saldo al Socio si es Credito y Actualiza el stock comprometido >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER TRIGGER tAddSaldoStock on Pruebas.VentaDetalle for Insert
as
	
	declare @ventID int,  @tipoPago varchar(50), @socID int, @totalVenta float		

	select top 1 @ventID = VentaID from inserted
	print(@ventID)
	select @tipoPago = TipoPago, @socID = SocioID from pruebas.Venta where VentaID = @ventID

	IF @tipoPago = 'Credito'
		begin
			select @totalVenta = ISNULL(SUM(Total), 0) from inserted i 
			update pruebas.Socio set Saldo += @totalVenta
			where SocioID = @socID
		end

	

	---pendiente validar que si es mas o menos lo que se esta editando

	Update Pruebas.BodegaDetalle Set  Comprometido += I.Cantidad
	FROM Pruebas.BodegaDetalle BD
	INNER JOIN inserted I on BD.ProductoID = I.ProductoID AND BD.BodegaID = I.BodegaID
	--INNER JOIN Pruebas.VentaDetalle vd on i.VentaID = vd.VentaID
	--where vd.Cantidad <> i.Cantidad

	

go


-- Declarar la variable tipo tabla
DECLARE @DatosPrueba AS TipoVentaDetalle;

-- Insertar datos de prueba
INSERT INTO @DatosPrueba (VentaID,Codigo,  ProductoID, BodegaID, Cantidad,	Precio, SubTotal, ImpuestoID, Total)
VALUES
(2,'PRO11',2,2,1,25.00,25,1,28.75),
(2,'PRO14',3,3,1,850.00,850,1,977.5),
(0,'PRO14',4,4,1,850.00,850,1,977.5)

EXEC spAddUpdateVentaDet 2, @DatosPrueba;

select * from pruebas.Socio where socioid=8

select * from pruebas.ventaDetalle where ventaid = 2
select * from pruebas.venta where socioid=8









rollback

