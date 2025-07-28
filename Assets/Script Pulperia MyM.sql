CREATE DATABASE Pulperia_MYM;

-------------------------------------------------------------------------------------------

USE Pulperia_MYM;

--Cliente
CREATE TABLE Cliente (
    ID_cliente INT PRIMARY KEY IDENTITY(1, 1),
    nombre_completo VARCHAR(100) NULL,
    direccion VARCHAR(150) NULL,
    telefono VARCHAR(25) NULL,
    descuento_especial DECIMAL(10,2) NULL,
    descuento BIT NULL,
    activo BIT
);

--Proveedor
CREATE TABLE Proveedor (
    ID_proveedor INT PRIMARY KEY IDENTITY(1, 1),
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(50) NULL,
    direccion VARCHAR(150) NULL,
    activo BIT
);

--Usuario
CREATE TABLE Usuario (
    ID_usuario INT PRIMARY KEY IDENTITY(1, 1),
    codigo_usuario VARCHAR(50),
    nombre_usuario VARCHAR(50) NOT NULL,
    contrasena VARCHAR(100) NOT NULL,
    rol VARCHAR(20) NULL,
    activo BIT
);

--Tipo
CREATE TABLE Tipo (
    ID_tipo INT PRIMARY KEY,
    descripcion VARCHAR(100) NOT NULL
);

--Unidad
CREATE TABLE Unidad (
    ID_unidad INT PRIMARY KEY,
    nombre_unidad VARCHAR(50) NOT NULL
);

--Producto
CREATE TABLE Producto (
    ID_producto INT PRIMARY KEY IDENTITY(1, 1),
    nombre_producto VARCHAR(100) NOT NULL,
    precio DECIMAL(18,2) NOT NULL,
    stock INT NULL,
    activo BIT
);

--Compra
CREATE TABLE Compra (
    ID_compra INT PRIMARY KEY IDENTITY(1, 1),
    codigo_interno VARCHAR(50) NULL,
    fecha DATETIME NULL,
    ID_tipo INT NULL,
    ID_proveedor INT NULL,
    ID_usuario INT NULL,
    FOREIGN KEY (ID_tipo) REFERENCES Tipo(ID_tipo),
    FOREIGN KEY (ID_proveedor) REFERENCES Proveedor(ID_proveedor),
    FOREIGN KEY (ID_usuario) REFERENCES Usuario(ID_usuario)
);

--Compra detalle
CREATE TABLE Compra_detalle (
    ID_detalle INT PRIMARY KEY IDENTITY(1, 1),
    ID_compra INT NOT NULL,
    ID_producto INT NOT NULL,
    cantidad INT NULL,
    cantidad_dec DECIMAL(18,2) NULL,
    ID_unidad INT NULL,
    costo DECIMAL(18,2) NULL,
    FOREIGN KEY (ID_compra) REFERENCES Compra(ID_compra),
    FOREIGN KEY (ID_producto) REFERENCES Producto(ID_producto),
    FOREIGN KEY (ID_unidad) REFERENCES Unidad(ID_unidad)
);


-- Venta
CREATE TABLE Venta (
    ID_venta INT PRIMARY KEY IDENTITY(1, 1),
    codigo_interno VARCHAR(50) NULL,
    fecha DATETIME NULL,
    ID_tipo INT NULL,
    ID_cliente INT NULL,
    ID_usuario INT NULL,
    credito BIT NULL,
    fecha_vencimiento_credito DATETIME NULL,
    total DECIMAL(18,2) NULL,
    total_pagado DECIMAL(18,2) NULL,
    FOREIGN KEY (ID_tipo) REFERENCES Tipo(ID_tipo),
    FOREIGN KEY (ID_cliente) REFERENCES Cliente(ID_cliente),
    FOREIGN KEY (ID_usuario) REFERENCES Usuario(ID_usuario)
);

-- Venta detalle
CREATE TABLE Venta_detalle (
    ID_detalle INT PRIMARY KEY IDENTITY(1, 1),
    ID_venta INT NOT NULL,
    ID_producto INT NOT NULL,
    cantidad INT NULL,
    cantidad_dec DECIMAL(18,2) NULL,
    ID_unidad INT NULL,
    precio_unitario DECIMAL(18,2) NULL,
    descuento DECIMAL(18,2) NULL,
    FOREIGN KEY (ID_venta) REFERENCES Venta(ID_venta),
    FOREIGN KEY (ID_producto) REFERENCES Producto(ID_producto),
    FOREIGN KEY (ID_unidad) REFERENCES Unidad(ID_unidad)
);

-------------------------------------------------------------------------------------------

-- Cliente
INSERT INTO Cliente VALUES 
('Juan Pérez', 'Barrio Centro, Tegucigalpa', '9854-1234', 5.00, 1, 1),
('María López', 'Colonia Kennedy, Tegucigalpa', '9987-4561', 0.00, 0, 1),
('Carlos Mejía', 'Colonia Palmira, Tegucigalpa', '9732-5698', 10.00, 1, 1);

-- Proveedor
INSERT INTO Proveedor VALUES 
('Distribuidora El Buen Precio', '2245-7890', 'Bulevar Morazán, Tegucigalpa', 1),
('Productos Alimenticios S.A.', '2234-1233', 'Zona Industrial, Comayagüela', 1);

-- Usuario
INSERT INTO Usuario VALUES 
('admin', 'Admin', 'admin1234', 'Administrador', 1),
('cajero01', 'Juan Perez', 'cajero2024', 'Cajero', 1);

-- Tipo
INSERT INTO Tipo VALUES 
(1, 'Contado'),
(2, 'Crédito');

-- Unidad
INSERT INTO Unidad VALUES 
(1, 'Unidad'),
(2, 'Caja'),
(3, 'Libra');

-- Producto
INSERT INTO Producto VALUES 
('Arroz San Pedro 25lb', 650.00, 30, 1),
('Aceite Ideal 1lt', 45.00, 100, 1),
('Azúcar Doña Lisa 50lb', 900.00, 20, 1);

-- Compra
INSERT INTO Compra VALUES 
('CMP-001', '2025-07-01 10:30:00', 1, 1, 1),
('CMP-002', '2025-07-03 15:00:00', 1, 2, 1);

-- Compra_detalle
INSERT INTO Compra_detalle VALUES 
(1, 1, 10, NULL, 2, 620.00),
(1, 2, 50, NULL, 1, 42.00),
(2, 3, 5, NULL, 2, 880.00);

-- Venta
INSERT INTO Venta VALUES 
('VEN-001', '2025-07-05 09:00:00', 1, 1, 2, 0, NULL, 350.00, 350.00),
('VEN-002', '2025-07-06 12:00:00', 2, 2, 2, 1, '2025-07-20 00:00:00', 800.00, 300.00);

-- Venta_detalle
INSERT INTO Venta_detalle VALUES 
(1, 1, 2, NULL, 1, 175.00, 0.00),
(1, 2, 1, NULL, 1, 175.00, 0.00),
(2, 3, 4, NULL, 2, 200.00, 20.00);