

use AgroLinkDB


go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> vTraeEntrega >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeEntrega
as 
	SELECT E.EntregaID, E.CodigoEntrega,  E.Fecha, S.Nombre as 'Socio',
	S.TipoSocio, SP.CodigoSalida as 'Salida', Emp.Nombre as 'Repartidor', E.SalidaID 

	FROM PRUEBAS.Entrega E
	INNER JOIN PRUEBAS.Socio S ON E.SocioID = S.SocioID
	INNER JOIN PRUEBAS.SalidaProducto  SP ON E.SalidaID = SP.SalidaID
	INNER JOIN PRUEBAS.Empleado Emp ON E.RepartidorID = Emp.EmpleadoID

go

select * from vTraeEntrega
GO
-->>>>>>>>>>>>>>>>>>>>>>>>>>>> vTraeEntrega con Direccion >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeEntregaDir
as 
	SELECT E.EntregaID, E.CodigoEntrega,  E.Fecha, E.SocioID, E.RepartidorID as 'Repartidor', E.SalidaID ,
	M.DepartamentoID, D.MunicipioID, D.Colonia, D.Detalle

	FROM PRUEBAS.Entrega E
	INNER JOIN PRUEBAS.SalidaProducto SP ON E.SalidaID = SP.SalidaID
	INNER JOIN Pruebas.Direccion D on E.DireccionID = D.DireccionID
	INNER JOIN Pruebas.Municipio M on D.MunicipioID = M.MunicipioID

go
select * from vTraeEntregaDir

go
-->>>>>>>>>>>>>>>>>>>>>>>>>>>> vTraeRepartidor con Direccion >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER VIEW vTraeRepartidor
as
	SELECT EmpleadoID , Nombre as 'Repartidor' FROM Pruebas.Empleado where PuestoID = 2

GO


select * from vTraeRepartidor
select * from PRUEBAS.entrega
select * from PRUEBAS.EntregaDetalle

select * from PRUEBAS.bodega
select * from PRUEBAS.Direccion


select * from PRUEBAS.socio


