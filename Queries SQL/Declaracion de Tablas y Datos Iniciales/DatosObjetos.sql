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
(510, 'El Paraíso', 'Orilla del Lago de Yojoa');

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
insert into Pruebas.Empresa (EmpresaID, Nombre, RTN, Correo, Telefono, DireccionID, NumFiscalID) values
(1, 'Comercializadora de Productos Agricolas', '05019999123456', 'info@agrolink.hn', '2550-1234', 1, 1);

select * from Pruebas.Empresa 
delete from Pruebas.Empresa

-- 7. usuario
insert into Pruebas.Usuario (UsuarioID, Usuario, Clave, Nombre, TipoUsuario) values
--(1, 'admin', 'admin123', 'Carlos Hernández', 'Administrador'),
--(2, 'srodriguez', 'sofia321', 'Sofía Rodríguez', 'Administrador'),
(3, 'mlopez', 'maria456', 'María López', 'Estandar'),
(4, 'jcastillo', 'juan789', 'Juan Castillo', 'Estandar'),
(5, 'pgomez', 'pedro654', 'Pedro Gómez', 'Estandar');

select * from Pruebas.Usuario 
delete from Pruebas.Usuario

-- 8. socio
insert into Pruebas.Socio (SocioID, Nombre, TipoSocio, Identidad, RTN, Correo, Telefono, DireccionID, Notas) values
(1, 'José Manuel Flores', 'Agricultor', '0502199812345', '05021998123456', 'joseflores@email.com', '9876-5432', 4, 'Productor de plátano en Choloma'),
(2, 'Agrosuministros S.A.', 'Proveedor', '0501199923456', '05011999234567', 'ventas@agroceiba.hn', '2557-6789', 5, 'Distribuidor de fertilizantes'),
(3, 'Carmen Elena Mejía', 'Agricultor', '0511198734567', '05011987345678', 'carmenmejia@email.com', '8765-4321', 6, 'Productora orgánica en Villanueva'),
(4, 'Supermercados Del Norte', 'Consumidor', '0501199845678', '05011998456789', 'compras@delnorte.hn', '2558-7890', 7, 'Cadena regional de supermercados'),
(5, 'Roberto Alvarado', 'Agricultor', '0512199056789', '05121990567890', 'roberto.alvarado@email.com', '9654-3210', 8, 'Especialista en hortalizas'),
(6, 'Insumos Agrícolas', 'Proveedor', '0501199167890', '05011991678901', 'info@insumoscortes.hn', '2559-8901', 9, 'Proveedor de semillas certificadas'),
(7, 'Ana Sofía Castillo', 'Agricultor', '0510198978901', '05101989789012', 'ana.castillo@email.com', '9543-2109', 10, 'Cultivos de exportación Lago Yojoa');

select * from Pruebas.Socio 
delete from Pruebas.Socio

-- 9. finca
insert into Pruebas.Finca (FincaID, SocioID, Nombre, DireccionID, CapacidadAgua) values
(1, 1, 'Finca San José', 4, 'Alta'),
(2, 3, 'Finca Orgánica', 6, 'Media'),
(3, 5, 'Finca El Paraíso', 7, 'Alta'),
(4, 7, 'Finca Lago Verde', 10, 'Alta'),
(5, 1, 'Finca Los Plátanos', 4, 'Media');

select * from Pruebas.Finca 
delete from Pruebas.Finca

-- 10. tipo de producto
insert into Pruebas.TipoProducto (TipoID, NombreTipo, Categoria) values
(1, 'Semillas Certificadas', 'Insumo'),
(2, 'Fertilizantes', 'Insumo'),
(3, 'Agroquímicos', 'Insumo'),
(4, 'Frutas Tropicales', 'Producto Agricola'),
(5, 'Hortalizas', 'Producto Agricola'),
(6, 'Granos Básicos', 'Producto Agricola'),
(7, 'Herramientas', 'Insumo'),
(8, 'Cultivos Exportación', 'Producto Agricola');

select * from Pruebas.TipoProducto 
delete from Pruebas.TipoProducto

-- 11. unidad de medida
insert into Pruebas.UnidadMedida (UnidadMedidaID, Nombre, Abreviacion) values
(1, 'Kilogramo', 'kg'),
(2, 'Libra', 'lb'),
(3, 'Quintal', 'q'),
(4, 'Litro', 'lts'),
(5, 'Galón', 'gal'),
(6, 'Saco', 'saco'),
(7, 'Caja', 'caja'),
(8, 'Unidad', 'ud'),
(9, 'Metro', 'm'),
(10, 'Tonelada', 't');

select * from Pruebas.UnidadMedida 
delete from Pruebas.UnidadMedida

-- 12. productos
insert into Pruebas.Producto (ProductoID, TipoID, UnidadMedidaID, Nombre) values
(1, 1, 1, 'Semilla Tomate '),
(2, 1, 1, 'Semilla Lechuga '),
(3, 2, 6, 'Fertilizante'),
(4, 2, 6, 'Urea Granulada 46%'),
(5, 3, 4, 'Insecticida Cipermetrina'),
(6, 3, 4, 'Fungicida Propiconazol'),
(7, 7, 8, 'Machete Tramontina'),
(8, 7, 8, 'Bomba Fumigadora'),
-- Productos Agrícolas (Típicos de Cortés)
(9, 4, 7, 'Banano'),
(10, 4, 7, 'Plátano Verde'),
(11, 5, 1, 'Tomate'),
(12, 5, 1, 'Lechuga Iceberg'),
(13, 6, 3, 'Maíz'),
(14, 6, 3, 'Frijol Rojo'),
(15, 8, 1, 'Melón');

select * from Pruebas.Producto 
delete from Pruebas.Producto

-- 13. producto detalle (precios)
insert into Pruebas.ProductoDetalle (ProductoID, ListaPreciosID, Precio) values
-- Precios para lista mayorista (ID 1)
(1, 1, 85.00),      -- Semilla Tomate 
(2, 1, 65.00),      -- Semilla Lechuga
(3, 1, 750.00),     -- Fertilizante
(4, 1, 680.00),     -- Urea 46%
(5, 1, 180.00),     -- Insecticida
(6, 1, 140.00),     -- Fungicida
(7, 1, 280.00),     -- Machete
(8, 1, 1250.00),    -- Bomba Fumigadora
(9, 1, 120.00),     -- Banano (caja)
(10, 1, 95.00),     -- Plátano Verde (caja)
(11, 1, 25.00),     -- Tomate (kg)
(12, 1, 18.00),     -- Lechuga Iceberg (kg)
(13, 1, 520.00),    -- Maíz (q) - Precio oficial 2024
(14, 1, 850.00),    -- Frijol Rojo (q)
(15, 1, 45.00);     -- Melón (kg)

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