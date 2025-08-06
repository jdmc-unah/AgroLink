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
            SET @error = 'Ocurrio un error al actualizar el estado del recibo'
    END
    ELSE
        SET @error = 'No puede usar estado Cancelado en nuevo recibo'

    RETURN
END
GO

-- tipo para recibo detalle
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

-- actualiza y agrega recibo
create or alter procedure spAddUpdateRecibo @reciboID int, @compraID int, @socID int, @listPrecID int, @fecha date, @metodoPago varchar(50), @empleadoID int, @estado varchar(50), @detalle TipoReciboDetalle READONLY
as
begin
    begin transaction

    declare @err varchar(50) = '', @resCancelacion varchar(50)

    -- valida si el recibo lleva estado Cancelado

    if @estado = 'Cancelado'
    begin
        exec spCancelarRecibo @reciboID, @error = @resCancelacion output
        if isnull(@resCancelacion, '') <> '' THROW 50001, @resCancelacion, 1 -- devuelve error personalizado

        commit
        select @reciboID
        return
    end

    -- crea o Actualiza Recibo

    if @reciboID = 0
		begin
        -- nuevo Recibo
			insert into Pruebas.Recibo (CompraID, SocioID, ListaPreciosID, Fecha, MetodoPago, EmpleadoID, Estado)
			values (@compraID, @socID, @listPrecID, @fecha, @metodoPago, @empleadoID, @estado)

			if @@ERROR <> 0 and @err = '' set @err = 'Error al insertar Recibo'
		end
    else
    begin
        -- editar Recibo
        update Pruebas.Recibo
        set CompraID = @compraID, SocioID = @socID, ListaPreciosID = @listPrecID, Fecha = @fecha, MetodoPago = @metodoPago, EmpleadoID = @empleadoID, Estado = @estado
        where ReciboID = @reciboID

        if @@ERROR <> 0 and @err = '' set @err = 'Error al actualizar Recibo'
    end

    -- valida si hubo error en Recibo

    if @err = ''
    begin
        if @reciboID = 0
            select top 1 @reciboID = ReciboID from Pruebas.Recibo order by ReciboID desc

        -- ejecuta y valida el detalle del recibodetalle

        exec spAddUpdateReciboDet @reciboid, @compraid, @estado, @detalle

        if @@ERROR = 0
        begin
            commit
            select @reciboid
        end
        else
        begin
            rollback
        end
    end
    else
    begin
        rollback
    end
end
go



-- actualiza y agrega recibo detalle

create or alter procedure spAddUpdateReciboDet @reciboID int,  @compraID int, @estadoRecibo varchar(20),  @detalle TipoReciboDetalle readonly
as
begin
    declare @tipoPago varchar(50), @socID int, @nuevoTotalRecibo float, @totalCompra float, @totalRecibosPagados float, @saldo float		

    -- llena variables necesarias
    select @tipoPago = TipoPago, @socID = SocioID 
    from Pruebas.Compra 
    where CompraID = @compraID

	-- total que se paga en este recibo
    select @nuevoTotalRecibo = isnull(sum(Total), 0) from @detalle

	-- total de la compra (monto original)
    select @totalCompra = isnull(sum(Total), 0) 
    from Pruebas.CompraDetalle 
    where CompraID = @compraID

	-- total ya pagado en recios anteiores cerrados
    select @totalRecibosPagados = isnull(sum(rd.Total), 0)  
    from Pruebas.ReciboDetalle rd
    inner join Pruebas.Recibo r on rd.ReciboID = r.ReciboID  
    where r.CompraID = @compraID and r.Estado = 'Cerrado' and r.ReciboID <> @reciboID

    -- actualiza saldo del socio si la compra fue a credito
    if @tipoPago = 'Credito' and @estadoRecibo = 'Cerrado'
    begin
        --select @saldo = case when Saldo - @nuevoTotalRecibo < 0 then 0 else Saldo - @nuevoTotalRecibo end
        --from Pruebas.Socio where SocioID = @socID
        
        --update Pruebas.Socio 
        --set Saldo = @saldo 
        --where SocioID = @socID

		select @saldo = case when saldo < 0 then  saldo + @nuevoTotalRecibo else saldo - @nuevoTotalRecibo end
        from pruebas.socio where socioid = @socid;

        update pruebas.socio set saldo = @saldo 
        where socioid = @socid;


    end

    -- cierra la compra si ya se pago completamente
    if @estadoRecibo = 'Cerrado' and (@totalRecibosPagados + @nuevoTotalRecibo) = @totalCompra
    begin
        update Pruebas.Compra 
        set Estado = 'Cerrado' 
        where CompraID = @compraID
    end

    -- actualiza ReciboDetalle (borra e inserta)
    delete from Pruebas.ReciboDetalle where ReciboID = @reciboID

    insert into Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total)
    select @reciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total from @detalle 
end
go
