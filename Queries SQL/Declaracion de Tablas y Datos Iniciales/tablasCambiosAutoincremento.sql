



use AgroLinkDB


--NUM FISCAL
drop table Pruebas.NumFiscal

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
