-- PROCEDIMIENTOS ALMACENADOS PARA PANTALLA RECIBO Y RECIBO DETALLE

-- buscar recibo x codigo

create or alter procedure spBuscarRecibo @cod varchar(10)
as
	begin
		select ReciboID, CodigoRecibo, Fecha, Socio, TipoSocio, ListaPrecio, MetodoPago, Estado, Empleado, Total, SocioID, ListaPreciosID, CompraID, EmpleadoID 
		from vTraeRecibos
		where CodigoRecibo like '%' + @cod + '%'or socio like '%' + @cod + '%'
	end
go

-- trae recibo filtrado
create or alter procedure spTraeReciboFiltrado @reciboid int, @compraid int 
as
	begin

		if @reciboid = 0
			begin
				select CompraID, SocioID, ListaPreciosID, '' [CodigoRecibo],  getdate() [Fecha], 1 [EmpleadoID], '' [MetodoPago], 'Abierto' [Estado]
				from Pruebas.Compra
				where CompraID = @compraid
			end
		else
			begin
				select ReciboID, CodigoRecibo, Fecha, SocioID, ListaPreciosID, EmpleadoID, MetodoPago, Estado, CompraID
				from vTraeRecibos 
				where ReciboID = @reciboid
			end
		end
go

-- trae recibo detalle

create or alter procedure spTraeReciboDetalle @reciboid int, @compraid int
as
	begin
		declare @compraDetalle as table 
		(
			CompraID int, 
			CodigoProducto varchar(50), 
			ProductoID int, 
			BodegaID int, 
			Cantidad int, 
			Precio decimal(10,2), 
			ImpuestoID int, 
			Subtotal decimal(10,2), 
			Total decimal(10,2)
		)

		if @reciboid = 0
		begin
			-- trae los datos de la compra en la cual se basar� el recibo
			insert into @compraDetalle
			exec spTraeCompraDetalle @compraid

			select 
				@reciboid [ReciboID], 
				CodigoProducto, 
				ProductoID, 
				BodegaID, 
				Cantidad, 
				Precio, 
				ImpuestoID, 
				Subtotal, 
				Total
			from @compraDetalle
		end
	else
		begin
			-- trae los datos del recibo existente
			select 
				RD.ReciboID,  
				P.CodigoProducto, 
				RD.ProductoID, 
				RD.BodegaID,
				RD.Cantidad, 
				RD.Precio,  
				RD.ImpuestoID, 
				(RD.Cantidad * RD.Precio) 'Subtotal', 
				RD.Total
			from (select * from Pruebas.ReciboDetalle where ReciboID = @reciboid) rd
			INNER JOIN Pruebas.Producto P on RD.ProductoID = P.ProductoID
			INNER JOIN Pruebas.Impuesto I on RD.ImpuestoID = I.ImpuestoID
			INNER JOIN Pruebas.Bodega B on RD.BodegaID = B.BodegaID			
		end
	end
go

-- cancelar recibo

CREATE OR ALTER PROCEDURE spCancelarRecibo @reciboID int, @error varchar(50) OUTPUT
AS
BEGIN		
    SET @error = ''

    IF @reciboID <> 0
    BEGIN
        -- actualiza el estado a 'Cancelado'
        UPDATE Pruebas.Recibo 
        SET Estado = 'Cancelado' 
        WHERE ReciboID = @reciboID;

        IF @@ERROR <> 0 
            SET @error = 'Ocurri� un error al actualizar el estado del recibo'
    END
    ELSE
        SET @error = 'No puede usar estado Cancelado en nuevo recibo'

    RETURN
END
GO

-- actualiza y agrega recibo

create type TipoReciboDetalle as table 
(
	ReciboID int,	
	Codigo varchar(15),
	ProductoID int NOT NULL,
	BodegaID int NOT NULL,
	Cantidad int NOT NULL,
	Precio decimal(10,2) NOT NULL,
	SubTotal decimal(10,2),
	ImpuestoID int NOT NULL,
	Total decimal(10,2) NOT NULL 
)
go

