use AgroLinkDB

-- nomenclatura de foreign keys fk<TablaHija><TablaPadre>

-- tablas amiguitas

create table Direccion
(
	DireccionID	int primary key not null,
	Departamento	varchar(50) not null,
	Municipio	varchar(50) not null,
	Colonia		varchar(50),
	Detalle		varchar(150)
)

create table NumFiscal
(
	NumFiscalID		int primary key not null,
	RangoInicio		varchar(20) not null,
	RangoFin		varchar(20) not null,
	Estado			varchar(10) not null,
	FechaVencimiento	date not null,

	constraint chkEstado check (Estado in('activo','inactivo'))
	
	-- ideas para automatizar Estado
	-- 1. podriamos usar un trigger que, al insertar o actualizar, revise la fecha de vencimiento y actualice el estado automaticamente
	-- 2. usamos una columna calculada que se actualiza segun la fecha
)

create table Impuesto
(
	ImpuestoID	int primary key not null,
	Nombre		varchar(50) not null,
	Valor		decimal(5,2) not null,

	constraint chkValorImpuesto check (Valor >= 0 and Valor <= 100)
)

create table ListaPrecios
(
	ListaPreciosID	int primary key not null,
	Nombre		varchar(100) not null,
	
	-- ¿es mejor tipo boolean o tipo varchar?

	-- Activo			bit not null default 1, -- 1 para activo, 0 para inactivo
	-- Activo varchar(10) not null,
	-- constraint chkActivo check (Activo in ('Activo', 'Inactivo'))
)

create table TipoRiego
(
	TipoRiegoID 	int primary key not null,
	Nombre		varchar(50) not null,
	Descripcion 	varchar(150),
)

create table Empresa
(
	EmpresaID	int primary key not null,
	CodigoEmpresa	as concat('EMP', EmpresaID) persisted, --calcula el valor automaticamente, se puede indexar, no se modifica directamente
	Nombre		varchar(100) not null,
	RTN		varchar(14) not null unique,
	Correo		varchar(100) not null,
	Telefono	varchar(20) not null,
	DireccionID	int not null,
	NumFiscalID	int not null,
	
	constraint fkEmpresaDireccion foreign key (DireccionID) references Direccion(DireccionID)
	-- constraint chkRTN check (len(RTN) = 14)
	
)

create table Socio
(
	SocioID			int primary key not null,
	CodigoSocio		as concat('SOC', SocioID) persisted, --calcula el valor automaticamente, se puede indexar, no se modifica directamente
	Nombre			varchar(150) not null,
	TipoSocio		varchar(20) not null,
	Identidad		varchar(13) not null unique,
	RTN			varchar(14) not null unique,
	Correo			varchar(100) not null,
	Telefono		varchar(20) not null,
	DireccionID		int not null,
	Notas			varchar(150),

	foreign key (DireccionID) references Direccion(DireccionID),
	constraint chkTipoSocio check (TipoSocio in ('Agricultor','Proveedor', 'Consumidor'))
	
	-- constraint chkIdentidad check (len(Identidad) = 13)
	-- constraint chkRTN check (len(RTN) = 14)

	-- para incluir codigo no sabria como incluirlo como default ideas:
	-- 1. hacer una columna calculada maybe
	-- 2. crear un trigger para generar el codigo automatico segun el tipo
)

create table Usuario
(
	UsuarioID	int primary key not null,
	-- ?? CodigoUsuario	as concat('USU', UsuarioID) persisted, --calcula el valor automaticamente, se puede indexar, no se modifica directamente
	Usuario		varchar(50) not null unique,	-- kmm (puede facilmente quitarse)
	Clave		varchar(25) not null,	-- Clave o Contraseña
	Nombre		varchar(100) not null,			-- kisha Mejia
	TipoUsuario varchar(20) not null,
	
	constraint chkTipoUsuario check (TipoUsuario in ('Administrador','Usuario regular'))
)

