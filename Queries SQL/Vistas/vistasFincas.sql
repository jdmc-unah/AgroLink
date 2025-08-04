use AgroLinkDB
go
create or alter view vMostrarLotes
as
select pl.CodigoLote ,pf.CodigoFinca,pp.Nombre as 'Producto Sembrado',ptr.nombre as 'Tipo de riego aplicado',pts.NombreComun 'Tipo de suelo',pl.FechaSiembra ,pl.FechaCosecha,pl.Extension from Pruebas.Lote pl inner join pruebas.finca pf on pl.FincaID=pf.FincaID
inner join Pruebas.Producto pp on pl.ProductoID=pp.ProductoID inner join pruebas.TipoRiego ptr on pl.TipoRiegoID=ptr.TipoRiegoID
inner join Pruebas.TipoSuelo pts on pl.TipoSueloID=pts.TipoSueloID
go



