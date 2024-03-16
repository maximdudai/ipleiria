
DROP DATABASE if exists bdmensagens;
CREATE DATABASE bdmensagens;
USE bdmensagens;

CREATE TABLE Utilizadores(
ID				INT(11)			AUTO_INCREMENT,
nome			VARCHAR(30) 	NOT NULL,
genero			ENUM('M','F')	NOT NULL DEFAULT 'M',
dtaNascimento	DATE 			NOT NULL,
email 			VARCHAR(150) 	NOT NULL,
morada			VARCHAR(120) 	NOT NULL,
nif				CHAR(9),
login           VARCHAR(15) 	NOT NULL,
senha			VARCHAR(64) 	NOT NULL,
dtaRegisto		DATETIME 		NOT NULL,
CONSTRAINT pk_utilizadores_id PRIMARY KEY(ID),
CONSTRAINT uk_utilizadores_nif UNIQUE(nif)
) ENGINE=InnoDB;

CREATE TABLE Mensagens(
ID 			INT(11)		AUTO_INCREMENT,
assunto		VARCHAR(20) NOT NULL,
mensagem	TEXT 		NOT NULL,
dtaRegisto	DATETIME    NOT NULL,
IDUTILIZADOR INT(11) 	NOT NULL,
CONSTRAINT pk_mensagem_id PRIMARY KEY(ID), 
CONSTRAINT fk_mensagem_idutilizador FOREIGN KEY(IDUTILIZADOR) REFERENCES UTILIZADORES(ID))ENGINE=INNODB;

