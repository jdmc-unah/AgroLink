



use AgroLinkDB

--IMPORTANTE: A las tabla detalle no se les hizo el cambio porque deben ir relacionadas con su padre
				---------------------------------------------------------------------------------------------------
				-------------------------------------------TABLAS DE OBJETOS----------------------------------------
				---------------------------------------------------------------------------------------------------
begin transaction
-->>>>>>>>>>>>>>>>>>>>>>>>>>  NUM FISCAL >>>>>>>>>>>>>>>>>>>>>>>> 
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


select * from pruebas.numfiscal
GO

-->>>>>>>>>>>>>>>>>>>>>>>>>>  DIRECCION >>>>>>>>>>>>>>>>>>>>>>>> 
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
(510, 'El Paraíso', 'Orilla del Lago de Yojoa'),
(501, 'Segundo Anillo', '20 Calle SE')

select * from pruebas.direccion

GO



-->>>>>>>>>>>>>>>>>>>>>>>>>>  IMPUESTO	>>>>>>>>>>>>>>>>>>>>>>>> 							
--drop table Pruebas.Impuesto

sp_help 'pruebas.impuesto'

ALTER TABLE pruebas.compradetalle DROP CONSTRAINT fkCompraDetalleImpuesto  
ALTER TABLE pruebas.facturadetalle DROP CONSTRAINT fkFacturaDetalleImpuesto  
ALTER TABLE pruebas.recibodetalle DROP CONSTRAINT fkReciboDetalleImpuesto  
ALTER TABLE pruebas.ventadetalle  DROP CONSTRAINT fkVentaDetalleImpuesto 

ALTER TABLE pruebas.compradetalle  ADD CONSTRAINT fkCompraDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID)
ALTER TABLE pruebas.facturadetalle ADD CONSTRAINT fkFacturaDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID)
ALTER TABLE pruebas.recibodetalle  ADD CONSTRAINT fkReciboDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID)
ALTER TABLE pruebas.ventadetalle   ADD CONSTRAINT fkVentaDetalleImpuesto foreign key (ImpuestoID) references Pruebas.Impuesto(ImpuestoID)


create table Pruebas.Impuesto --ya creada
(
	ImpuestoID	int identity(1,1) primary key not null,
	Nombre		varchar(50) not null,
	Valor		decimal(2,2) not null,

	constraint chkValorImpuesto check (Valor >= 0 and Valor <= 1)
)

insert into Pruebas.Impuesto (Nombre, Valor) values
('ISV', 0.15),
('Impuesto sobre la Renta', 0.25),
('Impuesto Municipal', 0.2),
('Tasa de Seguridad', 0.015);


select * from Pruebas.Impuesto 



-->>>>>>>>>>>>>>>>>>>>>>>> Lista de Precios >>>>>>>>>>>>>>>>>>>>>>>> 

drop table  Pruebas.ListaPrecios

sp_help 'pruebas.ListaPrecios'

ALTER TABLE pruebas.compra  DROP CONSTRAINT  fkCompraListaPrecios 
ALTER TABLE pruebas.factura  DROP CONSTRAINT fkFacturaListaPrecios  
ALTER TABLE pruebas.productodetalle  DROP CONSTRAINT fkProductoListaPrecios 
ALTER TABLE pruebas.recibo  DROP CONSTRAINT fkReciboListaPreciosID 
ALTER TABLE pruebas.venta  DROP CONSTRAINT fkVentaListaPrecios 

ALTER TABLE pruebas.compra ADD CONSTRAINT	fkCompraListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID)
ALTER TABLE pruebas.factura	ADD CONSTRAINT	fkFacturaListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID)
ALTER TABLE pruebas.productodetalle	ADD CONSTRAINT fkProductoListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID)
ALTER TABLE pruebas.recibo ADD CONSTRAINT fkReciboListaPreciosID foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID)
ALTER TABLE pruebas.venta  ADD CONSTRAINT fkVentaListaPrecios FOREIGN key (ListaPreciosID) REFERENCES Pruebas.ListaPrecios(ListaPreciosID)


create table Pruebas.ListaPrecios --ya creada
(
	ListaPreciosID	int identity(1,1) primary key not null,
	Nombre		varchar(100) not null,
	Activo		bit not null
)


-- 4. lista de precios
insert into Pruebas.ListaPrecios ( Nombre, Activo) values
('Precios Mayorista', 1),
('Precios Minorista', 1),
('Precios Socios Especiales', 1),
('Precios Temporada Alta', 1),
('Precios Promocionales', 1),
('Precio de Costo', 1)

