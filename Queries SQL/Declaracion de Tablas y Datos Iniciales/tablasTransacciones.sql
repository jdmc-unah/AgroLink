use AgroLinkDB
go 

--editando/creando tablas de transacciones

/*
bases padre
drop table Pruebas.Venta
drop table Pruebas.Compra
drop table Pruebas.EntradaProducto
drop table Pruebas.Factura
drop table Pruebas.Recibo
drop table Pruebas.SalidaProducto

bases hija
drop table Pruebas.CompraDetalle
drop table Pruebas.VentaDetalle
drop table Pruebas.EntradaProductoDetalle
drop table Pruebas.FacturaDetalle
drop table Pruebas.ReciboDetalle
drop table Pruebas.SalidaProductoDetalle
*/


--VENTAS

CREATE TABLE Pruebas.Venta --ya creada
(
	VentaID int identity(1,1) primary key not null,
	CodigoVenta	as concat('VEN', VentaID) persisted,		--CAMBIO
	Fecha Datetime not null,
	SocioID int not null,
	ListaPreciosID int not null,
	TipoPago varchar(50) not null,
	Estado varchar(50) not null,
	
	constraint chkTipoPago check( TipoPago in('Contado','Credito') ),
	constraint chkEstadoVenta check( Estado in('Abierto','Cerrado','Cancelado') ),
	
	constraint fkVentaSocios FOREIGN KEY (SocioID) REFERENCES Pruebas.Socio(SocioID),
	constraint fkVentaListaPrecios FOREIGN key (ListaPreciosID) REFERENCES Pruebas.ListaPrecios(ListaPreciosID),
)
go



--VENTA DETALLE

Create Table Pruebas.VentaDetalle --ya creada
(
	VentaID int not null,
	ProductoID int not null,
	ImpuestoID int not null,
	BodegaID int not null,
	Cantidad int not null,
	Precio decimal(10,2) not null default 0 check (Precio >= 0),
	Total decimal(10,2) not null default 0 check (Total >= 0),
	
	constraint pkVentaDetalle primary key (VentaID, ProductoID), 
	constraint fkVentaDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkVentaDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID),
	constraint fkVentaDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
)
go

--Compras
--Compra es el registro de la compra al credito, recibo seria cuando ya se pague
Create Table Pruebas.Compra --ya creada
(
	CompraID int identity(1, 1)primary key not null,
	CodigoCompra	as concat('COM', CompraID) persisted,		--CAMBIO
	ListaPreciosID int not null,
	Fecha Datetime not null,
	SocioID int not null,
	TipoPago varchar(50) not null,
	Estado varchar(50) not null,

	constraint chkTipoPagoCompra check( TipoPago in('Contado','Credito') ),
	constraint chkEstadoVentaCompra check( Estado in('Abierto','Cerrado','Cancelado') ),

	constraint fkCompraListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
	constraint fkCompraSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
)
go 

--CompraDetalle

Create table Pruebas.CompraDetalle --ya creada
(
	CompraID int not null,
	ProductoID int not null,
	ImpuestoID int not null,
	BodegaID int not null,
	Cantidad int not null,
	Precio decimal(10,2) not null default 0 check (Precio >= 0),
	Total decimal(10,2) not null default 0 check (Total >= 0),

	constraint pkCompraDetalle primary key (CompraID, ProductoID),
	constraint fkCompraDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkCompraDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID),
	constraint fkCompraDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID),
)
go

--EntradProducto
Create Table Pruebas.EntradaProducto --ya creada
(
	EntradaID int identity(1,1)  primary key not null,
	CodigoEntrada as concat('ENT', EntradaID) persisted,
	SocioID int,						--CAMBIO
	Fecha Datetime not null,
	LoteID int,
	CompraID int,						--CAMBIO

	constraint fkEntradaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID), 
	constraint fkEntradaProductoLote foreign key (LoteID) references Pruebas.Lote(LoteID),
	constraint fkEntradaProductoCompra foreign key (CompraID) references Pruebas.Compra(CompraID)	--CAMBIO
)
go

--Entrada Producto Detalle

Create Table Pruebas.EntradaProductoDetalle --ya creada
(
	EntradaID int not null,
	ProductoID int not null,
	Cantidad int not null,
	BodegaID int not null,				--CAMBIO

	constraint pkEntradaProductoDetalle primary key (EntradaID, ProductoID),
	constraint fkEntradaProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkEntradaProductoBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)		--CAMBIO
)
go

--Factura

