CREATE DATABASE notasPolitecnicoInternacional;
GO

USE notasPolitecnicoInternacional;
GO

CREATE TABLE tecnologiaDesarrolloSoftware (
    id INT IDENTITY(1,1) PRIMARY KEY,
    NombreEstudiante VARCHAR(100) NOT NULL,
    NotaCorte1 DECIMAL(2, 1) NOT NULL,
    NotaCorte2 DECIMAL(2, 1) NOT NULL,
    NotaCorte3 DECIMAL(2, 1) NOT NULL,
    NotaDefinitiva DECIMAL(2, 1) NOT NULL,
);
GO

SELECT* FROM tecnologiaDesarrolloSoftware
GO