select * from pruebas.listaprecios




-->>>>>>>>>>>>>>>>>>>>>>>> TipoRiego >>>>>>>>>>>>>>>>>>>>>>>> 

drop table  Pruebas.TipoRiego

sp_help 'pruebas.TipoRiego'

ALTER TABLE pruebas.Lote   DROP CONSTRAINT fkLoteTipoRiego 

ALTER TABLE pruebas.Lote  ADD CONSTRAINT	fkLoteTipoRiego foreign key (TipoRiegoID) references Pruebas.TipoRiego(TipoRiegoID)


create table Pruebas.TipoRiego --ya creada
(
	TipoRiegoID 	int identity(1,1)  primary key not null,
	Nombre		varchar(50) not null,
	Descripcion 	varchar(150),
)


-- 5. tipo de riego
insert into Pruebas.TipoRiego ( Nombre, Descripcion) values
('Riego por Goteo', 'Se suministra agua directamente a las raíces de las plantas.'),
('Riego por Aspersión', 'Utiliza aspersores para distribuir el agua en el terreno.'),
('Riego por exudación', 'El agua se libera lentamente a través de tubos porosos.'),
('Riego por Microaspersión', 'Sistema de riego localizado con microaspersores de bajo caudal'),
('Riego por superficie o inundación', 'Se aplica agua directamente sobre el suelo.'),
('Riego Manual', 'Riego realizado manualmente con mangueras o regaderas');

select * from pruebas.TipoRiego



-->>>>>>>>>>>>>>>>>>>>>>>> TipoSuelo >>>>>>>>>>>>>>>>>>>>>>>> 

drop table  Pruebas.TipoSuelo

sp_help 'pruebas.TipoSuelo'

ALTER TABLE pruebas.Lote   DROP CONSTRAINT fkLoteTipoSuelo 

ALTER TABLE pruebas.Lote  ADD CONSTRAINT	 fkLoteTipoSuelo foreign key (TipoSueloID) references Pruebas.TipoSuelo(TipoSueloID)

create table Pruebas.TipoSuelo -- ya creada
(
	TipoSueloID 	int  identity(1,1) primary key not null,
	NombreComun		varchar(50) not null,
	NombreTecnico	as 
		case NombreComun
			when 'Franco-arcilloso'		then 'Alfisoles'
			when 'Volcanico'		then 'Andisoles'
			when 'Arenoso joven'		then 'Entisoles'
			when 'Organico'			then 'Histosoles'
			when 'Franco'			then 'Inceptisoles'
			when 'Franco Fertil'		then 'Mollisoles'
			when 'Arcilloso Acido'		then 'Ultisoles'
			when 'Lateritico'		then 'Oxisoles'	
			when 'Arcilloso Expansivo'	then 'Vertisoles'
			else 'Desconocido'
			END persisted,
	Descripcion 	varchar(150),

	constraint chkTipoSuelo check (NombreComun in ('Franco-arcilloso','Volcanico','Arenoso joven','Organico','Franco','Franco Fertil','Arcilloso Acido','Lateritico','Arcilloso Expansivo'))
)


-- 17. Tipo Suelo
insert into Pruebas.TipoSuelo ( NombreComun, Descripcion) values 
('Franco-arcilloso', ''),
('Volcanico', ''),
('Arenoso joven', ''),
('Organico', ''),
('Franco', ''),
('Franco Fertil', ''),
('Arcilloso Acido', ''),
('Lateritico', ''),
('Arcilloso Expansivo', '');


select * from Pruebas.TipoSuelo




-->>>>>>>>>>>>>>>>>>>>>>>> Empresa >>>>>>>>>>>>>>>>>>>>>>>> 

drop table  Pruebas.Empresa

sp_help 'pruebas.Empresa'

ALTER TABLE pruebas.Factura    DROP CONSTRAINT fkFacturaEmpresa 
ALTER TABLE pruebas.Factura    DROP CONSTRAINT fkFacturaNumFiscal 
ALTER TABLE pruebas.NumFiscal    DROP CONSTRAINT fkNumFiscalEmpresa 

ALTER TABLE pruebas.Factura   ADD CONSTRAINT	fkFacturaEmpresa foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID)
ALTER TABLE pruebas.Factura   ADD CONSTRAINT  fkFacturaNumFiscal foreign key (NumFiscalID) references Pruebas.NumFiscal(NumFiscalID)
ALTER TABLE pruebas.NumFiscal   ADD CONSTRAINT	fkNumFiscalEmpresa foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID) 


