
--Procedimientos Almacenados Modulo Empresa

use AgroLinkDB

go
------------------Notas---------------------
-->>
------------------------------------------------------

CREATE TYPE TipoNumFiscal AS TABLE (
	NumFiscalID			int primary key not null,
	RangoInicio			varchar(20) not null,
	RangoFin			varchar(20) not null,
	Estado				bit not null,
	FechaVencimiento	date not null
)
go


CREATE PROCEDURE spBorrarNumFiscal @NumFiscalID int
as 
	begin
		DELETE FROM PRUEBAS.NumFiscal WHERE NumFiscalID = @NumFiscalID
	end

go

select * from Pruebas.NumFiscal

insert into Pruebas.NumFiscal (NumFiscalID, RangoInicio, RangoFin, Estado, FechaVencimiento) values
(5, '001-005-01-000001', '001-005-01-001000', 'activo', '2026-06-30');

select * from Pruebas.impuesto

go


CREATE OR ALTER PROCEDURE spBorrarRegistro @id int, @tabla varchar(25)
as
	begin
		IF @tabla = 'NumFiscal'
			DELETE FROM PRUEBAS.NumFiscal WHERE NumFiscalID = @NumFiscalID

		IF @tabla = 'Impuesto'
			DELETE FROM Pruebas.Impuesto WHERE ImpuestoID = @id


	end




	

select * from Pruebas.NumFiscal

insert into Pruebas.NumFiscal (NumFiscalID, RangoInicio, RangoFin, Estado, FechaVencimiento) values
(5, '001-005-01-000001', '001-005-01-001000', 'activo', '2026-06-30');


select * from Pruebas.impuesto

insert into Pruebas.Impuesto (ImpuestoID, Nombre, Valor) values
(4, 'Tasa de Seguridad', 1.50);
















