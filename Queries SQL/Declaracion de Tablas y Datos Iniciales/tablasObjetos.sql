use AgroLinkDB

-- nomenclatura de foreign keys fk<TablaHija><TablaPadre>

-- tablas amiguitas

create table Pruebas.Direccion	--ya creada
(
    DireccionID int identity(1,1) primary key,
    MunicipioID int not null,
    Colonia		varchar(50),
    Detalle		varchar(250),

	constraint fkDireccionMunicipio foreign key (MunicipioID) references Pruebas.Municipio(MunicipioID)
)

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




create table Pruebas.Impuesto --ya creada
(
	ImpuestoID	int identity(1,1) primary key not null,
	Nombre		varchar(50) not null,
	Valor		decimal(2,2) not null,

	constraint chkValorImpuesto check (Valor >= 0 and Valor <= 1)
)


create table Pruebas.ListaPrecios --ya creada
(
	ListaPreciosID	int identity(1,1) primary key not null,
	Nombre			varchar(100) not null,
	Activo			bit not null
)

create table Pruebas.TipoRiego --ya creada
(
	TipoRiegoID 	int identity(1,1) primary key not null,
	Nombre			varchar(50) not null,
	Descripcion 	varchar(150),
)


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

create table Pruebas.TipoProducto -- ya creada
(
	TipoID		int identity(1,1) primary key not null,
	NombreTipo	varchar(100) not null,
	Categoria	varchar (25) not null,
	
	constraint chkCategoriaProducto check (Categoria in('Insumo','Producto Agricola'))
)

create table Pruebas.UnidadMedida -- ya creada
(
	UnidadMedidaID	int identity(1,1) primary key not null,
	Nombre		varchar(50) not null,
	Abreviacion	varchar(10) not null,
)

create table Pruebas.Producto -- ya creada
(
	ProductoID	int primary key not null,
	CodigoProducto	as concat('PRO', ProductoID) persisted, 
	TipoID		int not null,
	UnidadMedidaID	int not null,
	Nombre		varchar(50) not null,

	constraint fkProductoTipoProducto foreign key (TipoID) references Pruebas.TipoProducto(TipoID),
	constraint fkProductoUnidadMedida foreign key (UnidadMedidaID) references Pruebas.UnidadMedida(UnidadMedidaID)
)

create table Pruebas.ProductoDetalle -- ya creada
(
	ProductoID	int primary key not null,
	ListaPreciosID	int not null,
	Precio		decimal(10,2) not null default 0 check (Precio >= 0),

	constraint fkProductoDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),
	constraint fkProductoListaPrecios foreign key (ListaPreciosID) references Pruebas.ListaPrecios(ListaPreciosID)
)

create table Pruebas.Lote --ya creada
(
	LoteID		int primary key not null,
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

create table Pruebas.Bodega -- ya creada
(
	BodegaID		int primary key not null,
	CodigoBodega 	as concat('BOD', BodegaID) persisted, 
	Nombre			varchar(50) not null,
	Capacidad		decimal(6,2) not null,
	DireccionID   	int not null,

	constraint fkBodegaDireccion foreign key (DireccionID) references Pruebas.Direccion(DireccionID)
)
	
create table Pruebas.BodegaDetalle -- ya creada/editada
(
	BodegaID	 int not null,
	ProductoID	 int not null,
	Comprometido	 decimal(10,2) not null default 0 check (Comprometido >= 0),
	TotalExistencias decimal(10,2) not null default 0 check (TotalExistencias >= 0),
	
	constraint pkBodegaDetalle primary key (BodegaID, ProductoID),
	constraint fkBodegaDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID),
	constraint fkBodegaDetalleProducto foreign key (ProductoID) references Pruebas.Producto(ProductoID),

	constraint chkComprometidoMenorTotal check (Comprometido <= TotalExistencias)
)







