use AgroLinkDB

create or alter view vTraerSiembra
as
select ProductoID,pp.Nombre as ProductoSiembra from Pruebas.Producto pp inner join pruebas.TipoProducto ptp on pp.TipoID=ptp.TipoID where NombreTipo in('Granos Básicos','Semillas Certificadas','Hortalizas','Frutas Tropicales')


select * from pruebas.Lote