create table Pruebas.Empresa -- ya creada
(
	EmpresaID	int  identity(1,1)  primary key not null,
	CodigoEmpresa	as concat('EMP', EmpresaID) persisted,
	Nombre		varchar(100) not null,
	RTN			varchar(14) not null unique,
	Correo		varchar(100) not null,
	Telefono	varchar(20) not null,
	DireccionID	int not null,
	
	--se quito numfiscal id

	constraint fkEmpresaDireccion foreign key (DireccionID) references Pruebas.Direccion(DireccionID),
	constraint chkRTNEmpresa check (len(RTN) = 14)
)

-- 6. empresa
insert into Pruebas.Empresa ( Nombre, RTN, Correo, Telefono, DireccionID) values
('Comercializadora de Productos Agricolas', '05019999123456', 'info@agrolink.hn', '2550-1234', 1);

select * from Pruebas.Empresa 




-->>>>>>>>>>>>>>>>>>>>>>>> Socio >>>>>>>>>>>>>>>>>>>>>>>> 

drop table  Pruebas.Socio

sp_help 'pruebas.Socio'

ALTER TABLE pruebas.Compra			DROP CONSTRAINT fkCompraSocio
ALTER TABLE pruebas.EntradaProducto DROP CONSTRAINT fkEntradaProductoSocio
ALTER TABLE pruebas.Entrega			DROP CONSTRAINT fkEntregaSocios
ALTER TABLE pruebas.Factura			DROP CONSTRAINT fkFacturaSocio
ALTER TABLE pruebas.Finca			DROP CONSTRAINT fkFincaSocio
ALTER TABLE pruebas.Recibo			DROP CONSTRAINT fkReciboSocio
ALTER TABLE pruebas.SalidaProducto	DROP CONSTRAINT fkSalidaProductoSocio
ALTER TABLE pruebas.Venta			DROP CONSTRAINT fkVentaSocios


ALTER TABLE pruebas.Compra			ADD CONSTRAINT	fkCompraSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
ALTER TABLE pruebas.EntradaProducto ADD CONSTRAINT	fkEntradaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
ALTER TABLE pruebas.Entrega			ADD CONSTRAINT	fkEntregaSocios foreign key (SocioID) references Pruebas.Socio(SocioID)
ALTER TABLE pruebas.Factura			ADD CONSTRAINT	fkFacturaSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
ALTER TABLE pruebas.Finca			ADD CONSTRAINT	fkFincaSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
ALTER TABLE pruebas.Recibo			ADD CONSTRAINT	fkReciboSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
ALTER TABLE pruebas.SalidaProducto	ADD CONSTRAINT	fkSalidaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
ALTER TABLE pruebas.Venta			ADD CONSTRAINT	fkVentaSocios FOREIGN KEY (SocioID) REFERENCES Pruebas.Socio(SocioID)


create table Pruebas.Socio --ya creada
(
	SocioID			int identity(1,1) primary key not null,
	CodigoSocio		as 
		case TipoSocio
			when 'Agricultor' then 'AGR'
			when 'Proveedor' then 'PRO'
			when 'Consumidor' then 'CON'
			END + cast (SocioID as varchar) persisted,
	Nombre			varchar(150) not null,
	TipoSocio		varchar(20) not null,
	Identidad		varchar(13) not null unique,
	RTN				varchar(14) not null unique,
	Correo			varchar(100) not null,
	Telefono		varchar(20) not null,
	DireccionID		int not null,
	Notas			varchar(150),
	Saldo			decimal(10, 2) not null,  --se agrego saldo

	constraint fkSocioDireccion foreign key (DireccionID) references Pruebas.Direccion(DireccionID),
	
	constraint chkTipoSocio check (TipoSocio in ('Agricultor','Proveedor','Consumidor')),
	constraint chkIdentidad check (len(Identidad) = 13),
	constraint chkRTN check (len(RTN) = 14)
)

