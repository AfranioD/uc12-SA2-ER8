REATE DATABASE Uc12_SA3_cadastroDeUsuario
GO

USE Uc12_SA3_cadastroDeUsuario
GO

CREATE TABLE Clientes
(
	ClienteId INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL,
)
GO

INSERT INTO Clientes VALUES('email@email.com', 123456)
INSERT INTO Clientes VALUES('email11@email.com', 123456)
INSERT INTO Clientes VALUES('email22@email.com', 123456)
GO

SELECT * FROM Clientes

--SELECT Email, HASHBYTES('MD2', Senha)AS 'Senha HASH' FROM Clientes
SELECT Email, HASHBYTES('MD2', Senha)AS 'Senha HASH' FROM Clientes WHERE ClienteId = 1
SELECT Email, HASHBYTES('MD4', Senha)AS 'Senha HASH' FROM Clientes WHERE ClienteId = 1
SELECT Email, HASHBYTES('MD5', Senha)AS 'Senha HASH' FROM Clientes WHERE ClienteId = 1
SELECT Email, HASHBYTES('SHA', Senha)AS 'Senha HASH' FROM Clientes WHERE ClienteId = 1
SELECT Email, HASHBYTES('SHA1', Senha)AS 'Senha HASH' FROM Clientes WHERE ClienteId = 1
SELECT Email, HASHBYTES('SHA2_256', Senha)AS 'Senha HASH' FROM Clientes WHERE ClienteId = 1
SELECT Email, HASHBYTES('SHA2_512', Senha)AS 'Senha HASH' FROM Clientes WHERE ClienteId = 1