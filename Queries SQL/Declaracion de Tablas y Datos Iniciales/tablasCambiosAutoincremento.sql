



use AgroLinkDB


				---------------------------------------------------------------------------------------------------
				-------------------------------------------TABLAS DE OBJETOS----------------------------------------
				---------------------------------------------------------------------------------------------------

-->> NUM FISCAL
--drop table Pruebas.NumFiscal

create table Pruebas.NumFiscal	--ya creada
(
	NumFiscalID		int identity(1,1) primary key not null,
	RangoInicio		varchar(20) not null,
	RangoFin		varchar(20) not null,
	Estado			varchar(20) not null,
	FechaVencimiento	date not null,
	EmpresaID	int not null ,

	constraint fkNumFiscalEmpresa foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID) --se agrego fk de empresa

	-- ideas para automatizar Estado
	-- 1. podriamos usar un trigger que, al insertar o actualizar, revise la fecha de vencimiento y actualice el estado automaticamente
	-- 2. usamos una columna calculada que se actualiza segun la fecha
)


insert into Pruebas.NumFiscal ( RangoInicio, RangoFin, Estado, FechaVencimiento, EmpresaID) values
('001-001-01-000001', '001-001-01-001000', 'activo', '2025-12-31', 1),
('001-002-01-000001', '001-002-01-001000', 'activo', '2025-11-30', 1),
('001-003-01-000001', '001-003-01-001000', 'activo', '2025-10-31', 1),
('001-004-01-000001', '001-004-01-001000', 'inactivo', '2024-12-31', 1),
('001-005-01-000001', '001-005-01-001000', 'activo', '2026-06-30', 1);


GO

-->> DIRECCION
--drop table Pruebas.Direccion

create table Pruebas.Direccion	--ya creada
(
    DireccionID int identity(1,1) primary key,
    MunicipioID int not null,
    Colonia		varchar(50),
    Detalle		varchar(250),

	constraint fkDireccionMunicipio foreign key (MunicipioID) references Pruebas.Municipio(MunicipioID)
)


insert into Pruebas.Direccion ( MunicipioID, Colonia, Detalle) values
(501, 'Colonia Universidad', 'Boulevard Los Próceres #1234'),
(501, 'Barrio Río de Piedras', 'Ave. Circunvalación #5678'),
(501, 'Colonia Moderna', '10a Calle, 15 Ave. SO #91'),
(502, 'Centro', 'Calle Principal, frente al parque central'),  --se volvieron a insertar por el cambio en tabla direccion
(506, 'Barrio El Centro', 'Ave. Honduras #321'),
(511, 'Colonia San José', 'Carretera CA-5 Km 15'),
(512, 'Barrio El Progreso', 'Ave. La Lima #789'),
(504, 'Aldea San Antonio', 'Desvío La Barca Km 3'),
(503, 'Casco Histórico', 'Calle del Comercio #456'),
(510, 'El Paraíso', 'Orilla del Lago de Yojoa');

select * from pruebas.direccion

GO




-->> IMPUESTO									 PENDIENTE*************************************************
--drop table Pruebas.Impuesto

create table Pruebas.Impuesto --ya creada
(
	ImpuestoID	int primary key not null,
	Nombre		varchar(50) not null,
	Valor		decimal(2,2) not null,

	constraint chkValorImpuesto check (Valor >= 0 and Valor <= 1)
)


insert into Pruebas.Impuesto (ImpuestoID, Nombre, Valor) values
('ISV', 15.00),
('Impuesto sobre la Renta', 25.00),
('Impuesto Municipal', 2.00),
('Tasa de Seguridad', 1.50);


select * from Pruebas.Impuesto 

-->>






				---------------------------------------------------------------------------------------------------
				-------------------------------------------TABLAS DE TRANSACCIONES----------------------------------------
				---------------------------------------------------------------------------------------------------


-->>>>>>>>>>>>>>>>>>>>>>>> VENTA >>>>>>>>>>>>>>>>>>>>>>>>  

