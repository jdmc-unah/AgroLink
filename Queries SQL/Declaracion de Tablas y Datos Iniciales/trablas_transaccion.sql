use AgroLinkDB

go 

select * from AgroLinkDB.Pruebas.Socio

--creacion de tablas de transacciones

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
	VentaID int primary key not null,
	Fecha Datetime not null,
	SocioID int not null,
	ListaPreciosID int not null,
	TipoPago varchar(50) not null,
	Estado varchar(50) not null,

	constraint chkTipoPago check( TipoPago in('Contado','Credito') ),
	constraint chkEstadoVenta check( Estado in('Abierto','Cerrado','Cancelado') ),
	
	constraint fkVentaSocios FOREIGN KEY (SocioID) REFERENCES Pruebas.Socio(SocioID),
	constraint fkVentaListaPrecios FOREIGN key (ListaPreciosID) REFERENCES Pruebas.ListaPrecios(ListaPreciosID)
)
go

--VentasDetalle 

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
	CompraID int primary key not null,
	ListaPreciosID int not null,
	Fecha Datetime not null,
	SocioID int not null,
	TipoPago varchar(50) not null,
	Estado varchar(50) not null,

	constraint chkTipoPagoCompra check( TipoPago in('Contado','Credito') ),
	constraint chkEstadoVentaCompra check( Estado in('Abierto','Cerrado','Cancelado') ),

	constraint fkCompraListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
	constraint fkCompraSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
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
	EntradaID int primary key not null,
	SocioID int not null,
	BodegaID int not null,
	Fecha Datetime not null,
	LoteID int,
	Credito decimal(10,2) not null,

	constraint fkEntradaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkEntradaProductoBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID),
	constraint fkEntradaProductoLote foreign key (LoteID) references Pruebas.Lote(LoteID),

)
go

--Entrada Producto Detalle

Create Table Pruebas.EntradaProductoDetalle --ya creada
(
	EntradaID int not null,
	ProductoID int not null,
	Cantidad int not null,

	constraint pkEntradaProductoDetalle primary key (EntradaID, ProductoID),
	constraint fkEntradaProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
)
go

--Factura
--por aqui me quede en creacion
Create Table Pruebas.Factura --ya creada
(
	FacturaID int primary key not null,
	SocioID int not null,
	ListaPreciosID int not null,
	EmpresaID int not null,
	Fecha Datetime not null,
	MetodoPago varchar(50) not null,
	CAI varchar(50) not null,
	constraint chkMetodoPago check( MetodoPago in('Efectivo','Tarjeta','Cheque') ),

	constraint fkFacturaSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkFacturaListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
	constraint fkFacturaEmpresa foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID),
)

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
	ReciboID int primary key not null,
	ListaPreciosID int not null,
	SocioID int not null,
	MetodoPago varchar(50) not null,
	Fecha Datetime not null,
	
	constraint chkMetodoPagoRecibo check( MetodoPago in('Efectivo','Tarjeta','Cheque') ),

	constraint fkReciboListaPreciosID foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
	constraint fkReciboSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
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


create Table Pruebas.SalidaProducto  --ya creada
(
	SalidaID int primary key not null,
	SocioID int not null,
	BodegaID int not null,
	constraint fkSalidaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkSalidaProductoBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID),
)

create table Pruebas.SalidaProductoDetalle --ya creada
(
	SalidaID int not null,
	ProductoID int not null,
	Cantidad int not null,

	constraint pkSalidaProductoDetalle primary key (SalidaID, ProductoID),
	constraint fkSalidaProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
)
