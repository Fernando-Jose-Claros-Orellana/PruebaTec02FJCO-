-- Crear la base de datos
CREATE DATABASE EmpleadoDB;

-- Usar la base de datos
USE EmpleadoDB;

-- Crear la tabla "Empleados"
CREATE TABLE Empleados (
  id INT PRIMARY KEY Identity,
  nombre VARCHAR(50),
  apellido VARCHAR(50),
  Imagen IMAGE,
  salario DECIMAL(10, 2),
  departamento_id INT,
  FOREIGN KEY (departamento_id) REFERENCES Departamento(id)
)

-- Crear la tabla "Departamentos"
CREATE TABLE Departamento (
  id INT PRIMARY KEY Identity,
  nombre VARCHAR(50),
  ubicacion VARCHAR(100)
)