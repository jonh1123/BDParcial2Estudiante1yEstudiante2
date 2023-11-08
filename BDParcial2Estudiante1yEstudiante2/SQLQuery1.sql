
CREATE DATABASE BDParcial2Estudiante1yEstudiante2;
USE BDParcial2Estudiante1yEstudiante2;


CREATE TABLE Cliente (
    ClienteID INT PRIMARY KEY IDENTITY(1, 1),
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    DepartamentoID INT,
    MunicipioID INT
);


CREATE TABLE Departamento (
    DepartamentoID INT PRIMARY KEY IDENTITY(1, 1),
    Nombre VARCHAR(50) NOT NULL
);


INSERT INTO Departamento (Nombre)
VALUES ('Sonsonate'), ('San Miguel'), ('Chalatenango'), ('La Union');

CREATE TABLE Municipio (
    MunicipioID INT PRIMARY KEY IDENTITY(1, 1),
    Nombre VARCHAR(50) NOT NULL,
    DepartamentoID INT
);

 --departamento (Sonsonate)
INSERT INTO Municipio (Nombre, DepartamentoID)
VALUES ('Son', 1), ('Acajutla', 1), ('Caluco', 1), ('Izalco', 1), ('Nahuizalco', 1);

-- departamento (San Miguel)
INSERT INTO Municipio (Nombre, DepartamentoID)
VALUES ('Ciudad Barrios', 2), ('Nuevo Edén de San Juan', 2), ('San Gerardo', 2), ('San Luis de la Reina', 2);

--  departamento (Chalatenango)
INSERT INTO Municipio (Nombre, DepartamentoID)
VALUES ('San Fernando', 3), ('Cancasque', 3), ('San Isidro Labrador', 3), ('San Francisco Morazán', 3);

--  departamento (La Union)
INSERT INTO Municipio (Nombre, DepartamentoID)
VALUES ('Conchagua', 4), ('Intipucá', 4), ('San José', 4), ('El Carmen', 4);

-- Insertar 2 clientes
INSERT INTO Cliente (Nombre, Apellido, DepartamentoID, MunicipioID)
VALUES ('Jonathan', 'Perez', 1, 1), ('Carlos', 'Suarez', 2, 4);