create table Finca
(
	FincaID		int primary key not null,
	CodigoFinca	as concat('FIN', FincaID) persisted, --calcula el valor automaticamente, se puede indexar, no se modifica directamente
	SocioID		int  not null,
	Nombre		varchar(100) not null,
	DireccionID	int not null,
	CapacidadAgua	varchar(10) not null,

	constraint fkFincaSocio foreign key (SocioID) references Socio(SocioID),
	constraint fkFincaDireccion foreign key (DireccionID) references Direccion(DireccionID),

	constraint fkCapacidadAgua check (CapacidadAgua in ('Baja','Media','Alta'))	
)

create table TipoProducto
(
	TipoID		int primary key not null,
	NombreTipo	varchar(100) not null,
	Categoria	varchar (25) not null,
	
	constraint chkCategoriaProducto check (Categoria in('Insumo','Producto Agricola'))
)

create table UnidadMedida
(
	UnidadMedidaID	int primary key not null,
	Nombre		varchar(50) not null,
	Abreviacion	varchar(10) not null,
)

create table Producto
(
	ProductoID	int primary key not null,
	CodigoProducto	as concat('PRO', ProductoID) persisted, --calcula el valor automaticamente, se puede indexar, no se modifica directamente
	TipoID		int not null,
	UnidadMedidaID	int not null,
	Nombre		varchar(50) not null,

	constraint fkProductoTipoProducto foreign key (TipoID) references TipoProducto(TipoID),
	constraint fkProductoUnidadMedida foreign key (UnidadMedidaID) references UnidadMedida(UnidadMedidaID)
)

create table ProductoDetalle
(
	ProductoID	int not null,
	ListaPreciosID	int not null,
	Precio		decimal(10,2) not null default 0 check (Precio >= 0),

	constraint pkProductoDetalle primary key (ProductoID),
	constraint fkProductoDetalleProducto foreign key (ProductoID) references Producto(ProductoID),
	constraint fkProductoListaPrecios foreign key (ListaPreciosID) references ListaPrecios(ListaPreciosID)
)

create table Lote
(
	LoteID		int primary key not null,
	CodigoLote	as concat('LOT', LoteID) persisted, --calcula el valor automaticamente, se puede indexar, no se modifica directamente
	FincaID		int not null,
	ProductoID	int not null,
	TipoRiegoID	int not null,
	TipoSuelo	varchar(50) not null,
	FechaSiembra	date not null,
	FechaCosecha	date not null,
	Extension		decimal(6,2) not null,
	
	constraint fkLoteFinca foreign key (FincaID) references Finca(FincaID),
	constraint fkLoteProducto foreign key (ProductoID) references Producto(ProductoID),
	constraint fkLoteTipoRiego foreign key (TipoRiegoID) references TipoRiego(TipoRiegoID)
)

create table Bodega
(
	BodegaID	int primary key not null,
	CodigoBodega 	as concat('BOD', BodegaID) persisted, --calcula el valor automaticamente, se puede indexar, no se modifica directamente
	Nombre		varchar(50) not null,
	Capacidad	decimal(6,2) not null,
	DireccionID   	int not null,

	constraint fkBodegaDireccion foreign key (DireccionID) references Direccion(DireccionID)
)
	
create table BodegaDetalle
(
	BodegaID	 int not null,
	ProductoID	 int not null,
	Comprometido	 decimal(10,2) not null default 0 check (Comprometido >= 0),
	TotalExistencias decimal(10,2) not null default 0 check (TotalExistencias >= 0),
	
	constraint pkBodegaDetalle primary key (BodegaID),
	constraint fkBodegaDetalleBodega foreign key (BodegaID) references Bodega(BodegaID),
	constraint fkBodegaDetalleProducto foreign key (ProductoID) references Producto(ProductoID),

	constraint chkComprometidoMenorTotal check (Comprometido <= TotalExistencias)
)