-- 8. socio
insert into Pruebas.Socio ( Nombre, TipoSocio, Identidad, RTN, Correo, Telefono, DireccionID, Notas, Saldo) values
('José Manuel Flores', 'Agricultor', '0502199812345', '05021998123456', 'joseflores@email.com', '9876-5432', 4, 'Productor de plátano en Choloma',0),
('Agrosuministros S.A.', 'Proveedor', '0501199923456', '05011999234567', 'ventas@agroceiba.hn', '2557-6789', 5, 'Distribuidor de fertilizantes', 0),
('Carmen Elena Mejía', 'Agricultor', '0511198734567', '05011987345678', 'carmenmejia@email.com', '8765-4321', 6, 'Productora orgánica en Villanueva', 0),
('Supermercados Del Norte', 'Consumidor', '0501199845678', '05011998456789', 'compras@delnorte.hn', '2558-7890', 7, 'Cadena regional de supermercados', 0),
('Roberto Alvarado', 'Agricultor', '0512199056789', '05121990567890', 'roberto.alvarado@email.com', '9654-3210', 8, 'Especialista en hortalizas', 0),
('Insumos Agrícolas', 'Proveedor', '0501199167890', '05011991678901', 'info@insumoscortes.hn', '2559-8901', 9, 'Proveedor de semillas certificadas', 0),
('Ana Sofía Castillo', 'Agricultor', '0510198978901', '05101989789012', 'ana.castillo@email.com', '9543-2109', 10, 'Cultivos de exportación Lago Yojoa' , 0),
('Supermercado La Colonia', 'Consumidor', '0501200012345','05012000123455', 'info@lacolonia.com', '2251-6352',11 , 'Supermercado La Colonia', 0  )

select * from Pruebas.Socio 



-->>>>>>>>>>>>>>>>>>>>>>>> Usuario >>>>>>>>>>>>>>>>>>>>>>>> 

drop table  Pruebas.Usuario

sp_help 'pruebas.Usuario'


create table Pruebas.Usuario -- ya creada
(
	UsuarioID	int identity(1,1) primary key not null,
	CodigoUsuario	as concat('USR', UsuarioID) persisted, 
	Usuario		varchar(50) not null unique,	
	Clave		varchar(25) not null,	
	Nombre		varchar(100) not null,			
	TipoUsuario varchar(20) not null,
	
	constraint chkTipoUsuario check (TipoUsuario in ('Administrador','Estandar'))
)

-- 7. usuario
insert into Pruebas.Usuario ( Usuario, Clave, Nombre, TipoUsuario) values
('admin', 'admin123', 'Admin Agrolink', 'Administrador'),
('jose.mejia', '111', 'Jose Daniel Mejia', 'Estandar'),
('kisha.mejia', '111', 'Kisha Mejia', 'Estandar'),
('josue.varela', '111', 'Josue Varela', 'Estandar'),
('arleth.oseguera', '111', 'Arleth Oseguera', 'Estandar');

select * from Pruebas.Usuario 





-->>>>>>>>>>>>>>>>>>>>>>>> Usuario >>>>>>>>>>>>>>>>>>>>>>>> 
drop table  Pruebas.Finca

sp_help 'pruebas.Finca'

ALTER TABLE pruebas.Lote	DROP CONSTRAINT fkLoteFinca

ALTER TABLE pruebas.Lote	ADD CONSTRAINT	fkLoteFinca foreign key (FincaID) references Pruebas.Finca(FincaID)

create table Pruebas.Finca --ya creada
(
	FincaID		int identity(1,1) primary key not null,
	CodigoFinca	as concat('FIN', FincaID) persisted, 
	SocioID		int  not null,
	Nombre		varchar(100) not null,
	DireccionID	int not null,
	CapacidadAgua	varchar(10) not null,

	constraint fkFincaSocio foreign key (SocioID) references Pruebas.Socio(SocioID),
	constraint fkFincaDireccion foreign key (DireccionID) references Pruebas.Direccion(DireccionID),

	constraint ckCapacidadAgua check (CapacidadAgua in ('Baja','Media','Alta'))	
)

-- 9. finca
insert into Pruebas.Finca ( SocioID, Nombre, DireccionID, CapacidadAgua) values
(1, 'Finca San José', 4, 'Alta'),
(3, 'Finca Orgánica', 6, 'Media'),
(5, 'Finca El Paraíso', 7, 'Alta'),
(7, 'Finca Lago Verde', 10, 'Alta'),
(1, 'Finca Los Plátanos', 4, 'Media');

select * from Pruebas.Finca 




-->>>>>>>>>>>>>>>>>>>>>>>> TipoProducto >>>>>>>>>>>>>>>>>>>>>>>> 
drop table  Pruebas.TipoProducto

sp_help 'pruebas.TipoProducto'

ALTER TABLE pruebas.Producto	DROP CONSTRAINT fkProductoTipoProducto

ALTER TABLE pruebas.Producto	ADD CONSTRAINT	fkProductoTipoProducto foreign key (TipoID) references Pruebas.TipoProducto(TipoID)


