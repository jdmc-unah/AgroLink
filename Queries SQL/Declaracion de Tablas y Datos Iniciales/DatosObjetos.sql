USE AgroLinkDB;

-- 1. direcciones

insert into Pruebas.Direccion ( MunicipioID, Colonia, Detalle) values
(501, 'Colonia Universidad', 'Boulevard Los Próceres #1234'),
(501, 'Barrio Río de Piedras', 'Ave. Circunvalación #5678'),
(501, 'Colonia Moderna', '10a Calle, 15 Ave. SO #91'),
(502, 'Centro', 'Calle Principal, frente al parque central'),  --se volvieron a insertar por el cambio en tabla direccion
(506, 'Barrio El Centro', 'Ave. Honduras #321'),
(511, 'Colonia San José', 'Carretera CA-5 Km 15'),
(512, 'Barrio El Progreso', 'Ave. La Lima #789'),
(504, 'Aldea San Antonio', 'Desvío La Barca Km 3'),
(503, 'Casco Histórico', 'Calle del Comercio #456'),
(510, 'El Paraíso', 'Orilla del Lago de Yojoa'),
(501, 'Segundo Anillo', '20 Calle SE')

--(2, 'Francisco Morazán', 'Tegucigalpa', 'Colonia Kennedy', 'Blvd. Morazán, Casa #123'),
--(3, 'Yoro', 'El Progreso', 'Centro', 'Calle Principal #789'),
--(4, 'Choluteca', 'Choluteca', 'Barrio El Centro', 'Ave. Valle #321'),
--(5, 'Comayagua', 'Comayagua', 'Barrio La Merced', 'Calle Real #654'),
--(6, 'Atlántida', 'La Ceiba', 'Colonia El Sauce', 'Ave. San Isidro #987'),
--(7, 'Yoro', 'Yoro', 'El Porvenir', 'Carretera a Olanchito Km 5'),
--(8, 'Santa Bárbara', 'Santa Bárbara', 'Las Flores', 'Entrada Principal'),
--(9, 'Copán', 'Santa Rosa de Copán', 'Centro', 'Parque Central, Edificio #2'),
--(10, 'Intibucá', 'La Esperanza', 'Barrio Buenos Aires', 'Calle Los Pinos #445');


select * from Pruebas.Direccion
delete from Pruebas.Direccion

-- 2. nuemros fiscales
insert into Pruebas.NumFiscal ( RangoInicio, RangoFin, Estado, FechaVencimiento, EmpresaID) values
('001-001-01-000001', '001-001-01-001000', 'activo', '2025-12-31', 1),
('001-002-01-000001', '001-002-01-001000', 'activo', '2025-11-30', 1),
('001-003-01-000001', '001-003-01-001000', 'activo', '2025-10-31', 1),
('001-004-01-000001', '001-004-01-001000', 'inactivo', '2024-12-31', 1),
('001-005-01-000001', '001-005-01-001000', 'activo', '2026-06-30', 1);

select * from Pruebas.NumFiscal 
delete from Pruebas.NumFiscal 

-- 3. impuestos

insert into Pruebas.Impuesto (Nombre, Valor) values
('ISV', 0.15),
('Impuesto sobre la Renta', 0.25),
('Impuesto Municipal', 0.2),
('Tasa de Seguridad', 0.015);

select * from Pruebas.Impuesto 
delete from Pruebas.Impuesto 


-- 4. lista de precios
insert into Pruebas.ListaPrecios ( Nombre, Activo) values
('Precios Mayorista', 1),
('Precios Minorista', 1),
('Precios Socios Especiales', 1),
('Precios Temporada Alta', 1),
('Precios Promocionales', 1),
('Precio de Costo', 1)

select * from Pruebas.ListaPrecios 
delete from Pruebas.ListaPrecios 