alter table pruebas.salidaProducto drop constraint fkSalidaProductoVenta
alter table pruebas.Entrega       drop constraint fkEntregaVenta

--drop table pruebas.Venta

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

delete from pruebas.VentaDetalle

go

---datos venta

INSERT INTO PRUEBAS.Venta ( Fecha, SocioID, ListaPreciosID, TipoPago, Estado) VALUES
--VENTA 1
( '2025/07/09', 4, 1, 'Contado', 'Cerrado' ),

--Venta 2
( '2025/07/09', 8, 1, 'Contado', 'Cerrado' ),

--VENTA 3
( '2025/07/09', 4, 1, 'Contado', 'Cerrado' )


INSERT INTO PRUEBAS.VentaDetalle (VentaID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES

--VENTA DETALLE 1
(1, 11, 1, 1, 15, 25, 431.25),	--tomate
(1, 14, 1, 1, 2, 850 , 1955),	--frijol rojo

--VENTA DETALLE 2
(2, 11, 1, 1, 15, 25, 431.25),	--tomate

--VENTA DETALLE 3
(3, 14, 1, 1, 3, 850 , 2932.5)	--frijol rojo


select * from pruebas.Venta v 
inner join pruebas.VentaDetalle vd on v.VentaID = vd.VentaID


go



-->>>>>>>>>>>>>>>>>>>>>>>> Compras >>>>>>>>>>>>>>>>>>>>>>>>
--Compra es el registro de la compra al credito, recibo seria cuando ya se pague

alter table pruebas.entradaproducto drop constraint fkEntradaProductoCompra
drop table pruebas.Compra

sp_help 'pruebas.Compra'

Create Table Pruebas.Compra --ya creada
(
	CompraID int identity(1,1) primary key not null,
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

delete from pruebas.CompraDetalle

INSERT INTO PRUEBAS.Compra ( ListaPreciosID, Fecha, SocioID, TipoPago, Estado)VALUES
--Compra 1
( 6, '2025/07/07', 6, 'Credito', 'Cerrado'), --Compra a Socio 6 
--Compra 2
( 6, '2025/07/07', 2, 'Contado', 'Cerrado'),

--Compra 3
( 6, '2025/07/07', 6, 'Credito', 'Cerrado'),

--Compra 4
( 6, '2025/07/07', 2, 'Contado', 'Cerrado'),

--Compra 5 (Esta no se ve reflejada en inventario bodega porque se uso para hacer los datos de venta, entonces asi como entro el producto se vendio)
(6, '2025/07/07', 1, 'Credito', 'Cerrado')


INSERT INTO PRUEBAS.CompraDetalle (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES 
--Compra Detalle 1
(1, 1, 1, 1, 10, 85,977.5),  --Semilla Tomate 
(1, 2, 1, 2, 10, 65, 747.5 ), --Semilla Lechuga 

--Compra Detalle 2
(2, 3, 1, 3, 45, 750, 38812.5 ),	--Fertilizante
(2, 4, 1, 4, 35, 680, 27370 ),		--Urea

--Compra Detalle 3
(3, 1, 1, 1, 15, 85, 1466.25),	--Semilla Tomate 
(3, 2, 1, 2, 10, 65, 747.5 ),	--Semilla Lechuga 

--Compra Detalle 4
(4, 5, 1, 5, 15, 180, 3105 ),	--Insecticida

--Compra Detalle 5
(5,11 , 1, 1, 30, 25, 862.5 ),	--Tomate
(5,14 , 1, 1, 5, 850, 4887.5 )	--Frijol Rojo


SELECT * FROM PRUEBAS.COMPRA c
inner join pruebas.CompraDetalle cd on c.CompraID = cd.CompraID





go

-->>>>>>>>>>>>>>>>>>>>>>>> Entrada Producto >>>>>>>>>>>>>>>>>>>>>>>>
sp_help 'pruebas.entradaProducto'

--drop table pruebas.EntradaProducto
--drop table pruebas.EntradaProductoDetalle

Create Table Pruebas.EntradaProducto --ya creada
(
	EntradaID int primary key not null,
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



INSERT INTO Pruebas.EntradaProducto (EntradaID, SocioID, Fecha, LoteID, CompraID) VALUES
--Entrada de compra 1
(1, 6, '2025/07/07', NULL, 1),

--Entrada de Compra 2
(2, 2, '2025/07/07', NULL, 2),

--Entrada de Compra 3
(3, 6, '2025/07/07', NULL, 3 ),	

--Entrada de Compra 4
(4, 2, '2025/07/07', NULL, 4 ), 

--Entrada de Compra 5
(5, 1, '2025/07/08', 1 , 5 )	


INSERT INTO Pruebas.EntradaProductoDetalle (EntradaID, ProductoID, Cantidad, BodegaID) VALUES
--Entrada detalle de compra 1
(1, 1, 10, 1),	--Semilla Tomate
(1, 2, 10, 2),	--Semilla Lechuga

--Entrada detalle de compra 2
(2, 3, 45 , 3), --Fertilizante
(2, 4, 35 , 4),	--Urea

--Entrada detalle de compra 3
(3, 1, 15, 1),	--Semilla Tomate
(3, 2, 10, 2),	--Semilla Lechuga

--Entrada detalle de compra 4
(4, 5, 15, 5),	--Insecticida

--Entrada detalle de compra 5
(5,11, 30, 1),	--Tomate
(5,14, 5, 1)	--Frijol Rojo




select * from pruebas.EntradaProducto e 
inner join pruebas.EntradaProductoDetalle ed on e.EntradaID = ed.EntradaID



go


-->>>>>>>>>>>>>>>>>>>>>>>> Factura >>>>>>>>>>>>>>>>>>>>>>>>

--drop table pruebas.factura

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

	constraint fkFacturaNumFiscal foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID), --se agrego fk de numfiscal
	constraint chkMetodoPago check( MetodoPago in('Efectivo','Tarjeta','Cheque') ),
	constraint chkEstadoFactura check( Estado in('Abierto','Cerrado','Cancelado') ),		--CAMBIO

	constraint fkFacturaVenta foreign key (VentaID) references Pruebas.Venta(VentaID),	--CAMBIO
 	constraint fkFacturaSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkFacturaListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID),
	constraint fkFacturaEmpresa foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID),
	constraint fkFacturaEmpleado foreign key (EmpleadoID) references Pruebas.Empleado(EmpleadoID)		--CAMBIO
)
go

