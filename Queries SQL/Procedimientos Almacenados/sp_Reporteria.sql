use AgroLinkDB

go



-->> Reportes Inventario

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda Reporte ProdxProductor   >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarProdxProductor @filtro varchar(10)
as
	BEGIN 
		SELECT * FROM vProdRecibidaxProductor 
		WHERE [Código Agricultor] LIKE '%' + @filtro + '%' or Agricultor like '%' + @filtro + '%' 
		or  [Código Producto] like '%' + @filtro + '%' or Producto like '%' + @filtro + '%' 
	END

go

exec spBuscarProdxProductor 'pro11'

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Llena Labels Reporte Inventario   >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE TYPE TipoDetalleReporteInventario 
as TABLE(
	CodigoA varchar(20),
	Agricultor varchar(50),
	CodigoP varchar(20),
	Producto varchar(50),
	--Finca varchar(50),
	--Lote varchar(20),
	Periodo int,
	Cantidad float
)

go


CREATE OR ALTER PROCEDURE spTotalesReporteInventario
as
	BEGIN 
		declare @resultado as Table ( TotalProdAquirido float , TotalComprasAnio float, InsumosVendidos float , TotalVentaInsumos float)

		declare @totCompras float, @totProd float, @insumVend float, @totVentInsum float

		SELECT @totCompras = SUM(cd.Total), @totProd = SUM(cd.Cantidad) 
		from pruebas.Compra C
		inner join pruebas.CompraDetalle CD on C.CompraID = CD.CompraID
		inner join pruebas.Socio s on C.SocioID = s.SocioID
		inner join pruebas.Producto p on CD.ProductoID = p.ProductoID
		inner join pruebas.TipoProducto TP on p.TipoID = tp.TipoID
		where TipoSocio = 'Agricultor'and TP.Categoria <> 'Insumo'


		SELECT @insumVend= SUM(ED.Cantidad),  @totVentInsum = SUM(VD.Total)
		from pruebas.Entrega E
		inner join pruebas.EntregaDetalle ED on E.EntregaID = ED.EntregaID
		inner join pruebas.SalidaProducto SP on SP.SalidaID = E.SalidaID
		inner join pruebas.VentaDetalle VD on	SP.VentaID = VD.VentaID
		inner join pruebas.Socio s on E.SocioID = s.SocioID
		inner join pruebas.Producto p on ED.ProductoID = p.ProductoID
		inner join pruebas.TipoProducto TP on p.TipoID = tp.TipoID
		where TipoSocio = 'Agricultor'and TP.Categoria = 'Insumo'


		insert into @resultado VALUES ( @totProd, @totCompras, @insumVend, @totVentInsum)
		
		select * from @resultado
	
	END

go

exec spTotalesReporteInventario
		
		
		
		go

-->> Reportes Saldo

CREATE OR ALTER PROCEDURE spReporteSaldos @filtro varchar(20) = null
as
	begin

		IF @filtro IS NULL
			SELECT  S.CodigoSocio , S.Nombre, S.Saldo,  MAX(C.Fecha) as [Ultima Fecha Crédito]
			FROM pruebas.Socio S
			left join pruebas.Compra C on S.SocioID = C.SocioID
			WHERE C.TipoPago = 'Credito'
			group by  S.CodigoSocio , S.Nombre , S.Saldo
			Union
			SELECT  S.CodigoSocio , S.Nombre, S.Saldo,  MAX(V.Fecha) as [Ultima Fecha Crédito]
			FROM pruebas.Socio S
			LEFT join pruebas.Venta V on S.SocioID = V.SocioID
			WHERE V.TipoPago = 'Credito'
			group by  S.CodigoSocio , S.Nombre , S.Saldo

		ELSE
			SELECT  S.CodigoSocio , S.Nombre, S.Saldo,  MAX(C.Fecha) as [Ultima Fecha Crédito]
			FROM pruebas.Socio S
			left join pruebas.Compra C on S.SocioID = C.SocioID
			WHERE S.TipoSocio = @filtro  and C.TipoPago = 'Credito'
			group by  S.CodigoSocio , S.Nombre , S.Saldo

		

	end
