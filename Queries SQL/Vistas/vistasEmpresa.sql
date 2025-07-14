
use AgroLinkDB
GO

------------------Notas---------------------
-->>La tabla de rtn tiene que ir aparte de la de empresa, no tiene sentido que vaya el 
	--numfiscalid en empresa ya que se tendrian que hacer variiass entradas de lo mismo

------------------------------------------------------


-- Trae datos de empresa

CREATE OR ALTER VIEW vDatosEmpresa 
as
	SELECT E.Nombre, E.RTN, E.Correo, E.Telefono  
	--D.DepartamentoID, D.MunicipioID, D.Colonia, D.Detalle
	FROM Pruebas.Empresa E
	--INNER JOIN ( SELECT * FROM Pruebas.Direccion WHERE DireccionID = 1) D on E.DireccionID = D.DireccionID

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


--Trae Impuesto
CREATE OR ALTER VIEW vImpuesto
as
	SELECT * FROM Pruebas.Impuesto


go

SELECT * FROM vImpuesto

go


--Trae Direccion
CREATE OR ALTER VIEW vDireccionEmpresa
as

	SELECT Dir.Detalle, Dir.Colonia ,Mun.Nombre as 'Municipio', Dep.Nombre 'Departamento' FROM Pruebas.Direccion Dir 
	INNER JOIN Pruebas.Municipio Mun on Dir.MunicipioID = Mun.MunicipioID
	INNER JOIN Pruebas.Departamento Dep on Mun.DepartamentoID = Dep.DepartamentoID  
	WHERE Dir.DireccionID = 1

go

SELECT * FROM vImpuesto

go