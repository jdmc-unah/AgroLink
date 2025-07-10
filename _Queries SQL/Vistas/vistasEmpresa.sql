
use AgroLinkDB
GO

------------------Notas---------------------
-->>La tabla de rtn tiene que ir aparte de la de empresa, no tiene sentido que vaya el 
	--numfiscalid en empresa ya que se tendrian que hacer variiass entradas de lo mismo

------------------------------------------------------


-- Trae datos de empresa

CREATE OR ALTER VIEW vDatosEmpresa 
as
	SELECT E.Nombre, E.RTN, E.Correo, E.Telefono , 
	D.Departamento, D.Municipio, D.Colonia, D.Detalle
	FROM Pruebas.Empresa E
	INNER JOIN ( SELECT * FROM Pruebas.Direccion WHERE DireccionID = 1) D on E.DireccionID = D.DireccionID

go

select * from vDatosEmpresa

GO


--Trae Numeros Fiscales
CREATE OR ALTER VIEW vNumerosFiscales
as
	SELECT * FROM Pruebas.NumFiscal


go

SELECT * FROM vNumerosFiscales

go