create table Pruebas.TipoProducto -- ya creada
(
	TipoID		int identity(1,1)  primary key not null,
	NombreTipo	varchar(100) not null,
	Categoria	varchar (25) not null,
	
	constraint chkCategoriaProducto check (Categoria in('Insumo','Producto Agricola'))
)


-- 10. tipo de producto
insert into Pruebas.TipoProducto (NombreTipo, Categoria) values
('Semillas Certificadas', 'Insumo'),
('Fertilizantes', 'Insumo'),
('Agroquímicos', 'Insumo'),
('Frutas Tropicales', 'Producto Agricola'),
('Hortalizas', 'Producto Agricola'),
('Granos Básicos', 'Producto Agricola'),
('Herramientas', 'Insumo'),
('Cultivos Exportación', 'Producto Agricola');

select * from Pruebas.TipoProducto 






-->>>>>>>>>>>>>>>>>>>>>>>> UnidadMedida >>>>>>>>>>>>>>>>>>>>>>>> 
drop table  Pruebas.UnidadMedida

sp_help 'pruebas.UnidadMedida'

ALTER TABLE pruebas.Producto	DROP CONSTRAINT fkProductoUnidadMedida

ALTER TABLE pruebas.Producto	ADD CONSTRAINT	fkProductoUnidadMedida foreign key (UnidadMedidaID) references Pruebas.UnidadMedida(UnidadMedidaID)


create table Pruebas.UnidadMedida -- ya creada
(
	UnidadMedidaID	int identity(1,1) primary key not null,
	Nombre		varchar(50) not null,
	Abreviacion	varchar(10) not null,
)


-- 11. unidad de medida
insert into Pruebas.UnidadMedida (Nombre, Abreviacion) values
('Kilogramo', 'kg'),
('Libra', 'lb'),
('Quintal', 'q'),
('Litro', 'lts'),
('Galón', 'gal'),
('Saco', 'saco'),
('Caja', 'caja'),
('Unidad', 'ud'),
('Metro', 'm'),
('Tonelada', 't');

select * from Pruebas.UnidadMedida 





-->>>>>>>>>>>>>>>>>>>>>>>> Producto >>>>>>>>>>>>>>>>>>>>>>>> 
drop table  Pruebas.Producto

sp_help 'pruebas.Producto'

ALTER TABLE pruebas.BodegaDetalle			DROP CONSTRAINT		fkBodegaDetalleProducto
ALTER TABLE pruebas.CompraDetalle			DROP CONSTRAINT		fkCompraDetalleProducto
ALTER TABLE pruebas.EntradaProductoDetalle	DROP CONSTRAINT		fkEntradaProductoDetalleProducto
ALTER TABLE pruebas.FacturaDetalle			DROP CONSTRAINT		fkFacturaDetalleProducto
ALTER TABLE pruebas.EntregaDetalle			DROP CONSTRAINT		fkEntregaDetalleProducto
ALTER TABLE pruebas.Lote					DROP CONSTRAINT		fkLoteProducto
ALTER TABLE pruebas.ProductoDetalle			DROP CONSTRAINT		fkProductoDetalleProducto
ALTER TABLE pruebas.ReciboDetalle			DROP CONSTRAINT		fkReciboDetalleProducto
ALTER TABLE pruebas.SalidaProductoDetalle	DROP CONSTRAINT		fkSalidaProductoDetalleProducto
ALTER TABLE pruebas.VentaDetalle			DROP CONSTRAINT		fkVentaDetalleProducto

ALTER TABLE pruebas.BodegaDetalle			ADD CONSTRAINT		fkBodegaDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.CompraDetalle			ADD CONSTRAINT		fkCompraDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.EntradaProductoDetalle	ADD CONSTRAINT		fkEntradaProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.FacturaDetalle			ADD CONSTRAINT		fkFacturaDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.EntregaDetalle			ADD CONSTRAINT		fkEntregaDetalleProducto foreign key(ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.Lote					ADD CONSTRAINT		fkLoteProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.ProductoDetalle			ADD CONSTRAINT		fkProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.ReciboDetalle			ADD CONSTRAINT		fkReciboDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.SalidaProductoDetalle	ADD CONSTRAINT		fkSalidaProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)
ALTER TABLE pruebas.VentaDetalle			ADD CONSTRAINT		fkVentaDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID)


