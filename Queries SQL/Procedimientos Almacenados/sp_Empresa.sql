
--Procedimientos Almacenados Modulo Empresa

use AgroLinkDB

go
------------------Notas---------------------
-->>
------------------------------------------------------



select * from Pruebas.NumFiscal

insert into Pruebas.NumFiscal (NumFiscalID, RangoInicio, RangoFin, Estado, FechaVencimiento) values
(5, '001-005-01-000001', '001-005-01-001000', 'activo', '2026-06-30');


select * from Pruebas.impuesto

insert into Pruebas.Impuesto (ImpuestoID, Nombre, Valor) values
(4, 'Tasa de Seguridad', 1.50);
















