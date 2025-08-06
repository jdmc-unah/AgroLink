-- PROCEDIMIENTOS ALMACENADOS PARA PANTALLA COMPRA Y COMPRA DETALLE



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Precio Compra >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spTraePrecioCompra @listPrecID int, @detalle TipoCompraDetalle READONLY
as
	begin
		declare @precios as table (ProductoID int, Precio float) 
		declare @hayNulos int = 0

		insert into @precios
		select ProductoID, Precio from pruebas.ProductoDetalle 
		where ListaPreciosID = @listPrecID and ProductoID in (select ProductoID from @detalle)
	
		select @hayNulos = CASE when P.Precio IS NULL then 1 else 0 end
		from @detalle d left join @precios p on d.ProductoID = p.ProductoID

		IF ISNULL(@hayNulos,1) = 1
			THROW 50004, 'El producto no esta asignado a esa lista de precios', 1;
		ELSE
			SELECT * from @precios

	end


go



-- busqueda de compra por codigo

create or alter procedure spBuscarCompra
    @codigo varchar(10)
as
	begin
    select * from vTraeCompras 
    where cast(CodigoCompra as varchar) like '%' + @codigo + '%' or Socio like '%' + @codigo + '%'
end
go

-- traer compra detalle

create or alter procedure spTraeCompraDetalle @compraid int
as
	begin
		select cd.CompraID, p.CodigoProducto, cd.ProductoID, cd.BodegaID, cd.Cantidad, cd.Precio, cd.ImpuestoID, 
			   (cd.Cantidad * cd.Precio) as 'Subtotal', cd.Total
    from Pruebas.CompraDetalle cd
    inner join Pruebas.Producto p on cd.ProductoID = p.ProductoID
    inner join Pruebas.Impuesto i on cd.ImpuestoID = i.ImpuestoID
    inner join Pruebas.Bodega b on cd.BodegaID = b.BodegaID
    where cd.CompraID = @compraid
end
go

-- traer compra filtrada

create or alter procedure spTraeCompraFiltrada @compraid int
as
begin
    select CompraID, CodigoCompra, Fecha, SocioID, ListaPreciosID, TipoPago, Estado
	from vTraeCompras 
	where CompraID = @compraid
end
go


-- trae compra filtrada (id y codigo)

create or alter procedure spTraeComprasCode @reciboID int = null 
as
begin
	declare @compraID int = null

	if @reciboID is not null and @reciboID <> 0
	select @compraID = CompraID from Pruebas.Recibo where ReciboID = @reciboID
			
	if @reciboID = 0 or @reciboID is null
	select CompraID, CodigoCompra from Pruebas.Compra where Estado = 'Abierto'

	else
	select CompraID, CodigoCompra from Pruebas.Compra where CompraID = @compraID
	
	union

	select CompraID, CodigoCompra from Pruebas.Compra where Estado = 'Abierto' and CompraID <> @compraID
end
go


-- actualizar y agregar compra

CREATE OR ALTER PROCEDURE spAddUpdateCompra
    @compraid INT,
    @fecha DATE,
    @socid INT,
    @listPrecid INT,
    @tipoPago VARCHAR(50),
    @estado VARCHAR(50),
    @detalle TipoCompraDetalle READONLY
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @err VARCHAR(50) = '', @resCancelacion VARCHAR(50);

        -- Valida si la compra lleva estado Cancelado
        IF @estado = 'Cancelado'
        BEGIN
            EXEC spCancelarCompra @compraid, @socid, @error = @resCancelacion OUTPUT;
            IF ISNULL(@resCancelacion, '') <> ''
            
                -- Lanza error personalizado, irá al CATCH
                THROW 50001, @resCancelacion, 1;
            

            COMMIT TRANSACTION;
            SELECT @compraid;
            RETURN;
        END

        -- Comentado: validación stock (si aplica)
        -- SELECT @err = dbo.fValidaStockCompra(@detalle);
        -- IF ISNULL(@err, '') <> '' THROW 50002, @err, 1;

        -- Crea o edita compra
        IF @compraid = 0
        BEGIN
            INSERT INTO pruebas.compra (fecha, socioid, listapreciosid, tipopago, estado)
            VALUES (@fecha, @socid, @listprecid, @tipopago, @estado);

            IF @@ERROR <> 0 AND @err = '' SET @err = 'Error al insertar compra';
        END
        ELSE
        BEGIN
            UPDATE pruebas.compra
            SET fecha = @fecha,
                socioid = @socid,
                listapreciosid = @listprecid,
                tipopago = @tipopago,
                estado = @estado
            WHERE compraid = @compraid;

            IF @@ERROR <> 0 AND @err = '' SET @err = 'Error al actualizar compra';
        END

        IF @err <> ''
        
            THROW 50003, @err, 1;
        

        -- Obtiene el ID si es nuevo
        IF @compraid = 0
        BEGIN
            SELECT TOP 1 @compraid = compraid FROM pruebas.compra ORDER BY compraid DESC;
        END

        -- Ejecuta detalle
        EXEC spAgregarCompraDetalle @compraid, @detalle;

        COMMIT TRANSACTION;

        SELECT @compraid;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END
GO

