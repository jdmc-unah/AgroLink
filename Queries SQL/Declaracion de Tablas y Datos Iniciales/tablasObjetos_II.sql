Create Table Pruebas.Puesto        --YA CREADA
(
PuestoID int primary key not null,
Nombre Varchar(50)
)

create Table Pruebas.Empleado      --YA CREADA
(
EmpleadoID int primary key not null,
Nombre			varchar(50) not null,
Identidad		varchar(13) not null unique,
RTN				varchar(14) not null unique,
Correo			varchar(100),
Telefono		varchar(20) not null,
Direccion		varchar(80),
Notas			varchar(150),
PuestoID		int not null,
Estado			varchar(40)	not null,
Sexo			varchar(40) not null,
Edad			int not null,
EstadoCivil     varchar(50) not null,


constraint fkEmpleadoPuesto foreign key(PuestoID) references Pruebas.Puesto(PuestoID),

constraint chkIdentidadEmpleado check (len(Identidad) = 13),
constraint chkRTNEmpleado check (len(RTN) = 14),
constraint chkEstadoEmpleado check ( Estado in('Activo','Inactivo') ),
constraint chkSexo check ( Sexo in('Masculino','Femenino') ),
constraint chkEdad check ( Edad>=18 ),
constraint chkEstadoCivil check ( EstadoCivil in('Casado','Soltero','Union Libre'))
)

Create Table Pruebas.Departamento       --YA CREADA
(
DepartamentoID int primary key not null,
Nombre varchar(50) not null
)
  
Create Table Pruebas.Municipio          --YA CREADA
(
MunicipioID int primary key not null,
DepartamentoID int not null,
Nombre varchar(50) not null,

constraint fkMunicipioDepartamento foreign key (DepartamentoID) references Pruebas.Departamento(DepartamentoID)
)


Create Table Pruebas.Entrega      --YA CREADA
(
EntregaID int primary key not null,
Fecha Datetime not null,
SocioID int not null,
VentaID int not null,
DireccionID int not null, 
RepartidorID int not null,

constraint fkEntregaSocios foreign key (SocioID) references Pruebas.Socio(SocioID),
constraint fkEntregaVenta foreign key (VentaID) references Pruebas.Venta(VentaID),  
constraint fkEntregaDireccion foreign key (DireccionID) references Pruebas.Direccion(DireccionID),
constraint fkEntregaRepartidor foreign key (RepartidorID) references Pruebas.Empleado(EmpleadoID)
)

create table Pruebas.EntregaDetalle    --YA CREADA
(
EntregaID int not null,
ProductoID int not null,
Cantidad int not null,

constraint pkEntregaDetalle primary key (EntregaID, ProductoID),

constraint fkEntregaDetalleEntrega foreign key (EntregaID) references Pruebas.Entrega(EntregaID),  
constraint fkEntregaDetalleProducto foreign key(ProductoID) references Pruebas.Producto(ProductoID),
constraint chkCantidadEntrega check (Cantidad>=0)
)
