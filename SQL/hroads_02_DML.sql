USE HROADS_13GP;
GO

INSERT INTO TIPO(nomeTipo)
VALUES ('Ataque'), ('Defesa'), ('Cura'), ('Magia')

INSERT INTO HABILIDADE(idTipo, nomeHabilidade)
VALUES (1, 'Lança Mortal'), (2, 'Escudo Supremo'), (3, 'Recuperar Vida')

INSERT INTO CLASSE(nomeClasse)
VALUES ('Bárbaro'), ('Cruzado'), ('Caçadora de Demônios'), ('Monge'), ('Necromante'), ('Feiticeiro'), ('Arcanista')

INSERT INTO HABILIDADECLASSE(idClasse, idHabilidade) 
VALUES (1, 1), (1, 2), (2, 2), (3, 1), (4, 2), (4, 3), (5, NULL), (6, 3), (7, NULL)

INSERT INTO PERSONAGEM(idClasse, nomePersonagem, nomeJogador, Vida, Mana, dataCriacao, dataAtualizacao)
VALUES (1, 'DeuBug', 'Josias', 100, 80, '18/01/2019', '10/08/2021'), (4, 'BitBug', 'Lucas', 70, 100, '17/03/2016', '10/08/2021'), (7, 'Fer8', 'Saulo', 75, 60, '18/03/2018', '10/08/2021')


UPDATE PERSONAGEM
SET nomePersonagem = 'Fer7'
WHERE idPersoagem = 3

UPDATE CLASSE
SET nomeClasse = 'Necromancer'
WHERE idClasse = 5