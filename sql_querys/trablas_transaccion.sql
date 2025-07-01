use AgroLinkDB

go 

select * from AgroLinkDB.Pruebas.Socio

--creacion de tablas de transacciones


--VENTAS

CREATE TABLE Pruebas.Ventas(
VentasID int primary key not null,
Fecha Datetime not null,
SocioID int not null,
ListaPreciosID int not null,
TipoPago varchar(50) not null,
Estado varchar(50) not null,

constraint chkTipoPago check( TipoPago in('Contado','Credito') ),
constraint chkEstadoVenta check( Estado in('Abierto','Cerrado','Cancelado') ),
Constraint fkVentasSocios FOREIGN KEY (SocioID) REFERENCES Pruebas.Socio(SocioID),
constraint fkVebtasListaPrecios FOREIGN key (ListaPreciosID) REFERENCES Pruebas.ListaPrecios(ListaPreciosID)
)
go

--VentasDetalle 

Create Table Pruebas.VentasDetalle(
VentasID int primary key  not null,
ProductoID int not null,
ImpuestoID int not null,
BodegaID int not null,
Cantidad int not null,
Precio decimal(10,2) not null default 0 check (Precio >= 0),
Total decimal(10,2) not null default 0 check (Total >= 0),
constraint fkVentasDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
constraint fkVentasDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID),
constraint fkVentasDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)


)
go

--Compras
--Compra es el registro de la compra al credito, recibo seria cuando ya se pague
Create Table Pruebas.Compras(
CompraID int primary key not null,
ListaPreciosID int not null,
Fecha Datetime not null,
SocioID int not null,
TipoPago varchar(50) not null,
Estado varchar(50) not null,


constraint fkComprasListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
constraint fkComprasSocio foreign key (SocioID) references Pruebas.Socio(SocioID),


constraint chkTipoPagoCompras check( TipoPago in('Contado','Credito') ),
constraint chkEstadoVentaCompras check( Estado in('Abierto','Cerrado','Cancelado') )

)
go 

--CompraDetalle

Create table Pruebas.CompraDetalle(
CompraID int primary key not null,
ProductoID int not null,
ImpuestoID int not null,
BodegaID int not null,
Cantidad int not null,
Precio decimal(10,2) not null default 0 check (Precio >= 0),
Total decimal(10,2) not null default 0 check (Total >= 0),

constraint fkComprasDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
constraint fkComprasDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID),
constraint fkComprasDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID),



)
go

--EntradProducto

Create Table Pruebas.EntradaProducto(
EntradaID int primary key not null,
SocioID int not null,
BodegaID int not null,
Fecha Datetime not null,
LoteID int,
Credito float not null,

constraint fkEntradaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
constraint fkEntradaProductoBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID),
constraint fkEntradaProductoLote foreign key (LoteID) references Pruebas.Lote(LoteID),

)
go

--Entrada Producto Detalle

Create Table Pruebas.EntradaProductoDetalle(
EntradaID int primary key not null,
ProductoID int not null,
Cantidad int not null,

constraint fkEntradaProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),

)
go

--Factura
--por aqui me quede en creacion
Create Table Pruebas.Factura(
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

Create Table Pruebas.FacturaDetalle(
FacturaID int primary key not null,
ProductoID int not null,
ImpuestoID int not null,
BodegaID int not null,
Cantidad int not null,
Precio float not null,
Total float not null

constraint fkFacturaDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
constraint fkFacturaDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID),
constraint fkFacturaDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID),




)

Create Table Pruebas.Recibo(
ReciboID int primary key not null,
ListaPreciosID int not null,
SocioID int not null,
MetodoPago varchar(50) not null,
Fecha Datetime not null,
constraint chkMetodoPagoRecibo check( MetodoPago in('Efectivo','Tarjeta','Cheque') ),

constraint fkReciboListaPreciosID foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
constraint fkReciboSocio foreign key (SocioID) references Pruebas.Socio(SocioID)


)

Create Table Pruebas.ReciboDetalle(
ReciboID int  primary key not null,
ProductoID int not null,
ImpuestoID int not null,
BodegaID int not null,
Cantidad int not null,
Precio	decimal(10,2) not null default 0 check (Precio >= 0),
Total decimal(10,2) not null default 0 check (Total >= 0),

constraint fkReciboDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
constraint fkReciboDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID),
constraint fkReciboDetalleBodega2 foreign key (BodegaID) references Pruebas.Bodega(BodegaID),




)

--pemdiemye las llaves 
create Table Pruebas.SalidaProducto(

SalidaID int primary key not null,
SocioID int not null,
BodegaID int not null,
constraint fkSalidaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
constraint fkSalidaProductoBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID),



)

create table Pruebas.SalidaProductoDetalle(
	SalidaID int primary key not null,
	ProductoID int not null,
	Cantidad int not null,

	constraint fkSalidaProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),


)

drop table Pruebas.FacturaDetalle