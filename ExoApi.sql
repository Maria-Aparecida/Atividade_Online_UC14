CREATE DATABASE ExoApi
GO

USE ExoApi
GO

CREATE TABLE Projetos (
    Id INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(150) NOT NULL,
    Status VARCHAR(50),
    DataInicio DATETIME,
    Tecnologia VARCHAR(50)
    
)
GO

INSERT INTO Projetos (Titulo, Status, DataInicio,Tecnologia) 
VALUES ('Titulo A','Concluido', 12/06/2021, 'Java')
GO

INSERT INTO Projetos (Titulo, Status, DataInicio,Tecnologia) 
VALUES ('Titulo B','Atrasado', 15/07/2021, 'C#')
GO

INSERT INTO Projetos (Titulo, Status, DataInicio,Tecnologia) 
VALUES ('Titulo C', 'Aguardando aprovacao',20/08/2021, 'JavaScript')
GO


INSERT INTO Projetos (Titulo, Status, DataInicio,Tecnologia) 
VALUES ('Titulo D','Aprovado', 10/09/2021, 'MySQL')
GO


INSERT INTO Projetos (Titulo, Status, DataInicio,Tecnologia) 
VALUES ('Titulo E','Em andamento', 30/10/2021, 'Scrum')
GO

-- UPDATE Projetos SET Titulo = 'Titulo A' Where Id = 1;

 -- DELETE FROM Livros WHERE Id = 1;

SELECT Id, Titulo, Status, DataInicio, Tecnologia FROM Projetos
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL,
    Tipo char (1) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('ana@sp.br', '1234','0')
INSERT INTO Usuarios VALUES ('bete@sp.br', '5678','0')
INSERT INTO Usuarios VALUES ('carla@sp.br', '91011','0')
INSERT INTO Usuarios VALUES ('danilo@sp.br', '1234','0')
INSERT INTO Usuarios VALUES ('emily@sp.br', '2468','0')

GO

SELECT * FROM Usuarios WHERE email = 'ana@sp.br' AND senha = '1234'
GO



select *from Usuarios;

