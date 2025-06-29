use AgroLinkDB
go 


--creacion de tablas de transacciones


--VENTAS

CREATE TABLE Ventas(
VentasID int primary key not null,
Fecha Datetime not null,
SociosID int not null,
ListaPrecioID int not null,
TipoPago varchar(50) not null,
Estado varchar(50) not null,

constraint chkTipoPago check( TipoPago in('Contado','Credito') ),
constraint chkEstadoVenta check( Estado in('Abierto','Cerrado','Cancelado') )

)
go

--VentasDetalle 

Create Table VentasDetalle(
VentasID int primary key  not null,
ProductoID int not null,
ImpuestoID int not null,
AlmacenID int not null,
Cantidad int not null,
Precio float not null,
Total float not null,


)
go

--Compras
--Compra es el registro de la compra al credito, recibo seria cuando ya se pague
Create Table Compras(
CompraID int primary key not null,
ListaPrecioID int not null,
Fecha Datetime not null,
SociosID int not null,
TipoPago varchar(50) not null,
Estado varchar(50) not null,

constraint chkTipoPagoCompras check( TipoPago in('Contado','Credito') ),
constraint chkEstadoVentaCompras check( Estado in('Abierto','Cerrado','Cancelado') )

)
go 

--CompraDetalle

Create table CompraDetalle(
CompraID int primary key not null,
ProductoID int not null,
ImpuestoID int not null,
AlmacenID int not null,
Cantidad int not null,
Precio float not null,
Total Float Not null,
)
go

--EntradProducto

Create Table EntradaProducto(
EntradaID int primary key not null,
SociosID int not null,
AlmacenID int not null,
Fecha Datetime not null,
LoteID int,--ayuda borjasGOD, PADRE DE GerarGOD; queda sujeto a cambios
Credito float not null,

)
go

--Entrada Producto Detalle

Create Table EntradaProductoDetalle(
EntradaID int primary key not null,
ProductoID int not null,
Cantidad int not null,
)
go

--Factura

Create Table Factura(
FacturaID int primary key not null,
SociosID int not null,
ListaPrecioID int not null,
EmpresaID int not null,
Fecha Datetime not null,
MetodoPago varchar(50) not null,
CAI varchar(50) not null,
constraint chkMetodoPago check( MetodoPago in('Efectivo','Tarjeta','Cheque') )

)

--FacturaDetalle

Create Table FacturaDetalle(
FacturaID int primary key not null,
ProductoID int not null,
ImpuestoID int not null,
AlmacenID int not null,
Cantidad int not null,
Precio float not null,
Total float not null

)

Create Table Recibo(
ReciboID int primary key not null,
ListaPrecioID int not null,
SociosID int not null,
MetodoPago varchar(50) not null,
Fecha Datetime not null,
constraint chkMetodoPagoRecibo check( MetodoPago in('Efectivo','Tarjeta','Cheque') )

)

Create Table ReciboDetalle(
ReciboID int  primary key not null,
ProductoID int not null,
ImpuestoID int not null,
AlmacenID int not null,
Cantidad int not null,
Precio Float not null,
Total Float not null,

)

--pemdiemye las llaves 
create Table SalidaProducto(

SalidaID int primary key not null,
SociosID int not null,
AlmacenID int not null,

)

create table SalidaProductoDetalle(
	SalidaID int primary key not null,
	ProductoID int not null,
	Cantidad int not null
)