CREATE OR ALTER PROCEDURE spAddUpdateRecibo @reciboID int, @compraID int, @socID int, @listPrecID int, @fecha date, @metodoPago varchar(50), @empleadoID int, @estado varchar(50), 
@detalle TipoReciboDetalle READONLY
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @err varchar(50) = '', @resCancelacion varchar(50)

    -- valida si el recibo lleva estado Cancelado
    IF @estado = 'Cancelado'
    BEGIN
        EXEC spCancelarRecibo @reciboID, @error = @resCancelacion OUTPUT
        IF ISNULL(@resCancelacion, '') <> '' THROW 50001, @resCancelacion, 1 -- devuelve error personalizado

        COMMIT
        SELECT @reciboID
        RETURN
    END

    -- crea o Actualiza Recibo
    IF @reciboID = 0
		BEGIN
        -- nuevo Recibo
			INSERT INTO Pruebas.Recibo (CompraID, SocioID, ListaPreciosID, Fecha, MetodoPago, EmpleadoID, Estado)
			VALUES (@compraID, @socID, @listPrecID, @fecha, @metodoPago, @empleadoID, @estado)

			IF @@ERROR <> 0 AND @err = '' SET @err = 'Error al insertar Recibo'
		END
    ELSE
    BEGIN
        -- editar Recibo
        UPDATE Pruebas.Recibo
        SET CompraID = @compraID,
            SocioID = @socID,
            ListaPreciosID = @listPrecID,
            Fecha = @fecha,
            MetodoPago = @metodoPago,
            EmpleadoID = @empleadoID,
            Estado = @estado
        WHERE ReciboID = @reciboID

        IF @@ERROR <> 0 AND @err = '' SET @err = 'Error al actualizar Recibo'
    END

    -- si no hubo error, contin�a con el detalle
    IF @err = ''
    BEGIN
        IF @reciboID = 0
            SELECT TOP 1 @reciboID = ReciboID FROM Pruebas.Recibo ORDER BY ReciboID DESC

        -- ejecuta y valida el detalle del recibo
        EXEC spAddUpdateReciboDet @reciboid, @compraid, @estado, @detalle;

        IF @@ERROR = 0
        BEGIN
            COMMIT
            SELECT @reciboid
        END
        ELSE
        BEGIN
            ROLLBACK
        END
    END
    ELSE
    BEGIN
        ROLLBACK
    END
END
GO



-- actualiza y agrega recibo detalle

CREATE OR ALTER PROCEDURE spAddUpdateReciboDet 
@reciboID INT,  
@compraID INT,
@estadoRecibo VARCHAR(20),  
@detalle TipoReciboDetalle READONLY
AS
BEGIN
    DECLARE @tipoPago VARCHAR(50), @socID INT, 
            @nuevoTotalRecibo FLOAT, @totalCompra FLOAT, @totalRecibosPagados FLOAT, @saldo FLOAT		

    -- llena variables necesarias
    SELECT @tipoPago = TipoPago, @socID = SocioID 
    FROM Pruebas.Compra 
    WHERE CompraID = @compraID;

    SELECT @nuevoTotalRecibo = ISNULL(SUM(Total), 0) FROM @detalle;  -- Total de este recibo

    SELECT @totalCompra = ISNULL(SUM(Total), 0) 
    FROM Pruebas.CompraDetalle 
    WHERE CompraID = @compraID;

    SELECT @totalRecibosPagados = ISNULL(SUM(RD.Total), 0)  
    FROM Pruebas.ReciboDetalle RD
    INNER JOIN Pruebas.Recibo R ON RD.ReciboID = R.ReciboID  
    WHERE R.CompraID = @compraID AND R.Estado = 'Cerrado' AND R.ReciboID <> @reciboID

    -- actualiza saldo del socio si la compra fue a credito y el recibo se cerro
    IF @tipoPago = 'Credito' AND @estadoRecibo = 'Cerrado'
    BEGIN
        -- valida saldo no negativo
        SELECT @saldo = CASE WHEN Saldo - @nuevoTotalRecibo < 0 THEN 0 ELSE Saldo - @nuevoTotalRecibo END
        FROM Pruebas.Socio WHERE SocioID = @socID
        
        UPDATE Pruebas.Socio 
        SET Saldo = @saldo 
        WHERE SocioID = @socID
    END

    -- cierra la compra si ya se pago completamente
    IF @estadoRecibo = 'Cerrado' AND (@totalRecibosPagados + @nuevoTotalRecibo) = @totalCompra
    BEGIN
        UPDATE Pruebas.Compra 
        SET Estado = 'Cerrado' 
        WHERE CompraID = @compraID
    END

	IF EXISTS (
        SELECT 1 FROM @detalle d
        WHERE NOT EXISTS (SELECT 1 FROM Pruebas.Impuesto i WHERE i.ImpuestoID = d.ImpuestoID)
    )
    
        THROW 50020, 'Existen filas con ImpuestoID inválido en el detalle del recibo.', 1

    -- actualiza ReciboDetalle
    DELETE FROM Pruebas.ReciboDetalle WHERE ReciboID = @reciboID

    INSERT INTO Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total)
    SELECT @reciboID, d.ProductoID, d.ImpuestoID, d.BodegaID, d.Cantidad, d.Precio, d.Total 
    FROM @detalle d
	inner join Pruebas.Impuesto i on i.ImpuestoID = d.ImpuestoID
END
GO

