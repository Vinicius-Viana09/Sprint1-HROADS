CREATE DATABASE HROADS_13GP;
GO

USE HROADS_13GP;
GO

CREATE TABLE TIPO(
idTipo TINYINT PRIMARY KEY IDENTITY(1,1),
nomeTipo VARCHAR(12) NOT NULL
);
GO

CREATE TABLE HABILIDADE(
idHabilidade TINYINT PRIMARY KEY IDENTITY(1,1),
idTipo TINYINT FOREIGN KEY REFERENCES TIPO(idTipo),
nomeHabilidade VARCHAR(30) NOT NULL
);
GO

CREATE TABLE CLASSE(
idClasse TINYINT PRIMARY KEY IDENTITY(1,1),
nomeClasse VARCHAR(30) NOT NULL
);
GO

CREATE TABLE HABILIDADECLASSE(
idHabilidadeClasse TINYINT PRIMARY KEY IDENTITY(1,1),
idClasse TINYINT FOREIGN KEY REFERENCES CLASSE(idClasse),
idHabilidade TINYINT FOREIGN KEY REFERENCES HABILIDADE(idHabilidade)
);
GO

CREATE TABLE PERSONAGEM(
idPersoagem INT PRIMARY KEY IDENTITY(1,1),
idClasse TINYINT FOREIGN KEY REFERENCES CLASSE(idClasse),
nomePersonagem VARCHAR(20) NOT NULL UNIQUE,
nomeJogador VARCHAR(20) NOT NULL, 
Vida SMALLINT NOT NULL,
Mana SMALLINT NOT NULL,
dataCriacao CHAR(10),
dataAtualizacao CHAR(10)
);
GO