delete from pruebas.FacturaDetalle

--Factura Venta 1
INSERT INTO Pruebas.Factura ( VentaID,SocioID, ListaPreciosID, EmpresaID, Fecha, MetodoPago, CAI, EmpleadoID, Estado, NumFiscalID) VALUES

--Factura Venta 1
(1, 4, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000001', 1, 'Cerrado', 1),

--Factura Venta 2
(2, 8, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000002', 1, 'Cerrado', 1),

--Factura Venta 3
(3, 4, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000003', 1, 'Cerrado', 1)

INSERT INTO PRUEBAS.FacturaDetalle ( FacturaID,ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES

--Factura Detalle Venta 1
(1, 11, 1, 1, 15, 25, 431.25),	--tomate
(1, 14, 1, 1, 2, 850 , 1955),	--frijol rojo

--Factura Detalle Venta 2
(2, 11, 1, 1, 15, 25, 431.25),	--tomate

--Factura Detalle Venta 3
(3, 14, 1, 1, 3, 850 , 2932.5)	--frijol rojo


select * from pruebas.Factura f inner join pruebas.FacturaDetalle fd on f.FacturaID = fd.FacturaID




-->>>>>>>>>>>>>>>>>>>>>>>> RECIBO >>>>>>>>>>>>>>>>>>>>>>>>

Create Table Pruebas.Recibo --ya creada
(
	ReciboID int primary key not null,
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



-->>>>>>>>>>>>>>>>>>>>>>>> SALIDA >>>>>>>>>>>>>>>>>>>>>>>>

create Table Pruebas.SalidaProducto --ya creada
(
	SalidaID int primary key not null,
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
