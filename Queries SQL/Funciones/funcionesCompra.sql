-- FUNCIONES PANTALLAS COMPRA Y COMPRA DETALLE

-- calcula subtotal y total de recibo

drop function dbo.fCalcularTotalesCompra
go

create or alter function dbo.fCalcularTotalesCompra (@tablaTotales TipoCompraDetalle readonly)
returns @resultado table (Subtotal decimal(10, 2), Total decimal(10, 2))
as
	begin
		insert into @resultado
		select sum(td.Cantidad * td.Precio), 
           sum((td.Cantidad * td.Precio) * (1 + i.Valor))
		from @tablaTotales td
		inner join Pruebas.Impuesto i on td.ImpuestoID = i.ImpuestoID
		return 
	end
go


----Para probar el sp anterior
--begin transaction
---- Declarar la variable tipo tabla
--DECLARE @DatosPrueba AS TipoCompraDetalle;
	
---- Insertar datos de prueba
--INSERT INTO @DatosPrueba (CompraID	,Codigo,ProductoID	,BodegaID	,Cantidad	,Precio	,SubTotal,ImpuestoID	,Total	)
--VALUES

--(1,'PRO2',2,2,10,65.00,650.00,1,747.50)

--select * from dbo.fCalcularTotalesCompra1 (@DatosPrueba)




--rollback

--select * from pruebas.CompraDetalle td where compraid = 1

--exec spTraeCompraDetalle 1

--select sum(td.Cantidad * td.Precio), 
--sum((td.Cantidad * td.Precio) * (1 + i.Valor))
--from pruebas.CompraDetalle td
--inner join Pruebas.Impuesto i on td.ImpuestoID = i.ImpuestoID
--where compraid = 1


----lo que deberia ser
--Cantidad	Precio	Valor
--10			65		1.15


----lo que manda
----id cod prod	bod	cant    pre    sub	  imp		tot  
----1,PRO2,	2,	2,	10,		65.00, 650.00, 1,	747.50


----returns
--cant precio		valor
--65,		650,	1.25


--update pruebas.Venta set TipoPago = 'Credito', socioid = 8
--where VentaID = 67

--update pruebas.socio set saldo = 57.5
--where socioid = 8


--select * from pruebas.Socio where socioid = 8

--select * from pruebas.compra




