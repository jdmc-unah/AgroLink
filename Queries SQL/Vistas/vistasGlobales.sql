use agrolinkdb



GO

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Socio para ComboBox >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeSocio 
as
	SELECT SocioID, Nombre AS 'Socio'  FROM PRUEBAS.Socio

go

SELECT * FROM vTraeSocio

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Lista de Precios Activas para ComboBox >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeListaPrecios
as
	SELECT ListaPreciosID, Nombre as 'ListPrecios' FROM PRUEBAS.ListaPrecios WHERE Activo = 1

go

SELECT * FROM vTraeListaPrecios