Create Table Pruebas.Factura --ya creada
(
	FacturaID int identity(1,1) primary key not null,
	CodigoFactura	as concat('FAC', FacturaID) persisted,		--CAMBIO
	VentaID int not null,
	SocioID int not null,
	ListaPreciosID int not null,
	EmpresaID int not null,
	Fecha Datetime not null,
	MetodoPago varchar(50) not null,
	CAI varchar(50) not null,
	EmpleadoID int not null,		--CAMBIO
	Estado varchar(50) not null,	--CAMBIO
	NumFiscalID int not null,		--CAMBIO

	constraint fkFacturaNumFiscal foreign key (NumFiscalID) references Pruebas.NumFiscal(NumFiscalID), --se agrego fk de numfiscal
	constraint chkMetodoPago check( MetodoPago in('Efectivo','Tarjeta','Cheque') ),
	constraint chkEstadoFactura check( Estado in('Abierto','Cerrado','Cancelado') ),		--CAMBIO

	constraint fkFacturaVenta foreign key (VentaID) references Pruebas.Venta(VentaID),	--CAMBIO
 	constraint fkFacturaSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkFacturaListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
	constraint fkFacturaEmpresa foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID),
	constraint fkFacturaEmpleado foreign key (EmpleadoID) references Pruebas.Empleado(EmpleadoID)		--CAMBIO
)
go


--FacturaDetalle

Create Table Pruebas.FacturaDetalle --ya creada
(
	FacturaID int not null,
	ProductoID int not null,
	ImpuestoID int not null,
	BodegaID int not null,
	Cantidad int not null,
	Precio decimal(10, 2) not null,
	Total decimal(10, 2) not null

	constraint pkFacturaDetalle primary key (FacturaID, ProductoID),

	constraint fkFacturaDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkFacturaDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID),
	constraint fkFacturaDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
)


Create Table Pruebas.Recibo --ya creada
(
	ReciboID int identity(1,1) primary key not null,
	CodigoRecibo as concat('REC', ReciboID) persisted,	--CAMBIO
	CompraID int not null,								--CAMBIO
	ListaPreciosID int not null,
	SocioID int not null,
	MetodoPago varchar(50) not null,
	Fecha Datetime not null,
	EmpleadoID int not null,		--CAMBIO
	Estado varchar(50) not null,	--CAMBIO
	
	constraint chkMetodoPagoRecibo check( MetodoPago in('Efectivo','Tarjeta','Cheque') ),
	constraint chkEstadoRecibo check( Estado in('Abierto','Cerrado','Cancelado') ),		--CAMBIO

	constraint fkReciboListaPreciosID foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
	constraint fkReciboSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkReciboEmpleado foreign key (EmpleadoID) references Pruebas.Empleado(EmpleadoID)		--CAMBIO
)


Create Table Pruebas.ReciboDetalle --ya creada
(
	ReciboID int not null,
	ProductoID int not null,
	ImpuestoID int not null,
	BodegaID int not null,
	Cantidad int not null,
	Precio	decimal(10,2) not null default 0 check (Precio >= 0),
	Total decimal(10,2) not null default 0 check (Total >= 0),

	constraint pkReciboDetalle primary key (ReciboID, ProductoID),

	constraint fkReciboDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkReciboDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID),
	constraint fkReciboDetalleBodega2 foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
)


create Table Pruebas.SalidaProducto --ya creada
(
	SalidaID int identity(1,1) primary key not null,
	CodigoSalida as concat('SAL', SalidaID) persisted,
	Fecha datetime not null,			--CAMBIO
	SocioID int not null,
	VentaID int not null,						--CAMBIO

	constraint fkSalidaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkSalidaProductoVenta foreign key (VentaID) references Pruebas.Venta(VentaID)	--CAMBIO
)

create table Pruebas.SalidaProductoDetalle --ya creada
(
	SalidaID int not null,
	ProductoID int not null,
	Cantidad int not null,
	BodegaID int not null,				--CAMBIO

	constraint pkSalidaProductoDetalle primary key (SalidaID, ProductoID),
	constraint fkSalidaProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkSalidaProductoDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)	--CAMBIO
)


--tablas de archivo objetos II

Create Table Pruebas.Entrega      --YA CREADA
(
	EntregaID		int identity(1,1) primary key not null,
	Fecha			Datetime not null,
	SocioID			int not null,
	VentaID			int not null,
	DireccionID		int not null, 
	RepartidorID	int not null,

	constraint fkEntregaSocios foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkEntregaVenta foreign key (VentaID) references Pruebas.Venta(VentaID),  
	constraint fkEntregaDireccion foreign key (DireccionID) references Pruebas.Direccion(DireccionID),
	constraint fkEntregaRepartidor foreign key (RepartidorID) references Pruebas.Empleado(EmpleadoID)
)


create table Pruebas.EntregaDetalle    --YA CREADA
(
	EntregaID	int not null,
	ProductoID	int not null,
	Cantidad	int not null,

	constraint pkEntregaDetalle primary key (EntregaID, ProductoID),

	constraint fkEntregaDetalleEntrega foreign key (EntregaID) references Pruebas.Entrega(EntregaID),  
	constraint fkEntregaDetalleProducto foreign key(ProductoID) references Pruebas.Producto(ProductoID),
	constraint chkCantidadEntrega check (Cantidad>=0)
)
