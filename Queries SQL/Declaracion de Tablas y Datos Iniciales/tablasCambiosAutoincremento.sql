



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


-->> Factura

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



-->> VENTA

alter table pruebas.salidaProducto add constraint fkSalidaProductoVenta
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


---datos

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









