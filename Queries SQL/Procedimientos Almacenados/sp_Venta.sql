use agrolinkdb



go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda por Codigo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarVenta @cod varchar(10)
as
	BEGIN 
		SELECT * FROM vTraeVentas WHERE CodigoVenta LIKE '%' + @cod + '%' or Socio like '%' + @cod + '%'
	END

go