-- 5. tipo de riego
insert into Pruebas.TipoRiego ( Nombre, Descripcion) values
('Riego por Goteo', 'Se suministra agua directamente a las raíces de las plantas.'),
('Riego por Aspersión', 'Utiliza aspersores para distribuir el agua en el terreno.'),
('Riego por exudación', 'El agua se libera lentamente a través de tubos porosos.'),
('Riego por Microaspersión', 'Sistema de riego localizado con microaspersores de bajo caudal'),
('Riego por superficie o inundación', 'Se aplica agua directamente sobre el suelo.'),
('Riego Manual', 'Riego realizado manualmente con mangueras o regaderas');

select * from Pruebas.TipoRiego 
delete from Pruebas.TipoRiego

-- 6. empresa
insert into Pruebas.Empresa ( Nombre, RTN, Correo, Telefono, DireccionID, NumFiscalID) values
( 'Comercializadora de Productos Agricolas', '05019999123456', 'info@agrolink.hn', '2550-1234', 1, 1);

select * from Pruebas.Empresa 
delete from Pruebas.Empresa

-- 7. usuario
insert into Pruebas.Usuario ( Usuario, Clave, Nombre, TipoUsuario) values
('admin', 'admin123', 'Admin Agrolink', 'Administrador'),
('jose.mejia', '111', 'Jose Daniel Mejia', 'Estandar'),
('kisha.mejia', '111', 'Kisha Mejia', 'Estandar'),
('josue.varela', '111', 'Josue Varela', 'Estandar'),
('arleth.oseguera', '111', 'Arleth Oseguera', 'Estandar');

select * from Pruebas.Usuario 
delete from Pruebas.Usuario

-- 8. socio
insert into Pruebas.Socio ( Nombre, TipoSocio, Identidad, RTN, Correo, Telefono, DireccionID, Notas, Saldo) values
('José Manuel Flores', 'Agricultor', '0502199812345', '05021998123456', 'joseflores@email.com', '9876-5432', 4, 'Productor de plátano en Choloma',0),
('Agrosuministros S.A.', 'Proveedor', '0501199923456', '05011999234567', 'ventas@agroceiba.hn', '2557-6789', 5, 'Distribuidor de fertilizantes', 0),
('Carmen Elena Mejía', 'Agricultor', '0511198734567', '05011987345678', 'carmenmejia@email.com', '8765-4321', 6, 'Productora orgánica en Villanueva', 0),
('Supermercados Del Norte', 'Consumidor', '0501199845678', '05011998456789', 'compras@delnorte.hn', '2558-7890', 7, 'Cadena regional de supermercados', 0),
('Roberto Alvarado', 'Agricultor', '0512199056789', '05121990567890', 'roberto.alvarado@email.com', '9654-3210', 8, 'Especialista en hortalizas', 0),
('Insumos Agrícolas', 'Proveedor', '0501199167890', '05011991678901', 'info@insumoscortes.hn', '2559-8901', 9, 'Proveedor de semillas certificadas', 0),
('Ana Sofía Castillo', 'Agricultor', '0510198978901', '05101989789012', 'ana.castillo@email.com', '9543-2109', 10, 'Cultivos de exportación Lago Yojoa' , 0),
('Supermercado La Colonia', 'Consumidor', '0501200012345','05012000123455', 'info@lacolonia.com', '2251-6352',11 , 'Supermercado La Colonia', 0  )

select * from Pruebas.Socio 
delete from Pruebas.Socio



-- 9. finca
insert into Pruebas.Finca ( SocioID, Nombre, DireccionID, CapacidadAgua) values
(1, 'Finca San José', 4, 'Alta'),
(3, 'Finca Orgánica', 6, 'Media'),
(5, 'Finca El Paraíso', 7, 'Alta'),
(7, 'Finca Lago Verde', 10, 'Alta'),
(1, 'Finca Los Plátanos', 4, 'Media');


select * from Pruebas.Finca 
delete from Pruebas.Finca