-- actualizar el saldo de un socio al registrar una compra al credito
create or alter procedure spActualizarSaldoSocioCompraDetalle @compraID int
as
begin
    declare @socioID int, @tipoPago varchar(20), @totalCompra float, @saldoActual float

    -- obtener el socio y tipo de pago de la compra
    select @socioID = SocioID, @tipoPago = TipoPago
    from Pruebas.Compra
    where CompraID = @compraID

    -- si la compra es al crédito, actualizar saldo
    if @tipoPago = 'Credito'
    begin
        -- sumamos el total de la compra actual
        select @totalCompra = isnull(sum(Total), 0)
        from Pruebas.CompraDetalle
        where CompraID = @compraID

        -- obtenemos el saldo actual del socio
        select @saldoActual = Saldo
        from Pruebas.Socio
        where SocioID = @socioID;

        -- se actualiza el saldo (empresa le debe más al socio deberia ser negativo)
        set @saldoActual = @saldoActual - @totalCompra

        update Pruebas.Socio
        set Saldo = @saldoActual
        where SocioID = @socioID;
    end
end
go

-- sp para cancelar una compra

CREATE OR ALTER PROCEDURE spCancelarCompra 
    @compraID INT, 
    @socID INT, 
    @error VARCHAR(255) OUTPUT
AS
BEGIN
    SET @error = ''

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Validar que la compra exista
        IF NOT EXISTS (SELECT 1 FROM Pruebas.Compra WHERE CompraID = @compraID)
        BEGIN
            SET @error = 'La compra no existe.'; THROW 50011, @error, 1
        END

        -- Obtener tipo de pago de la compra
        DECLARE @tipoPago VARCHAR(50);
        SELECT @tipoPago = TipoPago FROM Pruebas.Compra WHERE CompraID = @compraID;

        -- Revertir stock: restar cantidades de la compra cancelada
        UPDATE bd
        SET bd.TotalExistencias = CASE 
                                    WHEN bd.TotalExistencias - cd.Cantidad < 0 THEN 0 
                                    ELSE bd.TotalExistencias - cd.Cantidad 
                                  END
        FROM Pruebas.BodegaDetalle bd
        INNER JOIN Pruebas.CompraDetalle cd 
            ON bd.BodegaID = cd.BodegaID 
            AND bd.ProductoID = cd.ProductoID
        WHERE cd.CompraID = @compraID;

        -- Cambiar estado de la compra a 'Cancelado'
        UPDATE Pruebas.Compra 
        SET Estado = 'Cancelado' 
        WHERE CompraID = @compraID;

        -- Recalcular saldo del socio
        EXEC spActualizarSaldoSocioCompraDetalle @socID

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SET @error = ERROR_MESSAGE()
        RETURN
    END CATCH
END
GO


-- actualizar y agregar compra detalle

create type TipoCompraDetalle as table 
(
	CompraID	int,
	Codigo 		varchar(15),
	ProductoID	int,
	BodegaID	int,
	Cantidad	int,
	Precio		decimal(10, 2),
	SubTotal	decimal(10, 2),
	ImpuestoID	int,
	Total		decimal(10, 2)
)
go

create or alter procedure spAgregarCompraDetalle @compraid int, @detalle TipoCompraDetalle readonly
as
begin
    declare @tipopago varchar(50), @socid int, @totalnuevo float, @totalanterior float, @saldo float		

    select @tipopago = TipoPago, @socid = SocioID 
    from Pruebas.Compra 
    where CompraID = @compraid

    -- se actualiza el detalle de compra y existencias
    declare @prod int, @bodid int, @cantnueva float, @cantanterior float, @existencias float

    declare crsCompraDet cursor for
        select ProductoID, BodegaID, Cantidad 
        from @detalle

    open crsCompraDet fetch next from crsCompraDet into @prod, @bodid, @cantnueva

    while @@FETCH_STATUS = 0
    begin
        -- si no existe el producto en la bodega, insertarlo con existencias 0
        if not exists (select 1 from Pruebas.BodegaDetalle where BodegaID = @bodid and ProductoID = @prod)
        begin
            insert into Pruebas.BodegaDetalle (BodegaID, ProductoID, TotalExistencias)
            values (@bodid, @prod, 0)
        end

        select @cantanterior = Cantidad 
        from Pruebas.CompraDetalle 
        where CompraID = @compraid and ProductoID = @prod

        -- valida existencias para no dejar negativas
        select @existencias = 
        case  
            when TotalExistencias - isnull(@cantanterior, 0) < 0 then 0 
            else TotalExistencias - isnull(@cantanterior, 0)
        end
        from Pruebas.BodegaDetalle 
        where BodegaID = @bodid and ProductoID = @prod

        update Pruebas.BodegaDetalle 
        set TotalExistencias = @existencias + @cantnueva
        where BodegaID = @bodid and ProductoID = @prod

        fetch next from crsCompraDet into @prod, @bodid, @cantnueva
    end

    deallocate crsCompraDet

    -- validación de impuestos en detalle
    if exists 
    (
        select 1 from @detalle d
        where not exists (select 1 from Pruebas.Impuesto i where i.ImpuestoID = d.ImpuestoID)
    )
        throw 50010, 'Existen filas con ImpuestoID inválido en el detalle de compra.', 1

    -- actualiza el detalle eliminando lo anterior y agregando lo nuevo
    delete from Pruebas.CompraDetalle where CompraID = @compraid

    insert into Pruebas.CompraDetalle (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total)
    select @compraid, d.ProductoID, d.ImpuestoID, d.BodegaID, d.Cantidad, d.Precio, d.Total 
    from @detalle d
    inner join Pruebas.Impuesto i on d.ImpuestoID = i.ImpuestoID

    -- actualiza el saldo del socio (si es al credito)
    exec spActualizarSaldoSocioCompraDetalle @compraid
end
go