create table Pruebas.Producto -- ya creada
(
	ProductoID	int  identity(1,1) primary key not null,
	CodigoProducto	as concat('PRO', ProductoID) persisted, 
	TipoID		int not null,
	UnidadMedidaID	int not null,
	Nombre		varchar(50) not null,

	constraint fkProductoTipoProducto foreign key (TipoID) references Pruebas.TipoProducto(TipoID),
	constraint fkProductoUnidadMedida foreign key (UnidadMedidaID) references Pruebas.UnidadMedida(UnidadMedidaID)
)


-- 12. productos
insert into Pruebas.Producto (TipoID, UnidadMedidaID, Nombre) values
( 1, 1, 'Semilla Tomate '),
( 1, 1, 'Semilla Lechuga '),
( 2, 6, 'Fertilizante'),
( 2, 6, 'Urea Granulada 46%'),
( 3, 4, 'Insecticida Cipermetrina'),
( 3, 4, 'Fungicida Propiconazol'),
( 7, 8, 'Machete Tramontina'),
( 7, 8, 'Bomba Fumigadora'),
-- Productos Agrícolas (Típicos de Cortés)
(4, 7, 'Banano'),
(4, 7, 'Plátano Verde'),
(5, 1, 'Tomate'),
(5, 1, 'Lechuga Iceberg'),
(6, 3, 'Maíz'),
(6, 3, 'Frijol Rojo'),
(8, 1, 'Melón');

select * from Pruebas.Producto 




-->>>>>>>>>>>>>>>>>>>>>>>> ProductoDetalle >>>>>>>>>>>>>>>>>>>>>>>> 

--Se agregó productos con lista de precio costo y se arreglo la tabla ya que como estaba no se podian agregar mas precios

drop table  Pruebas.ProductoDetalle

sp_help 'pruebas.ProductoDetalle'

create table Pruebas.ProductoDetalle -- ya creada
(
	ProductoID	int not null,
	ListaPreciosID	int not null,
	Precio		decimal(10,2) not null default 0 check (Precio >= 0),

	constraint pkProductoDetalle primary key (ProductoID, ListaPreciosID),  --agregar pk compuesta para poder tener mas de un precio
	constraint fkProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkProductoListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID)
)


delete from pruebas.ProductoDetalle
-- 13. producto detalle (precios)
insert into Pruebas.ProductoDetalle ( ProductoID, ListaPreciosID, Precio) values
-- Precios para lista mayorista (ID 1)
(1, 1, 85.00),      -- Semilla Tomate 
(1, 6, 50.00),      -- Semilla Tomate Costo
(2, 1, 65.00),      -- Semilla Lechuga
(2, 6, 50.00),      -- Semilla Lechuga Costo
(3, 1, 750.00),     -- Fertilizante
(3, 6, 500.00),     -- Fertilizante Costo
(4, 1, 680.00),     -- Urea 46%
(4, 6, 600.00),     -- Urea 46% costo
(5, 1, 180.00),     -- Insecticida
(5, 6, 100.00),     -- Insecticida costo
(6, 1, 140.00),     -- Fungicida 
(6, 6, 100.00),     -- Fungicida costo
(7, 1, 280.00),     -- Machete
(7, 6, 250.00),     -- Machete costo
(8, 1, 1250.00),    -- Bomba Fumigadora
(8, 6, 1000.00),    -- Bomba Fumigadora costo
(9, 1, 120.00),     -- Banano (caja)
(9, 6, 90.00),     -- Banano (caja) Costo
(10, 1, 95.00),     -- Plátano Verde (caja)
(10, 6, 70.00),     -- Plátano Verde (caja) Costo
(11, 1, 25.00),     -- Tomate (kg)
(11, 6, 10.00),     -- Tomate (kg) Costo
(12, 1, 18.00),     -- Lechuga Iceberg (kg)
(12, 6, 10.00),     -- Lechuga Iceberg (kg) Costo
(13, 1, 520.00),    -- Maíz (q) - Precio oficial 2024
(13, 6, 400.00),    -- Maíz (q) - Costo
(14, 1, 850.00),    -- Frijol Rojo (q)
(14, 6, 700.00),    -- Frijol Rojo (q) costo
(15, 1, 45.00),     -- Melón (kg) 
(15, 6, 30.00);     -- Melón (kg) costo

select * from pruebas.Producto p inner join
Pruebas.ProductoDetalle pd on p.ProductoID = pd.ProductoID



-->>>>>>>>>>>>>>>>>>>>>>>> Lote >>>>>>>>>>>>>>>>>>>>>>>> 
drop table  Pruebas.Lote

sp_help 'pruebas.Lote'

