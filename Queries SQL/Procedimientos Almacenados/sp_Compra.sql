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

-- trae compra pendiente de sacar producto completo

CREATE OR ALTER PROCEDURE spTraeComprasEntradaComp
AS
BEGIN
    DECLARE @comprasConEntradaCompleta AS TABLE (EntradaID INT, CompraID INT)

    INSERT INTO @comprasConEntradaCompleta
    SELECT DISTINCT EPD.EntradaID, CD.CompraID
    FROM Pruebas.EntradaProducto EP
    INNER JOIN Pruebas.EntradaProductoDetalle EPD ON EP.EntradaID = EPD.EntradaID
    INNER JOIN Pruebas.Compra C ON EP.CompraID = C.CompraID
    INNER JOIN Pruebas.CompraDetalle CD ON CD.CompraID = C.CompraID
    WHERE CD.Cantidad = EPD.Cantidad AND CD.ProductoID = EPD.ProductoID

    SELECT CompraID, CodigoCompra
    FROM Pruebas.Compra
    WHERE CompraID NOT IN (SELECT CompraID FROM @comprasConEntradaCompleta)
    AND Estado <> 'Cancelado'
END
GO


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


CREATE OR ALTER PROCEDURE spCancelarCompra 
    @compraID INT, 
    @socID INT, 
    @error VARCHAR(255) OUTPUT
AS
BEGIN
    SET @error = '';

    BEGIN TRY
        BEGIN TRANSACTION;

        -- validar que compra exista
        IF NOT EXISTS (SELECT 1 FROM Pruebas.Compra WHERE CompraID = @compraID)
        BEGIN
            SET @error = 'La compra no existe.';
            THROW 50011, @error, 1;
        END

        -- obtener tipo de pago (no es estrictamente necesario aquí, pero si quieres usarlo puedes)
        DECLARE @tipoPago VARCHAR(50);
        SELECT @tipoPago = TipoPago FROM Pruebas.Compra WHERE CompraID = @compraID;

		-- actualiza saldo de socio con compras al crédito
		if @tipopago = 'Credito'
		begin
			declare @totalanterior float, @saldo float

			select @totalanterior = isnull(sum(total), 0) from pruebas.compradetalle where compraid = @compraid;

			-- valida que no quede negativo
			--select @saldo = (case when saldo - @totalanterior < 0 then 0 else saldo - @totalanterior end) 
			--from pruebas.socio where socioid = @socid;

			select @saldo = case when saldo < 0 then  saldo + @totalanterior else saldo - @totalanterior end
			from pruebas.socio where socioid = @socid;

			update pruebas.socio set saldo = @saldo 
			where socioid = @socid;
		end



        -- revertir stock: restar cantidades de la compra cancelada
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

        -- Cambiar estado a 'Cancelado'
        UPDATE Pruebas.Compra 
        SET Estado = 'Cancelado' 
        WHERE CompraID = @compraID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SET @error = ERROR_MESSAGE();
        RETURN;
    END CATCH
END
GO



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


create or alter procedure spAgregarCompraDetalle 
    @compraid int, 
    @detalle TipoCompraDetalle readonly
as
begin
    declare @tipopago varchar(50), @socid int, @totalnuevo float, @totalanterior float, @saldo float;		

    select @tipopago = TipoPago, @socid = SocioID from pruebas.compra where compraid = @compraid;

    -- actualiza saldo de socio con compras al crédito
    if @tipopago = 'Credito'
    begin
        select @totalnuevo = isnull(sum(total), 0) from @detalle;
        select @totalanterior = isnull(sum(total), 0) from pruebas.compradetalle where compraid = @compraid;

        -- valida que no quede negativo
        --select @saldo = (case when saldo - @totalanterior < 0 then 0 else saldo - @totalanterior end) 
        --from pruebas.socio where socioid = @socid;

		select @saldo = case when saldo < 0 then  saldo + @totalanterior else saldo - @totalanterior end
        from pruebas.socio where socioid = @socid;

        update pruebas.socio set saldo = @saldo - @totalnuevo
        where socioid = @socid;
    end

    declare @prod int, @bodid int, @cantnueva float, @cantanterior float, @existencias float;

    declare crsCompraDet cursor for
        select productoid, bodegaid, cantidad from @detalle;

    open crsCompraDet;
    fetch next from crsCompraDet into @prod, @bodid, @cantnueva;

    while @@fetch_status = 0
    begin
        -- Si no existe el producto en la bodega, insertarlo con existencias 0
        if not exists (select 1 from pruebas.bodegadetalle where bodegaid = @bodid and productoid = @prod)
        begin
            insert into pruebas.bodegadetalle (BodegaID, ProductoID, TotalExistencias)
            values (@bodid, @prod, 0);
        end

        select @cantanterior = cantidad from pruebas.compradetalle where compraid = @compraid and productoid = @prod;

        -- valida que no quede negativo ni nulo 
        select @existencias = 
        (
            case  
                when TotalExistencias - isnull(@cantanterior, 0) < 0 then 0 
                else TotalExistencias - isnull(@cantanterior, 0)
            end
        ) 
        from pruebas.bodegadetalle where bodegaid = @bodid and productoid = @prod;

        update pruebas.bodegadetalle 
        set TotalExistencias = @existencias + @cantnueva
        where bodegaid = @bodid and productoid = @prod;

        fetch next from crsCompraDet into @prod, @bodid, @cantnueva;
    end

    deallocate crsCompraDet;

    if exists 
    (
        select 1 from @detalle d
        where not exists (select 1 from Pruebas.Impuesto i where i.ImpuestoID = d.ImpuestoID)
    )
        THROW 50010, 'Existen filas con ImpuestoID inválido en el detalle de compra.', 1;

    -- Actualiza el detalle eliminando lo anterior y agregando lo nuevo
    delete from Pruebas.compradetalle where compraid = @compraid;

    insert into pruebas.compradetalle (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total)
    select @compraid, d.ProductoID, d.impuestoid, d.bodegaid, d.cantidad, d.precio, d.total 
    from @detalle d
    inner join Pruebas.Impuesto i on d.ImpuestoID = i.ImpuestoID;
end
go

