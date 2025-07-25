use agrolinkdb



GO

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Socio para ComboBox >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeSocio 
as
	SELECT SocioID, Nombre AS 'Socio'  FROM PRUEBAS.Socio

go

SELECT * FROM vTraeSocio
go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Lista de Precios Activas para ComboBox >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeListaPrecios
as
	SELECT ListaPreciosID, Nombre as 'ListPrecios' FROM PRUEBAS.ListaPrecios WHERE Activo = 1

go

SELECT * FROM vTraeListaPrecios
go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Lista Productos para ComboBox >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeProductos
as
	SELECT ProductoID, Nombre as 'Producto' FROM PRUEBAS.Producto 
go

SELECT * FROM vTraeProductos

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Lista Bodegas para ComboBox >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeBodega
as
	SELECT BodegaID, Nombre as 'Bodega' FROM PRUEBAS.Bodega 
go

SELECT * FROM vTraeBodega

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Impuestos para ComboBox >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeImpuesto
as
	SELECT ImpuestoID, Valor as 'Impuesto' FROM PRUEBAS.Impuesto 
go

SELECT * FROM vTraeImpuesto


go-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae NumFiscalID para ComboBox >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeNumFiscal
as
	SELECT NumFiscalID FROM PRUEBAS.NumFiscal
go

SELECT * FROM vTraeNumFiscal

