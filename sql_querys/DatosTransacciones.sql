

-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Cambios >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

--Se agrego lista de precio al costo para compras
INSERT INTO Pruebas.ListaPrecios VALUES (6, 'Costo', 1) 

--se agrega como consumidor La Colonia ya que solo habia uno
insert into pruebas.Socio (SocioID, Nombre, TipoSocio, Identidad, RTN, Correo, Telefono, DireccionID, Notas)  values 
(8, 'Supermercado La Colonia', 'Consumidor', '0501200012345','05012000123455', 'info@lacolonia.com', '2251-6352',11 , 'Supermercado La Colonia'  )

--direccion de nuevo consumidor
insert into pruebas.Direccion values (11, 'Cortés', 'San Pedro Sula', 'Segundo Anillo', '20 Calle SE')

--Se agrego la fecha en salida producto
alter table Pruebas.SalidaProducto add Fecha datetime not null


-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Compra>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>					

--Compra 1
INSERT INTO PRUEBAS.Compra (CompraID, ListaPreciosID, Fecha, SocioID, TipoPago, Estado)
VALUES (1, 6, '2025/07/07', 6, 'Credito', 'Cerrado') --Compra a Socio 6 

INSERT INTO PRUEBAS.CompraDetalle (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES 
(1, 1, 1, 1, 10, 85,977.5),  --Semilla Tomate 
(1, 2, 1, 2, 10, 65, 747.5 ) --Semilla Lechuga 


--Compra 2
INSERT INTO PRUEBAS.Compra (CompraID, ListaPreciosID, Fecha, SocioID, TipoPago, Estado)  VALUES 
(2, 6, '2025/07/07', 2, 'Contado', 'Cerrado')

INSERT INTO PRUEBAS.CompraDetalle  (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES 
(2, 3, 1, 3, 45, 750, 38812.5 ),	--Fertilizante
(2, 4, 1, 4, 35, 680, 27370 )		--Urea


--Compra 3
INSERT INTO PRUEBAS.Compra (CompraID, ListaPreciosID, Fecha, SocioID, TipoPago, Estado) VALUES 
(3, 6, '2025/07/07', 6, 'Credito', 'Cerrado')
INSERT INTO PRUEBAS.CompraDetalle   (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES 
(3, 1, 1, 1, 15, 85, 1466.25),	--Semilla Tomate 
(3, 2, 1, 2, 10, 65, 747.5 )	--Semilla Lechuga 


--Compra 4
INSERT INTO PRUEBAS.Compra (CompraID, ListaPreciosID, Fecha, SocioID, TipoPago, Estado) VALUES 
(4, 6, '2025/07/07', 2, 'Contado', 'Cerrado')
INSERT INTO PRUEBAS.CompraDetalle  (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES 
(4, 5, 1, 5, 15, 180, 3105 )	--Insecticida


--Compra 5 (Esta no se ve reflejada en inventario bodega porque se uso para hacer los datos de venta, entonces asi como entro el producto se vendio)
INSERT INTO PRUEBAS.Compra (CompraID, ListaPreciosID, Fecha, SocioID, TipoPago, Estado) VALUES 
(5, 6, '2025/07/07', 1, 'Credito', 'Cerrado')
INSERT INTO PRUEBAS.CompraDetalle  (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES 
(5,11 , 1, 1, 30, 25, 862.5 ),	--Tomate
(5,14 , 1, 1, 5, 850, 4887.5 )	--Frijol Rojo


SELECT * FROM PRUEBAS.COMPRA c
inner join pruebas.CompraDetalle cd on c.CompraID = cd.CompraID


-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Recibo >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


--Recibo Compra 1
INSERT INTO Pruebas.Recibo (ReciboID, ListaPreciosID, SocioID, MetodoPago, Fecha) VALUES
(1, 6, 6, 'Tarjeta', '2025/07/07')

INSERT INTO Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(1, 1, 1, 1, 10, 85,977.5),  --Semilla Tomate 
(1, 2, 1, 2, 10, 65, 747.5 ) --Semilla Lechuga 


--Recibo Compra 2
INSERT INTO Pruebas.Recibo (ReciboID, ListaPreciosID, SocioID, MetodoPago, Fecha) VALUES
(2, 6, 2, 'Tarjeta', '2025/07/07')

INSERT INTO Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(2, 3, 1, 3, 45, 750, 38812.5 ),	--Fertilizante
(2, 4, 1, 4, 35, 680, 27370 )		--Urea


--Recibo Compra 3
INSERT INTO Pruebas.Recibo (ReciboID, ListaPreciosID, SocioID, MetodoPago, Fecha) VALUES
(3, 6, 6, 'Tarjeta', '2025/07/07')

INSERT INTO Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(3, 1, 1, 1, 15, 85, 1466.25),	--Semilla Tomate 
(3, 2, 1, 2, 10, 65, 747.5 )	--Semilla Lechuga 


--Recibo Compra 4
INSERT INTO Pruebas.Recibo (ReciboID, ListaPreciosID, SocioID, MetodoPago, Fecha) VALUES
(4, 6, 2, 'Tarjeta', '2025/07/07')

INSERT INTO Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(4, 5, 1, 5, 15, 180, 3105 )	--Insecticida



--Recibo Compra 5
INSERT INTO Pruebas.Recibo (ReciboID, ListaPreciosID, SocioID, MetodoPago, Fecha) VALUES
(5, 6, 1, 'Cheque', '2025/07/10')

INSERT INTO Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(5,11 , 1, 1, 30, 25, 862.5 ),	--Tomate
(5,14 , 1, 1, 5, 850, 4887.5 )	--Frijol Rojo



SELECT * FROM PRUEBAS.Recibo r
inner join pruebas.ReciboDetalle rd on r.ReciboID = rd.ReciboID



-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Entrada Producto >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

--Entrada de compra 1
INSERT INTO Pruebas.EntradaProducto (EntradaID, SocioID, BodegaID, Fecha, LoteID) VALUES
(1, 6, 1, '2025/07/07', NULL),	--Entrada de producto 1
(2, 6, 2, '2025/07/07', NULL)	--Entrada de producto 2

INSERT INTO Pruebas.EntradaProductoDetalle (EntradaID, ProductoID, Cantidad) VALUES
(1, 1, 10), --Semilla Tomate
(2, 2, 10)	--Semilla Lechuga


--Entrada de Compra 2
INSERT INTO Pruebas.EntradaProducto (EntradaID, SocioID, BodegaID, Fecha, LoteID) VALUES
(3, 2, 3, '2025/07/07', NULL),	--Entrada de producto 3
(4, 2, 4, '2025/07/07', NULL)	--Entrada de producto 4

INSERT INTO Pruebas.EntradaProductoDetalle (EntradaID, ProductoID, Cantidad) VALUES
(3, 3, 45), --Fertilizante
(4, 4, 35)	--Urea


--Entrada de Compra 3
INSERT INTO Pruebas.EntradaProducto (EntradaID, SocioID, BodegaID, Fecha, LoteID) VALUES
(5, 6, 1, '2025/07/07', NULL),	--Entrada de producto 1
(6, 6, 2, '2025/07/07', NULL)	--Entrada de producto 2

INSERT INTO Pruebas.EntradaProductoDetalle (EntradaID, ProductoID, Cantidad) VALUES
(5, 1, 15), --Semilla Tomate
(6, 2, 10)	--Semilla Lechuga


--Entrada de Compra 4
INSERT INTO Pruebas.EntradaProducto (EntradaID, SocioID, BodegaID, Fecha, LoteID) VALUES
(7, 2, 5, '2025/07/07', NULL) --Entrada de producto 5

INSERT INTO Pruebas.EntradaProductoDetalle (EntradaID, ProductoID, Cantidad) VALUES
(7, 5, 15) --Insecticida

		
--Entrada de Compra 5
INSERT INTO Pruebas.EntradaProducto (EntradaID, SocioID, BodegaID, Fecha, LoteID) VALUES
(8, 1, 1, '2025/07/08', 1  ),	--Entrada de producto 11
(9, 1, 1, '2025/07/08', 6  )	--Entrada de producto 14

INSERT INTO Pruebas.EntradaProductoDetalle (EntradaID, ProductoID, Cantidad) VALUES
(8,11, 30), --Tomate
(9,14, 5)	--Frijol Rojo



select * from pruebas.EntradaProducto e 
inner join pruebas.EntradaProductoDetalle ed on e.EntradaID = ed.EntradaID



-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Venta  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

--VENTA 1
INSERT INTO PRUEBAS.Venta (VentaID, Fecha, SocioID, ListaPreciosID, TipoPago, Estado) VALUES
(1, '2025/07/09', 4, 1, 'Contado', 'Cerrado' )

INSERT INTO PRUEBAS.VentaDetalle (VentaID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(1, 11, 1, 1, 15, 25, 431.25),	--tomate
(1, 14, 1, 1, 2, 850 , 1955)	--frijol rojo


--Venta 2
INSERT INTO PRUEBAS.Venta (VentaID, Fecha, SocioID, ListaPreciosID, TipoPago, Estado) VALUES
(2, '2025/07/09', 8, 1, 'Contado', 'Cerrado' )

INSERT INTO PRUEBAS.VentaDetalle (VentaID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(2, 11, 1, 1, 15, 25, 431.25)	--tomate


--VENTA 3
INSERT INTO PRUEBAS.Venta (VentaID, Fecha, SocioID, ListaPreciosID, TipoPago, Estado) VALUES
(3, '2025/07/09', 4, 1, 'Contado', 'Cerrado' )

INSERT INTO PRUEBAS.VentaDetalle (VentaID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(3, 14, 1, 1, 3, 850 , 2932.5)	--frijol rojo



select * from pruebas.Venta v 
inner join pruebas.VentaDetalle vd on v.VentaID = vd.VentaID


-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Factura  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

--Factura Venta 1
INSERT INTO Pruebas.Factura (FacturaID, SocioID, ListaPreciosID, EmpresaID, Fecha, MetodoPago, CAI) VALUES
(1, 4, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000001')

INSERT INTO PRUEBAS.FacturaDetalle (FacturaID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(1, 11, 1, 1, 15, 25, 431.25),	--tomate
(1, 14, 1, 1, 2, 850 , 1955)	--frijol rojo



--Factura Venta 2
INSERT INTO Pruebas.Factura (FacturaID, SocioID, ListaPreciosID, EmpresaID, Fecha, MetodoPago, CAI) VALUES
(2, 8, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000002')

INSERT INTO PRUEBAS.FacturaDetalle (FacturaID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(2, 11, 1, 1, 15, 25, 431.25)	--tomate


--Factura Venta 3
INSERT INTO Pruebas.Factura (FacturaID, SocioID, ListaPreciosID, EmpresaID, Fecha, MetodoPago, CAI) VALUES
(3, 4, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000003')

INSERT INTO PRUEBAS.FacturaDetalle (FacturaID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
(3, 14, 1, 1, 3, 850 , 2932.5)	--frijol rojo



select * from pruebas.Factura f inner join pruebas.FacturaDetalle fd on f.FacturaID = fd.FacturaID



-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Salida de Producto  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


--Salida de Venta 1
INSERT INTO Pruebas.SalidaProducto (SalidaID, SocioID, BodegaID, Fecha) VALUES
(1, 4, 1, '2025/07/09' ),	--Salida de producto 11
(2, 4, 1, '2025/07/09' )	--Salida de producto 14

INSERT INTO Pruebas.SalidaProductoDetalle (SalidaID, ProductoID, Cantidad) VALUES
(1,11, 15), --Tomate
(2,14, 2)	--Frijol Rojo

	
--Salida de Venta 2
INSERT INTO Pruebas.SalidaProducto (SalidaID, SocioID, BodegaID, Fecha) VALUES
(3, 8, 1, '2025/07/09' )	--Salida de producto 11

INSERT INTO Pruebas.SalidaProductoDetalle (SalidaID, ProductoID, Cantidad) VALUES
(3,11, 15) --Tomate


--Salida de Venta 3
INSERT INTO Pruebas.SalidaProducto (SalidaID, SocioID, BodegaID, Fecha) VALUES
(4, 4, 1, '2025/07/09' )	--Salida de producto 14

INSERT INTO Pruebas.SalidaProductoDetalle (SalidaID, ProductoID, Cantidad) VALUES
(4, 14, 3)	--Frijol Rojo




select * from pruebas.SalidaProducto s 
inner join pruebas.SalidaProductoDetalle sd on s.SalidaID = sd.SalidaID





-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

