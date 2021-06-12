CREATE TABLE EXERCITO.militar (
	nCC				INT,
	Pnome			VARCHAR(25)		NOT NULL,
	Unome			VARCHAR(25)		NOT NULL,
	morada			VARCHAR(100)	NOT NULL,
	email			VARCHAR(100),
	dNasc			DATE			NOT NULL,
	dInsc			DATE			NOT NULL,
	tel				VARCHAR(9)	,
	nacionalidade	VARCHAR(50)		NOT NULL,
	nMissoes		INT				DEFAULT 0	NOT NULL	CHECK (nMissoes >= 0),
	ramo			INT		NOT NULL,			
	base			INT				NOT NULL,
	pelotao			INT			,
	cargo			INT				NOT NULL,

	PRIMARY KEY (nCC),
	FOREIGN KEY (ramo) REFERENCES EXERCITO.ramo(id),
	FOREIGN KEY (base) REFERENCES EXERCITO.base_militar(id),
	FOREIGN KEY (pelotao) REFERENCES EXERCITO.pelotao(id),
	FOREIGN KEY (cargo) REFERENCES EXERCITO.cargo(id));

ALTER TABLE EXERCITO.militar ADD CONSTRAINT curDate DEFAULT GETDATE() FOR dInsc
ALTER TABLE EXERCITO.militar ALTER COLUMN base INT NULL
-- 
CREATE TABLE EXERCITO.cargo (
	id				INT		IDENTITY(1,1),
	cargo			VARCHAR(50),

	PRIMARY KEY (id));


CREATE TABLE EXERCITO.medico (
	nCC				INT,
	especialidade	INT				NOT NULL,

	PRIMARY KEY (nCC)	,
	FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC),
	FOREIGN KEY (especialidade) REFERENCES EXERCITO.especialidade(id))

--
CREATE TABLE EXERCITO.especialidade (
	id				INT		IDENTITY(1,1),
	especialidade	VARCHAR(50)		NOT NULL,

	PRIMARY KEY (id))

CREATE TABLE EXERCITO.engenheiro (
	nCC				INT,
	PRIMARY KEY (nCC),
	FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC))

CREATE TABLE EXERCITO.soldado (
	nCC				INT,
	tipo			INT				NOT NULL,
	PRIMARY KEY (nCC),
	FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC),
	FOREIGN KEY (tipo) REFERENCES EXERCITO.tipo_soldado(id));

--
CREATE TABLE EXERCITO.tipo_soldado (
	id				INT		IDENTITY(1,1),
	tipo			VARCHAR(50)		NOT NULL,

	PRIMARY KEY (id))

ALTER TABLE EXERCITO.tipo_soldado ADD ramo INT CONSTRAINT ramo_tipo_soldado FOREIGN KEY (ramo) REFERENCES EXERCITO.ramo(id);



CREATE TABLE EXERCITO.manuntencao (
	engenheiro		INT,
	equipamento		INT,
	quantia			INT				NOT NULL,

	PRIMARY KEY (engenheiro,equipamento),
	FOREIGN KEY (engenheiro) REFERENCES EXERCITO.engenheiro(nCC),
	FOREIGN KEY (equipamento) REFERENCES EXERCITO.equipamento(id));

CREATE TABLE EXERCITO.utiliza_equipamento (
	soldado			INT,
	equipamento		INT,
	data_i			DATE			NOT NULL,
	data_f			DATE,

	PRIMARY KEY (soldado, equipamento),
	FOREIGN KEY (soldado) REFERENCES EXERCITO.soldado(nCC),
	FOREIGN KEY (equipamento) REFERENCES EXERCITO.equipamento(id));

--
CREATE TABLE EXERCITO.missao (
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(150) NOT NULL,
	tipo INT		NOT NULL,
	pais VARCHAR(30) NOT NULL,
	nBaixas INT DEFAULT 0 NOT NULL,

	FOREIGN KEY (tipo) REFERENCES EXERCITO.tipo_missao(id));

ALTER TABLE EXERCITO.missao ADD brief VARCHAR(1024);


CREATE TABLE EXERCITO.tipo_missao (
	id INT PRIMARY KEY IDENTITY(1,1),
	tipo	VARCHAR(50)	NOT NULL
)

