create or alter view vPantallaListaPrecio as
select
    lp.ListaPreciosID as ID,
    lp.Nombre,
    case when lp.activo = 1 then 'si' else 'no' end as Activo
from pruebas.listaprecios lp;
go