ALTER TABLE pruebas.EntradaProducto DROP CONSTRAINT fkEntradaProductoLote

ALTER TABLE pruebas.EntradaProducto  ADD CONSTRAINT	fkEntradaProductoLote foreign key (LoteID) references Pruebas.Lote(LoteID)

create table Pruebas.Lote --ya creada
(
	LoteID		int identity(1,1) primary key not null,
	CodigoLote	as concat('LOT', LoteID) persisted, --calcula el valor automaticamente, se puede indexar, no se modifica directamente
	FincaID		int not null,
	ProductoID	int not null,
	TipoRiegoID	int not null,
	TipoSueloID	int not null,
	FechaSiembra	date not null,
	FechaCosecha	date not null,
	Extension		decimal(8,2) not null,
	
	constraint fkLoteFinca foreign key (FincaID) references Pruebas.Finca(FincaID),
	constraint fkLoteProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkLoteTipoRiego foreign key (TipoRiegoID) references Pruebas.TipoRiego(TipoRiegoID),
	constraint fkLoteTipoSuelo foreign key (TipoSueloID) references Pruebas.TipoSuelo(TipoSueloID)
	-- constraint tipos de suelo
)


-- 16. lote
insert into Pruebas.Lote ( FincaID, ProductoID, TipoRiegoID, TipoSueloID, FechaSiembra, FechaCosecha, Extension) values
(1, 11, 1, 3, '2024-03-15', '2024-07-15', 255.50),  -- Tomate Cherry en Finca San José
(1, 15, 3, 2, '2024-01-10', '2024-12-10', 536.00),    -- Café en Finca San José
(2, 12, 2, 4, '2024-04-01', '2024-06-01', 365.75),   -- Lechuga en Finca Las Flores
(3, 13, 1, 5, '2024-05-20', '2024-10-20', 365.25),        -- Maíz en Finca El Paraíso
(4, 9, 4, 1, '2024-02-01', '2024-05-01', 494.00),  -- Banano en Finca Bella Vista
(5, 14, 2, 6, '2024-06-15', '2024-11-15', 265.80);    -- Frijol en Finca Los Robles

select * from Pruebas.Lote 




-->>>>>>>>>>>>>>>>>>>>>>>> Bodega >>>>>>>>>>>>>>>>>>>>>>>> 
drop table  Pruebas.Bodega

sp_help 'pruebas.Bodega'

ALTER TABLE pruebas.BodegaDetalle			DROP CONSTRAINT		fkBodegaDetalleBodega
ALTER TABLE pruebas.CompraDetalle			DROP CONSTRAINT		fkCompraDetalleBodega
ALTER TABLE pruebas.EntradaProductoDetalle	DROP CONSTRAINT		fkEntradaProductoBodega
ALTER TABLE pruebas.FacturaDetalle			DROP CONSTRAINT		fkFacturaDetalleBodega
ALTER TABLE pruebas.ReciboDetalle			DROP CONSTRAINT		fkReciboDetalleBodega2
ALTER TABLE pruebas.SalidaProductoDetalle	DROP CONSTRAINT		fkSalidaProductoDetalleBodega
ALTER TABLE pruebas.VentaDetalle			DROP CONSTRAINT		fkVentaDetalleBodega

ALTER TABLE pruebas.BodegaDetalle			ADD CONSTRAINT		fkBodegaDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
ALTER TABLE pruebas.CompraDetalle			ADD CONSTRAINT		fkCompraDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)	
ALTER TABLE pruebas.EntradaProductoDetalle	ADD CONSTRAINT		fkEntradaProductoBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
ALTER TABLE pruebas.FacturaDetalle			ADD CONSTRAINT		fkFacturaDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
ALTER TABLE pruebas.ReciboDetalle			ADD CONSTRAINT		fkReciboDetalleBodega2 foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
ALTER TABLE pruebas.SalidaProductoDetalle	ADD CONSTRAINT		fkSalidaProductoDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
ALTER TABLE pruebas.VentaDetalle			ADD CONSTRAINT		fkVentaDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)


create table Pruebas.Bodega -- ya creada
(
	BodegaID		int identity(1,1) primary key not null,
	CodigoBodega 	as concat('BOD', BodegaID) persisted, 
	Nombre			varchar(50) not null,
	Capacidad		decimal(6,2) not null,
	DireccionID   	int not null,

	constraint fkBodegaDireccion foreign key (DireccionID) references Pruebas.Direccion(DireccionID)
)