go

exec spReporteSaldos 'Proveedor'
go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda Reporte Saldo  >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarSaldo  @busqueda varchar(50), @filtro varchar(10)= null
as
	BEGIN 
		declare @detalle as table (CodigoSocio varchar(10), Nombre varchar(50), Saldo float, Fecha date )

		insert into @detalle
		exec spReporteSaldos @filtro

		
		SELECT * FROM @detalle 
		WHERE Nombre LIKE '%' + @busqueda + '%' or CodigoSocio like '%' + @busqueda + '%'


	END

go

exec spBuscarSaldo 'car'

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Llena Labels Reporte Saldo   >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spTotalesReporteSaldo
as
	BEGIN 
		
		declare @resProv as Table  (CodigoSocio varchar(10), Nombre varchar(50), Saldo float, Fecha date )
		declare @resAgr as Table  (CodigoSocio varchar(10), Nombre varchar(50), Saldo float, Fecha date )

		declare @totSaldoProv float, @totSaldoAgr float

		insert into @resProv exec spReporteSaldos 'Proveedor'

		insert into @resAgr exec spReporteSaldos 'Agricultor'

		SELECT @totSaldoProv = SUM (Saldo) FROM @resProv 

		SELECT @totSaldoAgr = SUM (Saldo) FROM @resAgr

		--devuelve resultado final
		SELECT @totSaldoProv, @totSaldoAgr , @totSaldoProv + @totSaldoAgr 


	END

	
go


exec spTotalesReporteSaldo




--> Reporteria Utilidad
go

CREATE OR ALTER PROCEDURE spTop3ProductoVendido
as
	begin
		--> producto mas vendido 
		select top 3 P.CodigoProducto, P.Nombre , SUM(Cantidad) AS 'Cantidad' , SUM(FD.Total) as 'Total'
		from pruebas.VentaDetalle fd
		inner join pruebas.Producto p on fd.ProductoID = p.ProductoID
		group by  P.Nombre, P.CodigoProducto order by Total desc
	end	
go

exec spTop3ProductoVendido

go

CREATE OR ALTER PROCEDURE spTop3ProductoComprado
as
	begin
		--> producto mas comprado 
		select top 3 P.CodigoProducto, P.Nombre , SUM(Cantidad) AS 'Cantidad' , SUM(RD.Total) as 'Total'
		from pruebas.CompraDetalle Rd
		inner join pruebas.Producto p on Rd.ProductoID = p.ProductoID
		group by  P.Nombre, P.CodigoProducto order by Total desc
	end	
go

exec spTop3ProductoComprado

go

CREATE OR ALTER PROCEDURE spTotalesUtilidad
as
	begin
		
		declare @ventasProd as table (ProductoID int, VentaProd float)
		declare @comprasProd as table (ProductoID int, CompraProd float)

		declare @totVentasProd float, @totComprasProd float

		-->total ganado en ventas
		insert into @ventasProd
		SELECT FD.ProductoID, SUM(Total) as VentaProd
		FROM Pruebas.Factura F
		INNER JOIN Pruebas.FacturaDetalle  FD ON F.FacturaID = FD.FacturaID
		WHERE Estado = 'Cerrado' and YEAR(F.Fecha) = YEAR(GETDATE()) --solo del año actual
		GROUP BY FD.ProductoID 

		select  @totVentasProd = SUM(VentaProd) from @ventasProd

		--> total gastado en compras
		insert into @comprasProd
		SELECT RD.ProductoID, SUM(Total) as CompraProd
		FROM Pruebas.Recibo R
		INNER JOIN Pruebas.ReciboDetalle RD ON R.ReciboID = RD.ReciboID
		WHERE Estado = 'Cerrado'and YEAR(R.Fecha) = YEAR(GETDATE())
		GROUP BY RD.ProductoID 

		select  @totComprasProd = SUM(CompraProd) from @comprasProd


		select @totVentasProd as 'Ingresos', @totComprasProd as 'Gastos', @totVentasProd - @totComprasProd as 'Utilidad'
		
	end

go

exec spTotalesUtilidad









