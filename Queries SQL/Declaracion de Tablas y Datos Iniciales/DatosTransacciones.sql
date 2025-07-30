

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

INSERT INTO PRUEBAS.Compra ( ListaPreciosID, Fecha, SocioID, TipoPago, Estado)VALUES
--Compra 1
( 6, '2025/07/07', 6, 'Credito', 'Cerrado'), --Compra a Socio 6 
--Compra 2
( 6, '2025/07/07', 2, 'Contado', 'Cerrado'),

--Compra 3
( 6, '2025/07/07', 6, 'Credito', 'Cerrado'),

--Compra 4
( 6, '2025/07/07', 2, 'Contado', 'Cerrado'),

--Compra 5 (Esta no se ve reflejada en inventario bodega porque se uso para hacer los datos de venta, entonces asi como entro el producto se vendio)
(6, '2025/07/07', 1, 'Credito', 'Cerrado')


INSERT INTO PRUEBAS.CompraDetalle (CompraID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES 
--Compra Detalle 1
(1, 1, 1, 1, 10, 85,977.5),  --Semilla Tomate 
(1, 2, 1, 2, 10, 65, 747.5 ), --Semilla Lechuga 

--Compra Detalle 2
(2, 3, 1, 3, 45, 750, 38812.5 ),	--Fertilizante
(2, 4, 1, 4, 35, 680, 27370 ),		--Urea

--Compra Detalle 3
(3, 1, 1, 1, 15, 85, 1466.25),	--Semilla Tomate 
(3, 2, 1, 2, 10, 65, 747.5 ),	--Semilla Lechuga 

--Compra Detalle 4
(4, 5, 1, 5, 15, 180, 3105 ),	--Insecticida

--Compra Detalle 5
(5,11 , 1, 1, 30, 25, 862.5 ),	--Tomate
(5,14 , 1, 1, 5, 850, 4887.5 )	--Frijol Rojo



SELECT * FROM PRUEBAS.COMPRA c
inner join pruebas.CompraDetalle cd on c.CompraID = cd.CompraID


-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Recibo >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

INSERT INTO Pruebas.Recibo (CompraID, ListaPreciosID, SocioID, MetodoPago, Fecha, EmpleadoID, Estado) VALUES
--Recibo Compra 1
(1, 6, 6, 'Tarjeta', '2025/07/07', 1 , 'Cerrado'),

--Recibo Compra 2
(2, 6, 2, 'Tarjeta', '2025/07/07', 1 , 'Cerrado'),

--Recibo Compra 3
(3, 6, 6, 'Tarjeta', '2025/07/07', 1 , 'Cerrado'),

--Recibo Compra 4
(4, 6, 2, 'Tarjeta', '2025/07/07', 1 , 'Cerrado'),

--Recibo Compra 5
(5, 6, 1, 'Cheque', '2025/07/10', 1 , 'Cerrado')


INSERT INTO Pruebas.ReciboDetalle (ReciboID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES
--Recibo Detalle Compra  1
(1, 1, 1, 1, 10, 85,977.5),  --Semilla Tomate 
(1, 2, 1, 2, 10, 65, 747.5 ), --Semilla Lechuga 

--Recibo Detalle Compra 2
(2, 3, 1, 3, 45, 750, 38812.5 ),	--Fertilizante
(2, 4, 1, 4, 35, 680, 27370 ),		--Urea

--Recibo Detalle Compra 3
(3, 1, 1, 1, 15, 85, 1466.25),	--Semilla Tomate 
(3, 2, 1, 2, 10, 65, 747.5 ),	--Semilla Lechuga 

--Recibo Detalle Compra 4
(4, 5, 1, 5, 15, 180, 3105 ),	--Insecticida

--Recibo Detalle Compra 5
(5,11 , 1, 1, 30, 25, 862.5 ),	--Tomate
(5,14 , 1, 1, 5, 850, 4887.5 )	--Frijol Rojo



SELECT * FROM PRUEBAS.Recibo r
inner join pruebas.ReciboDetalle rd on r.ReciboID = rd.ReciboID



-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Entrada Producto >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


INSERT INTO Pruebas.EntradaProducto ( SocioID, Fecha, LoteID, CompraID) VALUES
--Entrada de compra 1
( 6, '2025/07/07', NULL, 1),

--Entrada de Compra 2
( 2, '2025/07/07', NULL, 2),

--Entrada de Compra 3
( 6, '2025/07/07', NULL, 3 ),	

--Entrada de Compra 4
( 2, '2025/07/07', NULL, 4 ), 

--Entrada de Compra 5
( 1, '2025/07/08', 1 , 5 )	


INSERT INTO Pruebas.EntradaProductoDetalle (EntradaID, ProductoID, Cantidad, BodegaID) VALUES
--Entrada detalle de compra 1
(1, 1, 10, 1),	--Semilla Tomate
(1, 2, 10, 2),	--Semilla Lechuga

--Entrada detalle de compra 2
(2, 3, 45 , 3), --Fertilizante
(2, 4, 35 , 4),	--Urea

--Entrada detalle de compra 3
(3, 1, 15, 1),	--Semilla Tomate
(3, 2, 10, 2),	--Semilla Lechuga

--Entrada detalle de compra 4
(4, 5, 15, 5),	--Insecticida

--Entrada detalle de compra 5
(5,11, 30, 1),	--Tomate
(5,14, 5, 1)	--Frijol Rojo



select * from pruebas.EntradaProducto e 
inner join pruebas.EntradaProductoDetalle ed on e.EntradaID = ed.EntradaID



-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Venta  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


INSERT INTO PRUEBAS.Venta ( Fecha, SocioID, ListaPreciosID, TipoPago, Estado) VALUES
--VENTA 1
( '2025/07/09', 4, 1, 'Contado', 'Cerrado' ),

--Venta 2
( '2025/07/09', 8, 1, 'Contado', 'Cerrado' ),

--VENTA 3
( '2025/07/09', 4, 1, 'Contado', 'Cerrado' )


INSERT INTO PRUEBAS.VentaDetalle (VentaID, ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES

--VENTA DETALLE 1
(1, 11, 1, 1, 15, 25, 431.25),	--tomate
(1, 14, 1, 1, 2, 850 , 1955),	--frijol rojo

--VENTA DETALLE 2
(2, 11, 1, 1, 15, 25, 431.25),	--tomate

--VENTA DETALLE 3
(3, 14, 1, 1, 3, 850 , 2932.5)	--frijol rojo



select * from pruebas.Venta v 
inner join pruebas.VentaDetalle vd on v.VentaID = vd.VentaID


-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Factura  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

--Factura Venta 1
INSERT INTO Pruebas.Factura ( VentaID,SocioID, ListaPreciosID, EmpresaID, Fecha, MetodoPago, CAI, EmpleadoID, Estado, NumFiscalID) VALUES

--Factura Venta 1
(1, 4, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000001', 1, 'Cerrado', 1),

--Factura Venta 2
(2, 8, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000002', 1, 'Cerrado', 1),

--Factura Venta 3
(3, 4, 1,1, '2025/07/09', 'Tarjeta', '001-001-01-000003', 1, 'Cerrado', 1)

INSERT INTO PRUEBAS.FacturaDetalle ( FacturaID,ProductoID, ImpuestoID, BodegaID, Cantidad, Precio, Total) VALUES

--Factura Detalle Venta 1
(1, 11, 1, 1, 15, 25, 431.25),	--tomate
(1, 14, 1, 1, 2, 850 , 1955),	--frijol rojo

--Factura Detalle Venta 2
(2, 11, 1, 1, 15, 25, 431.25),	--tomate

--Factura Detalle Venta 3
(3, 14, 1, 1, 3, 850 , 2932.5)	--frijol rojo



select * from pruebas.Factura f inner join pruebas.FacturaDetalle fd on f.FacturaID = fd.FacturaID



-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Salida de Producto  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


INSERT INTO Pruebas.SalidaProducto (VentaID, SocioID, Fecha) VALUES
--Salida de Venta 1
(1, 4, '2025/07/09' ),	--Salida de producto 11
--Salida de Venta 2
(2, 8, '2025/07/09' ),	--Salida de producto 11

--Salida de Venta 3
(3, 4, '2025/07/09' )	--Salida de producto 14

INSERT INTO Pruebas.SalidaProductoDetalle (SalidaID, ProductoID, Cantidad, BodegaID) VALUES
--Salida Detalle de Venta 1
(1,11, 15, 1), --Tomate
(1,14, 2 , 1),	--Frijol Rojo

--Salida Detalle de Venta 2
(2,11, 15,1), --Tomate

--Salida Detalle de Venta 3
(3, 14, 3, 1)	--Frijol Rojo



select * from pruebas.SalidaProducto s 
inner join pruebas.SalidaProductoDetalle sd on s.SalidaID = sd.SalidaID

select * from pruebas.SalidaProductoDetalle


go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Entrega  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


INSERT INTO pruebas.Entrega (VentaID, SocioID, Fecha , DireccionID, RepartidorID) VALUES
--entrega 1 basada en salida 1
(1, 4, '2025/07/09',7 , 2),

--entrega 2 basada en salida 2
(2, 8, '2025/07/09' ,11, 3),

--entrega 3 basada en salida 3
(3, 4, '2025/07/09' , 7 , 2)

go
select * from pruebas.Entrega
go
-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Entrega Detalle  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

INSERT INTO pruebas.EntregaDetalle (EntregaID, ProductoID, Cantidad) VALUES
--Entrega Detalle 1
(1,11, 15), --Tomate
(1,14, 2 ),	--Frijol Rojo

--Entrega Detalle 2
(2,11, 15), --Tomate

--Entrega Detalle 3
(3, 14, 3)	--Frijol Rojo

go
select * from pruebas.Entrega e
inner join pruebas.Entregadetalle ed on e.EntregaID = ed.EntregaID

go
-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