DROP TABLE EXERCITO.missao
DROP TABLE EXERCITO.tipo_missao
--
CREATE TABLE EXERCITO.pelotao (
	id INT PRIMARY KEY	IDENTITY(1,1),
	--nMilitares INT NOT NULL,

	--nCC INT,
	idMissao INT,
	nome VARCHAR(150),
	
	--FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC),
	FOREIGN KEY (idMissao) REFERENCES EXERCITO.missao(id)
)
--TODO 
ALTER TABLE EXERCITO.pelotao ADD nCC INT CONSTRAINT general FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC);
ALTER TABLE EXERCITO.pelotao ADD nome VARCHAR(150)
ALTER TABLE EXERCITO.pelotao ADD CONSTRAINT mission FOREIGN KEY (idMissao) REFERENCES EXERCITO.missao(id);
ALTER TABLE EXERCITO.pelotao DROP CONSTRAINT general
--
CREATE TABLE EXERCITO.ramo (
	id INT IDENTITY,
	sigla VARCHAR(10),
	tipo INT NOT NULL,
	mote VARCHAR(30) NOT NULL,
	contacto VARCHAR(9),
	simbolo VARCHAR(30) NOT NULL,
	morada VARCHAR(100) NOT NULL,
	dia date,
	fax VARCHAR(10),
	data_inicio date,
	data_fim date,

	--nCC INT		DEFAULT NULL,
	
	PRIMARY KEY (id),
	--FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC),
	FOREIGN KEY (tipo) REFERENCES EXERCITO.tipo_ramo(id)
)
--TODO
ALTER TABLE EXERCITO.ramo ADD nCC INT CONSTRAINT comandante FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC);
ALTER TABLE EXERCITO.ramo DROP CONSTRAINT comandante

CREATE TABLE EXERCITO.tipo_ramo (
	id	INT		IDENTITY(1,1),
	design	VARCHAR(50),

	PRIMARY KEY (id)
);


CREATE TABLE EXERCITO.base_militar (
	id INT IDENTITY PRIMARY KEY,
	--nMilitares INT,
	contacto VARCHAR(9),
	maxMilitares INT NOT NULL,
	morada VARCHAR(100) NOT NULL,
	data_inicio date,
	data_fim date,

	--nCC INT,
)
-- todo
ALTER TABLE EXERCITO.base_militar ADD nCC INT CONSTRAINT comandante_base FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC);
ALTER TABLE EXERCITO.base_militar ADD CONSTRAINT zeroMilitares DEFAULT 0 FOR nMilitares
ALTER TABLE EXERCITO.base_militar DROP CONSTRAINT comandante_base;


CREATE TABLE EXERCITO.base_ramo (
	idBase INT,
	idRamo INT,
	
	PRIMARY KEY (idBase, idRamo),
	FOREIGN KEY (idBase) REFERENCES EXERCITO.base_militar(id),
	FOREIGN KEY (idRamo) REFERENCES EXERCITO.ramo(id)
)

CREATE TABLE EXERCITO.equipamento (
	id INT PRIMARY KEY IDENTITY(1,1),
	modelo VARCHAR(100) NOT NULL,
)

ALTER TABLE EXERCITO.equipamento ADD modelo VARCHAR(100) NOT NULL


CREATE TABLE EXERCITO.arma (
	idEqui INT,
	idTipo INT,
	nSerie INT UNIQUE NOT NULL,
	
	PRIMARY KEY (idEqui),
	FOREIGN KEY (idEqui) REFERENCES EXERCITO.equipamento(id),
	FOREIGN KEY (idTipo) REFERENCES EXERCITO.tipo_arma(id)
)

CREATE TABLE EXERCITO.veiculo (
	idEqui INT,
	idTipo INT NOT NULL,
	idMissao INT,
	matricula INT UNIQUE NOT NULL,
	
	PRIMARY KEY (idEqui),
	FOREIGN KEY (idEqui) REFERENCES EXERCITO.equipamento(id),
	FOREIGN KEY (idTipo) REFERENCES EXERCITO.tipo_veiculo(id),
	FOREIGN KEY (idMissao) REFERENCES EXERCITO.missao(id)
)

DROP TABLE EXERCITO.veiculo
DROP TABLE EXERCITO.tipo_veiculo


CREATE TABLE EXERCITO.tipo_arma (
	id INT PRIMARY KEY	IDENTITY(1,1),
	tipo VARCHAR(100) NOT NULL,
)

CREATE TABLE EXERCITO.tipo_veiculo (
	id INT PRIMARY KEY	IDENTITY(1,1),
	tipo VARCHAR(100) NOT NULL,
)

SELECT * FROM EXERCITO.equipamento


------------------------------- DADOS HISTORICOS -----------------------------

CREATE TABLE EXERCITO.historico_ramo (
	nCC INT,
	data_inicio	DATE,
	data_fim	DATE,

	PRIMARY KEY (nCC, data_inicio, data_fim),
	FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC)
)

CREATE TABLE EXERCITO.historico_base (
	nCC INT,
	base INT,
	data_inicio	DATE,
	data_fim	DATE,

	PRIMARY KEY (nCC, base, data_inicio, data_fim),
	FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC),
	FOREIGN KEY (base) REFERENCES EXERCITO.base_militar(id)
)

CREATE TABLE EXERCITO.historico_equipamento (
	nCC INT,
	equip INT,
	data_inicio DATE,
	data_fim DATE,

	PRIMARY KEY (nCC, equip, data_inicio, data_fim),
	FOREIGN KEY (nCC) REFERENCES EXERCITO.militar(nCC),
	FOREIGN KEY (equip) REFERENCES EXERCITO.equipamento(id)
)

CREATE TABLE EXERCITO.historico_missao (
	
)