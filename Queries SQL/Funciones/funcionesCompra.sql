-- FUNCIONES PANTALLAS COMPRA Y COMPRA DETALLE

-- calcula subtotal y total de recibo

create or alter function dbo.fCalcularTotalesCompra (@tablaTotales TipoCompraDetalle readonly)
returns @resultado table (Subtotal decimal(10, 2), Total decimal(10, 2))
as
	begin
		
		insert into @resultado
		select sum((td.Cantidad * td.Precio)), 
           sum((td.Cantidad * td.Precio) * (1 + i.Valor))
		from @tablaTotales td
		inner join Pruebas.Impuesto i on td.ImpuestoID = i.ImpuestoID;

		return
	end
go

