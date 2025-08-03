-- PROCEDIMIENTOS ALMACENADOS PARA PANTALLA COMPRA Y COMPRA DETALLE

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

create or alter procedure spTraeComprasCode  
	@compID int = null 
as
	declare @estadoCompra varchar(20)

	select @estadoCompra = estado from pruebas.compra where compraid = @compID
			
	if @estadoCompra = 'Abierto' or @compID = 0
			select compraid, codigocompra from pruebas.compra where estado = 'Abierto'
	else
			select compraid, codigocompra from pruebas.compra where estado <> 'Abierto'
go

CREATE OR ALTER PROCEDURE spCancelarCompra @compraID int, @socID int, @error varchar(50) OUTPUT
AS
BEGIN
    DECLARE @tipoPago varchar(50);
    SET @error = '';

    IF @compraID <> 0
    BEGIN
        -- trae el tipo de pago 
        SELECT @tipoPago = TipoPago FROM Pruebas.Compra WHERE CompraID = @compraID

        -- revertir el stock (Resta la cantidad que se había sumado con la compra)
        UPDATE Pruebas.BodegaDetalle 
        SET TotalExistencias = TotalExistencias - cd.Cantidad
        FROM Pruebas.BodegaDetalle bd
        INNER JOIN Pruebas.CompraDetalle cd 
            ON bd.BodegaID = cd.BodegaID AND bd.ProductoID = cd.ProductoID
        WHERE cd.CompraID = @compraID

        IF @@ERROR <> 0 begin SET @error = 'Ocurrió un error al actualizar el stock en bodega' return end
         
        -- actualiza el estado de la compra a 'Cancelado'
        UPDATE Pruebas.Compra SET Estado = 'Cancelado' WHERE CompraID = @compraID;

        IF @@ERROR <> 0 begin SET @error = 'Ocurrió un error al actualizar el estado de la compra' return end
           
    END
    ELSE
    BEGIN
        SET @error = 'No puede usar estado Cancelado en nueva compra'
    END

    RETURN
END
GO


-- actualizar y agregar compra

create or alter procedure spAddUpdateCompra @compraid int, @fecha date, @socid int, @listPrecid int, @tipoPago varchar(50), @estado varchar(50), @detalle TipoCompraDetalle readonly
as
	begin 
		
		begin transaction

    declare @err varchar(50) = '', @resCancelacion varchar(50)

	--valida si la compra lleva estado Cancelado
	IF @estado = 'Cancelado'
    BEGIN
        EXEC spCancelarCompra @compraid, @socid, @error = @resCancelacion OUTPUT
        IF ISNULL(@resCancelacion, '') <> '' THROW 50001, @resCancelacion, 1 -- devuelve error personalizado

        COMMIT
        SELECT @compraid
        RETURN
    END

	 --> Valida stock (si aplica)
    -- SELECT @err = dbo.fValidaStockCompra(@detalle);
    -- IF ISNULL(@err, '') <> '' THROW 50002, @err, 1; -- Devuelve error personalizado

    -- crea o edita compra
    if @compraid = 0
    begin
        insert into pruebas.compra (fecha, socioid, listapreciosid, tipopago, estado)
        values (@fecha, @socid, @listprecid, @tipopago, @estado)

        if @@error <> 0 and @err = '' set @err = 'error al insertar compra'
    end
    else
    begin
        update pruebas.compra
        set fecha = @fecha,
            socioid = @socid,
            listapreciosid = @listprecid,
            tipopago = @tipopago,
            estado = @estado
        where compraid = @compraid

        if @@error <> 0 and @err = '' set @err = 'error al actualizar compra'
    end

    -- valida si hubo errores en la cabecera
    if @err = ''
    begin
        if @compraid = 0
            select top 1 @compraid = compraid from pruebas.compra order by compraid desc

        -- ejecuta y valida si hubieron errores en el detalle
        exec spAgregarCompraDetalle @compraid, @detalle

        if @@error = 0
        begin
            commit;
            select @compraid
        end
        else
        begin
            rollback;
        end
    end
    else
    begin
        rollback;
    end
    
	end
go

-- actualizar y agregar compra detalle

create type TipoCompraDetalle as table 
(
	CompraID	int,
	Codigo 		varchar(15),
	ProductoID	int,
	ImpuestoID	int,
	BodegaID	int,
	Cantidad	int,
	Precio		decimal(10, 2),
	SubTotal	decimal(10, 2),
	Total		decimal(10, 2)
)
go


create or alter procedure spAgregarCompraDetalle @compraid int, @detalle TipoCompraDetalle readonly
as
	begin
		declare @tipopago varchar(50), @socid int, @totalnuevo float, @totalanterior float, @saldo float		

		select @tipopago = TipoPago, @socid = SocioID from pruebas.compra where compraid = @compraid

		-- actualiza saldo de socio con compras al crédito
		if @tipopago = 'Credito'
		begin
			select @totalnuevo = isnull(sum(total), 0) from @detalle 
			select @totalanterior = isnull(sum(total), 0) from pruebas.compradetalle where compraid = @compraid 

			-- valida que no quede negativo
			select @saldo = ( case when saldo - @totalanterior < 0 then 0 else saldo - @totalanterior end ) 
			from pruebas.socio where socioid = @socid 

			update pruebas.socio set saldo = @saldo + @totalnuevo
			where socioid = @socid
		end

		-- actualiza Stock
		declare @prod int, @bodid int, @cantnueva float, @cantanterior float, @existencias float

		declare crsCompraDet cursor for
		select productoid, bodegaid, cantidad from @detalle 
			   
		open crsCompraDet
		fetch next from crsCompraDet into @prod, @bodid, @cantnueva  

		while @@fetch_status = 0 
		begin
			select @cantanterior = cantidad from pruebas.compradetalle where compraid = @compraid and productoid = @prod

			-- valida que no quede negativo ni nulo 
			select @existencias = 
			(
				case  
					when TotalExistencias - isnull(@cantanterior, 0) < 0 then 0 
					else TotalExistencias - isnull(@cantanterior, 0)
				end
			) 
			from pruebas.bodegadetalle where bodegaid = @bodid and productoid = @prod

			update pruebas.bodegadetalle set TotalExistencias = @existencias + @cantnueva
			where bodegaid = @bodid and productoid = @prod

			fetch next from crsCompraDet into @prod, @bodid, @cantnueva 
		end
		
		deallocate crsCompraDet

		if exists 
		(
			select 1 from @detalle d
			where not exists (select 1 from Pruebas.Impuesto i where i.ImpuestoID = d.ImpuestoID)
		)

			        THROW 50010, 'Existen filas con ImpuestoID inválido en el detalle de compra.', 1

		-- hace la actualización 
		delete from Pruebas.compradetalle where compraid = @compraid

		insert into pruebas.compradetalle (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total)
		select @compraid, d.ProductoID, d.impuestoid, d.bodegaid, d.cantidad, d.precio, d.total 
		from @detalle d
		inner join Pruebas.Impuesto i on d.ImpuestoID = i.ImpuestoID

	end
go




