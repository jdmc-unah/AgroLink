
USE AgroLinkDB
go



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda por Codigo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarSalidaProd @cod varchar(10)
as
	BEGIN 
		SELECT * FROM vTraeSalidaProducto WHERE CodigoSalida LIKE '%' + @cod + '%' or Socio like '%' + @cod + '%'
	END

go