-- 10. tipo de producto
insert into Pruebas.TipoProducto (NombreTipo, Categoria) values
('Semillas Certificadas', 'Insumo'),
('Fertilizantes', 'Insumo'),
('Agroquímicos', 'Insumo'),
('Frutas Tropicales', 'Producto Agricola'),
('Hortalizas', 'Producto Agricola'),
('Granos Básicos', 'Producto Agricola'),
('Herramientas', 'Insumo'),
('Cultivos Exportación', 'Producto Agricola');

select * from Pruebas.TipoProducto 
delete from Pruebas.TipoProducto



-- 11. unidad de medida
insert into Pruebas.UnidadMedida (Nombre, Abreviacion) values
('Kilogramo', 'kg'),
('Libra', 'lb'),
('Quintal', 'q'),
('Litro', 'lts'),
('Galón', 'gal'),
('Saco', 'saco'),
('Caja', 'caja'),
('Unidad', 'ud'),
('Metro', 'm'),
('Tonelada', 't');

select * from Pruebas.UnidadMedida 
delete from Pruebas.UnidadMedida


-- 12. productos
insert into Pruebas.Producto (TipoID, UnidadMedidaID, Nombre) values
( 1, 1, 'Semilla Tomate '),
( 1, 1, 'Semilla Lechuga '),
( 2, 6, 'Fertilizante'),
( 2, 6, 'Urea Granulada 46%'),
( 3, 4, 'Insecticida Cipermetrina'),
( 3, 4, 'Fungicida Propiconazol'),
( 7, 8, 'Machete Tramontina'),
( 7, 8, 'Bomba Fumigadora'),
-- Productos Agrícolas (Típicos de Cortés)
(4, 7, 'Banano'),
(4, 7, 'Plátano Verde'),
(5, 1, 'Tomate'),
(5, 1, 'Lechuga Iceberg'),
(6, 3, 'Maíz'),
(6, 3, 'Frijol Rojo'),
(8, 1, 'Melón');


select * from Pruebas.Producto 
delete from Pruebas.Producto



-- 13. producto detalle (precios)
insert into Pruebas.ProductoDetalle ( ProductoID, ListaPreciosID, Precio) values
-- Precios para lista mayorista (ID 1)
(1, 1, 85.00),      -- Semilla Tomate 
(1, 6, 50.00),      -- Semilla Tomate Costo
(2, 1, 65.00),      -- Semilla Lechuga
(2, 6, 50.00),      -- Semilla Lechuga Costo
(3, 1, 750.00),     -- Fertilizante
(3, 6, 500.00),     -- Fertilizante Costo
(4, 1, 680.00),     -- Urea 46%
(4, 6, 600.00),     -- Urea 46% costo
(5, 1, 180.00),     -- Insecticida
(5, 6, 100.00),     -- Insecticida costo
(6, 1, 140.00),     -- Fungicida 
(6, 6, 100.00),     -- Fungicida costo
(7, 1, 280.00),     -- Machete
(7, 6, 250.00),     -- Machete costo
(8, 1, 1250.00),    -- Bomba Fumigadora
(8, 6, 1000.00),    -- Bomba Fumigadora costo
(9, 1, 120.00),     -- Banano (caja)
(9, 6, 90.00),		-- Banano (caja) Costo
(10, 1, 95.00),     -- Plátano Verde (caja)
(10, 6, 70.00),     -- Plátano Verde (caja) Costo
(11, 1, 25.00),     -- Tomate (kg)
(11, 6, 10.00),     -- Tomate (kg) Costo
(12, 1, 18.00),     -- Lechuga Iceberg (kg)
(12, 6, 10.00),     -- Lechuga Iceberg (kg) Costo
(13, 1, 520.00),    -- Maíz (q) - Precio oficial 2024
(13, 6, 400.00),    -- Maíz (q) - Costo
(14, 1, 850.00),    -- Frijol Rojo (q)
(14, 6, 700.00),    -- Frijol Rojo (q) costo
(15, 1, 45.00),     -- Melón (kg) 
(15, 6, 30.00);     -- Melón (kg) costo