-- 14. bodega
insert into Pruebas.Bodega ( Nombre, Capacidad, DireccionID) values
('Bodega Central SPS', 800.00, 1),
('Bodega Puerto Cortés', 600.00, 5),
('Bodega Choloma', 400.00, 4),
('Bodega Villanueva', 350.00, 6),
('Bodega La Lima', 300.00, 7);

select * from Pruebas.Bodega 















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
	EntradaID int identity(1,1) primary key not null,
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



INSERT INTO Pruebas.EntradaProducto ( SocioID, Fecha, LoteID, CompraID) VALUES
--Entrada de compra 1
( 6, '2025/07/07', NULL, 1),

--Entrada de Compra 2
( 2, '2025/07/07', NULL, 2),

--Entrada de Compra 3
( 6, '2025/07/07', NULL, 3 ),	

--Entrada de Compra 4
( 2, '2025/07/07', NULL, 4 ), 

--Entrada de Compra 5
( 1, '2025/07/08', 1 , 5 )	


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
sp_help 'pruebas.recibo'

drop table Pruebas.Recibo 

Create Table Pruebas.Recibo --ya creada
(
	ReciboID int identity(1,1)  primary key not null,
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

delete from pruebas.ReciboDetalle

INSERT INTO Pruebas.Recibo (CompraID, ListaPreciosID, SocioID, MetodoPago, Fecha, EmpleadoID, Estado) VALUES
--Recibo Compra 1
(1, 6, 6, 'Tarjeta', '2025/07/07', 1 , 'Cerrado'),

--Recibo Compra 2
(2, 6, 2, 'Tarjeta', '2025/07/07', 1 , 'Cerrado'),

--Recibo Compra 3
(3, 6, 6, 'Tarjeta', '2025/07/07', 1 , 'Cerrado'),

--Recibo Compra 4
(4, 6, 2, 'Tarjeta', '2025/07/07', 1 , 'Cerrado'),

--Recibo Compra 5
(5, 6, 1, 'Cheque', '2025/07/10', 1 , 'Cerrado')



INSERT INTO Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
--Recibo Detalle Compra  1
(1, 1, 1, 1, 10, 85,977.5),  --Semilla Tomate 
(1, 2, 1, 2, 10, 65, 747.5 ), --Semilla Lechuga 

--Recibo Detalle Compra 2
(2, 3, 1, 3, 45, 750, 38812.5 ),	--Fertilizante
(2, 4, 1, 4, 35, 680, 27370 ),		--Urea

--Recibo Detalle Compra 3
(3, 1, 1, 1, 15, 85, 1466.25),	--Semilla Tomate 
(3, 2, 1, 2, 10, 65, 747.5 ),	--Semilla Lechuga 

--Recibo Detalle Compra 4
(4, 5, 1, 5, 15, 180, 3105 ),	--Insecticida

--Recibo Detalle Compra 5
(5,11 , 1, 1, 30, 25, 862.5 ),	--Tomate
(5,14 , 1, 1, 5, 850, 4887.5 )	--Frijol Rojo


SELECT * FROM PRUEBAS.Recibo r
inner join pruebas.ReciboDetalle rd on r.ReciboID = rd.ReciboID




-->>>>>>>>>>>>>>>>>>>>>>>> SALIDA >>>>>>>>>>>>>>>>>>>>>>>>  
sp_help 'pruebas.salidaproducto'

drop table pruebas.SalidaProducto
drop table pruebas.SalidaProductoDetalle

create Table Pruebas.SalidaProducto --ya creada
(
	SalidaID int identity(1,1) primary key not null,
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


INSERT INTO Pruebas.SalidaProducto (VentaID, SocioID, Fecha) VALUES
--Salida de Venta 1
(1, 4, '2025/07/09' ),	--Salida de producto 11
--Salida de Venta 2
(2, 8, '2025/07/09' ),	--Salida de producto 11

--Salida de Venta 3
(3, 4, '2025/07/09' )	--Salida de producto 14

INSERT INTO Pruebas.SalidaProductoDetalle (SalidaID, ProductoID, Cantidad, BodegaID) VALUES
--Salida Detalle de Venta 1
(1,11, 15, 1), --Tomate
(1,14, 2 , 1),	--Frijol Rojo

--Salida Detalle de Venta 2
(2,11, 15,1), --Tomate

--Salida Detalle de Venta 3
(3, 14, 3, 1)	--Frijol Rojo


select * from pruebas.SalidaProducto s 
inner join pruebas.SalidaProductoDetalle sd on s.SalidaID = sd.SalidaID

