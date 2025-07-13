--ya creada
Create Table Pruebas.Puesto
(
PuestoID int primary key not null,
Nombre Varchar(50)
)





create Table Pruebas.Empleado
(
EmpleadoID int primary key not null,
Nombre			varchar(50) not null,
Identidad		varchar(13) not null unique,
RTN				varchar(14) not null unique,
Correo			varchar(100),
Telefono		varchar(20) not null,
Direccion		varchar(80),
Notas			varchar(150),
PuestoID		int,
Estado			varchar(40)	not null,
Sexo			varchar(40) not null,
Edad			int not null,
EstadoCivil     varchar(50) not null,


constraint fkEmpleadoPuesto foreign key(PuestoID) references Pruebas.Puesto(PuestoID),

constraint chkIdentidad check (len(Identidad) = 13),
constraint chkRTN check (len(RTN) = 14),
constraint chkEstado check ( Estado in('Activo','Inactivo') ),
constraint chkSexo check ( Sexo in('Mascullino','Femenino') ),
constraint chkEdad check ( Edad>=18 ),
constraint chkEstadoCivil check ( EstadoCivil in('Casado','Soltero','Union Libre'))

)



Create Table Pruebas.Departamento -- ya creada 
(
DepartamentoID int primary key not null,
Nombre varchar(50) not null

)


Create Table Pruebas.Municipio --ya creada
(
MunicipioID int primary key not null,
DepartamentoID int not null,
Nombre varchar(50) not null,

constraint fkMunicipioDepartamento foreign key (DepartamentoID) references Pruebas.Departamento(DepartamentoID)
)


Create Table Pruebas.Entrega
(
EntregaID int not null,
Fecha Datetime not null,
SocioID int not null,
DocumentoID int not null,
Direccion varchar(80) not null, -- no se si usamos la tabla dirrecion :/
RepartidorID int not null,

constraint fkEntregaSocios foreign key (SocioID) references Pruebas.Socio(SocioID),
constraint fkEntregaDocumento foreign key (DocumentoID)references Pruebas.Factura(facturaID),  
constraint fkEntregaRepartidor foreign key (RepartidorID) references Pruebas.Empleado(EmpleadoID)
)

create table Pruebas.EntregaDetalle
(
EntregaID int not null,
ProductoID int not null,
cantidad int not null,

constraint fkEntregaDetalleProducto foreign key(ProductoID) references Pruebas.Producto(ProductoID),
constraint chkCantidad check (cantidad>=0)
)