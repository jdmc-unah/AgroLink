-- CAMBIOS TABLAS TRANSACCIONALES

USE AgroLinkDB
go

--TABLA VENTAS

--ALTER TABLE Pruebas.Venta
--ADD CodigoVenta AS CONCAT('VEN', VentaID) PERSISTED

--ALTER TABLE Pruebas.Venta ADD EmpleadoID INT NULL

--ALTER TABLE Pruebas.Venta
--ADD CONSTRAINT fkVentaEmpleado
--FOREIGN KEY (EmpleadoID)
--REFERENCES Pruebas.Empleado(EmpleadoID)
go

--TABLA COMPRAS

--ALTER TABLE Pruebas.Compra
--ADD CodigoCompra AS concat('COM', CompraID) persisted

--ALTER TABLE Pruebas.Compra ADD EmpleadoID INT NULL

--ALTER TABLE Pruebas.Compra
--ADD CONSTRAINT fkCompraEmpleado
--FOREIGN KEY (EmpleadoID)
--REFERENCES Pruebas.Empleado(EmpleadoID)
go

--TABLA ENTRADA PRODUCTO

--ALTER TABLE Pruebas.EntradaProducto DROP COLUMN SocioID
--ALTER TABLE Pruebas.EntradaProducto ADD CONSTRAINT fkEntradaProductoSocio foreign key (SocioID) references Pruebas.Socio(SocioID)
--ALTER TABLE Pruebas.EntradaProducto ADD SocioID INT NULL

--ALTER TABLE Pruebas.EntradaProducto ADD CompraID INT NULL

--ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!
--UPDATE Pruebas.EntradaProducto SET CompraID = 1 WHERE CompraID IS NULL

--ALTER TABLE Pruebas.EntradaProducto
--ADD CONSTRAINT fkEntradaProductoCompra foreign key (CompraID) references Pruebas.Compra(CompraID)

--ALTER TABLE Pruebas.EntradaProductoDetalle ADD BodegaID INT NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!
--ALTER TABLE Pruebas.EntradaProductoDetalle ADD CONSTRAINT fkEntradaProductoBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)



--TABLA FACTURA

--ALTER TABLE Pruebas.Factura ADD CodigoFactura	as concat('FRA', FacturaID) persisted
--ALTER TABLE Pruebas.Factura ADD VentaID INT NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!
--ALTER TABLE Pruebas.Factura ADD EmpleadoID INT NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!
--ALTER TABLE Pruebas.Factura ADD Estado varchar(50)  NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!

--ALTER TABLE Pruebas.Factura ADD CONSTRAINT chkEstadoFactura check( Estado in('Abierto','Cerrado','Cancelado') )

--ALTER TABLE Pruebas.Factura ADD CONSTRAINT fkFacturaVenta foreign key (VentaID) references Pruebas.Venta(VentaID)

--ALTER TABLE Pruebas.Factura ADD CONSTRAINT fkFacturaEmpleado foreign key (EmpleadoID) references Pruebas.Empleado(EmpleadoID)
go


-- TABLA RECIBO

--ALTER TABLE Pruebas.Recibo
--ADD CodigoRecibo as concat('REC', ReciboID) persisted

--ALTER TABLE Pruebas.Recibo ADD CompraID INT NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!

--ALTER TABLE Pruebas.Recibo ADD EmpleadoID INT NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!

--ALTER TABLE Pruebas.Recibo ADD Estado varchar(50) NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!

--ALTER TABLE Pruebas.Recibo ADD CONSTRAINT chkEstadoRecibo check( Estado in('Abierto','Cerrado','Cancelado') )

--ALTER TABLE Pruebas.Recibo ADD CONSTRAINT fkReciboEmpleado foreign key (EmpleadoID) references Pruebas.Empleado(EmpleadoID)	
go


-- TABLA SALIDA DE PRODUCTO

--ALTER TABLE Pruebas.SalidaProducto ADD VentaID INT NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!
--ALTER TABLE Pruebas.SalidaProducto ADD CONSTRAINT fkSalidaProductoVenta foreign key (VentaID) references Pruebas.Venta(VentaID)


--ALTER TABLE Pruebas.SalidaProducto DROP CONSTRAINT fkSalidaProductoBodega --ELIMINANDO
--ALTER TABLE Pruebas.SalidaProducto DROP COLUMN BodegaID --ELIMINANDO
go


-- TABLA SALIDA DE PRODUCTO DETALLE 

--ALTER TABLE Pruebas.SalidaProductoDetalle ADD BodegaID INT NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!
--ALTER TABLE Pruebas.SalidaProductoDetalle ADD CONSTRAINT fkSalidaProductoDetalleBodega foreign key (BodegaID) references Pruebas.Bodega(BodegaID)
go
--



-->>>>>>>>>CAMBIOS POR CAMPO NUMFISCALID>>>>>>>>>>>>>>>

--EMPRESA
--ALTER TABLE Pruebas.Empresa DROP  CONSTRAINT fkEmpresaNumFiscal 

--ALTER TABLE Pruebas.Empresa DROP COLUMN NumFiscalID

--SELECT * FROM PRUEBAS.Empresa


--NumFiscal

--ALTER TABLE Pruebas.NumFiscal ADD EmpresaID int

--ALTER TABLE Pruebas.NumFiscal ADD constraint fkNumFiscalEmpresa foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID) --se agrego fk de empresa



--Factura
--ALTER TABLE Pruebas.Factura ADD NumFiscalID int 
--ALTER TABLE Pruebas.Factura ADD constraint fkFacturaNumFiscal foreign key (EmpresaID) references Pruebas.Empresa(EmpresaID) --se agrego fk de numfiscal


--sp_help 'Pruebas.Factura'


GO


--CUESTIONES EXTRAS

--ALTER TABLE Pruebas.SalidaProducto ADD VentaID INT NULL --ESTO SE DEBE CAMBIAR A NOT NULL LUEGO !!!!!
--ALTER TABLE Pruebas.SalidaProducto ADD CONSTRAINT fkSalidaProductoVenta foreign key (VentaID) references Pruebas.Venta(VentaID)
--ALTER TABLE Pruebas.SalidaProducto DROP CONSTRAINT fkSalidaProductoBodega --ELIMINANDO
--ALTER TABLE Pruebas.SalidaProducto DROP COLUMN BodegaID --ELIMINANDO
--ALTER TABLE Pruebas.Recibo ADD CONSTRAINT fkFacturaEmpleado foreign key (EmpleadoID) references Pruebas.Empleado(EmpleadoID)	
--ALTER TABLE Pruebas.EntradaProducto DROP CONSTRAINT fkEntradaProductoBodega
--ALTER TABLE Pruebas.EntradaProducto DROP COLUMN BodegaID
--ALTER TABLE Pruebas.EntradaProducto ALTER COLUMN CompraID INT not null
--SELECT * FROM Pruebas.Compra
--SELECT * FROM Pruebas.Lote
--SELECT * FROM Pruebas.SalidaProducto WHERE CompraID IS NULL


