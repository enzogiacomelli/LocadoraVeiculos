
/*
CREATE TABLE Fabricantes(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
);




CREATE TABLE Veiculos(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	FabricanteId INT NOT NULL,
	Tipo VARCHAR (20) NOT NULL,
	Nome VARCHAR (50) NOT NULL,
	Placa VARCHAR (10) NOT NULL,
	Quilometragem INT NOT NULL,
	ValorDiaria DECIMAL(10,2) NOT NULL,
	FOREIGN KEY (FabricanteId) REFERENCES Fabricantes(Id)
);
*/

/*
CREATE TABLE Clientes(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
	Documento VARCHAR(14) NOT NULL,
	Telefone VARCHAR(11) NOT NULL
);
*/

/*
CREATE TABLE Locacoes(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	ClienteId INT NOT NULL,
	VeiculoId INT NOT NULL,
	Diarias INT NOT NULL,
	ValorFinal DECIMAL(10,2) NOT NULL,
	Inicio DATETIME NOT NULL,
	Fim DATETIME NOT NULL,
	FOREIGN KEY (ClienteId) REFERENCES Clientes(Id),
	FOREIGN KEY (VeiculoId) REFERENCES Veiculos(Id)
);
*/

--INSERT INTO Locacoes (ClienteId, VeiculoId, Diarias, ValorFinal, Inicio, Fim) VALUES (1, 6, 3, 140.00, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);



select * from Locacoes

select * from Fabricantes
select * from Veiculos
select * from Clientes

--SELECT COUNT(*) FROM Clientes