select * from Pruebas.ProductoDetalle 
delete from Pruebas.ProductoDetalle

-- 14. bodega
insert into Pruebas.Bodega (BodegaID, Nombre, Capacidad, DireccionID) values
(1, 'Bodega Central SPS', 800.00, 1),
(2, 'Bodega Puerto Cortés', 600.00, 5),
(3, 'Bodega Choloma', 400.00, 4),
(4, 'Bodega Villanueva', 350.00, 6),
(5, 'Bodega La Lima', 300.00, 7);

select * from Pruebas.Bodega 
delete from Pruebas.Bodega

-- 15. bodega detalle (inventario)
insert into Pruebas.BodegaDetalle (BodegaID, ProductoID, Comprometido, TotalExistencias) values
-- Bodega Central
(1, 1, 5.00, 25.00),    -- Semilla Tomate
(2, 2, 3.00, 20.00),    -- Semilla Lechuga
(3, 3, 10.00, 45.00),   -- Fertilizante
(4, 4, 8.00, 35.00),    -- Urea
(5, 5, 2.00, 15.00);    -- Insecticida

select * from Pruebas.BodegaDetalle 
delete from Pruebas.BodegaDetalle

-- 16. lote
insert into Pruebas.Lote (LoteID, FincaID, ProductoID, TipoRiegoID, TipoSueloID, FechaSiembra, FechaCosecha, Extension) values
(1, 1, 11, 1, 3, '2024-03-15', '2024-07-15', 255.50),  -- Tomate Cherry en Finca San José
(2, 1, 15, 3, 2, '2024-01-10', '2024-12-10', 536.00),    -- Café en Finca San José
(3, 2, 12, 2, 4, '2024-04-01', '2024-06-01', 365.75),   -- Lechuga en Finca Las Flores
(4, 3, 13, 1, 5, '2024-05-20', '2024-10-20', 365.25),        -- Maíz en Finca El Paraíso
(5, 4, 9, 4, 1, '2024-02-01', '2024-05-01', 494.00),  -- Banano en Finca Bella Vista
(6, 5, 14, 2, 6, '2024-06-15', '2024-11-15', 265.80);    -- Frijol en Finca Los Robles

select * from Pruebas.Lote 
delete from Pruebas.Lote


-- 17. Tipo Suelo
insert into Pruebas.TipoSuelo ( NombreComun, Descripcion) values 
('Franco-arcilloso', ''),
('Volcanico', ''),
('Arenoso joven', ''),
('Organico', ''),
('Franco', ''),
('Franco Fertil', ''),
('Arcilloso Acido', ''),
('Lateritico', ''),
('Arcilloso Expansivo', '');


select * from Pruebas.TipoSuelo
delete from Pruebas.TipoSuelo



--18. Puesto
INSERT INTO Pruebas.Puesto (PuestoID, Nombre) VALUES 
(1, 'Vendedor'),
(2, 'Repartidor'),
(3, 'Administrador')

select * from Pruebas.Puesto


--19.Empleado
INSERT INTO Pruebas.Empleado (EmpleadoID, Nombre, Identidad, RTN, Correo, Telefono, Direccion, Notas,PuestoID, Estado, Sexo, Edad ,EstadoCivil) values
(1, 'Empleado 1', '0501200006523', '05012000065238', 'empleado1@agrolink.com', '99887766' ,'Bo. Suyapa', 'N/A', 1, 'Activo', 'Masculino', 21, 'Casado' ),
(2, 'Empleado 2', '0801200006523', '08012000065238', 'empleado2@agrolink.com','99332211' ,'Bo. La Guardia', 'N/A', 2, 'Activo', 'Femenino', 30, 'Soltero' )

select * from Pruebas.Empleado