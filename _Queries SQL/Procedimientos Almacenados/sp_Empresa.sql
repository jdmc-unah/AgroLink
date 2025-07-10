
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



select * from 

insert into Pruebas.NumFiscal (NumFiscalID, RangoInicio, RangoFin, Estado, FechaVencimiento) values
(5, '001-005-01-000001', '001-005-01-001000', 'activo', '2026-06-30');























