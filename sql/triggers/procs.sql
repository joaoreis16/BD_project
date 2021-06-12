/*
*	TRATA DE REMOVER DA POSI�AO CASO O MILITAR REPRESENTE
*	UMA BASE OU UM RAMO.
*/
DROP PROC EXERCITO.deleteMilitar
CREATE PROC EXERCITO.deleteMilitar @nCC INT
AS
	BEGIN		
		IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC = @nCC)
			BEGIN
				IF EXISTS (SELECT * FROM EXERCITO.ramo WHERE nCC = @nCC)
					BEGIN
						UPDATE EXERCITO.ramo SET nCC=NULL, data_inicio=NULL, data_fim=NULL 
						WHERE nCC = @nCC
					END
		
				IF EXISTS (SELECT * FROM EXERCITO.base_militar WHERE nCC = @nCC)
					BEGIN
						UPDATE EXERCITO.base_militar SET nCC=NULL, data_inicio=NULL, data_fim=NULL 
						WHERE nCC = @nCC
					END

				UPDATE EXERCITO.pelotao SET nCC = NULL WHERE nCC = @nCC
				DELETE FROM EXERCITO.utiliza_equipamento WHERE soldado = @nCC
				DELETE FROM EXERCITO.manuntencao WHERE engenheiro = @nCC
				DELETE FROM EXERCITO.soldado WHERE nCC = @nCC
				DELETE FROM EXERCITO.medico WHERE nCC = @nCC
				DELETE FROM EXERCITO.engenheiro WHERE nCC = @nCC

				DELETE FROM EXERCITO.militar WHERE nCC = @nCC
				RETURN 1
			END
		ELSE
			RAISERROR ('MILITAR N�O EXISTE',1,1)
			RETURN 0
	END
GO

/*
*	COLOCA nCC COMO RESPONSAVEL DE RAMO
*/
CREATE PROC EXERCITO.setResponsavelRamo @nCC INT, @ramo INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC = @nCC) AND
			EXISTS (SELECT * FROM EXERCITO.ramo WHERE id = @ramo)
			BEGIN
				UPDATE EXERCITO.ramo SET nCC = @nCC WHERE id = @ramo
			RETURN 1
			END
		ELSE
			RAISERROR ('RAMO OU MILITAR N�O EXISTENTES',1,1)
			RETURN 0
	END
GO

/*
*	COLOCA nCC COMO RESPONSAVEL DE BASE
*/
CREATE PROC EXERCITO.setResponsavelBase @nCC INT, @base INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC = @nCC) AND
			EXISTS (SELECT * FROM EXERCITO.base_militar WHERE id = @base)
			BEGIN
				UPDATE EXERCITO.base_militar SET nCC = @nCC WHERE id = @base
			RETURN 1
			END
		ELSE
			RAISERROR ('BASE OU MILITAR N�O EXISTENTES',1,1)
			RETURN 0
	END
GO

/*
*	ADICIONAR MILITAR A PELOTAO
*/
CREATE PROC EXERCITO.addToPelotao @nCC INT, @pel INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC = @nCC)
			AND EXISTS (SELECT * FROM EXERCITO.pelotao WHERE id = @pel)
			BEGIN
				UPDATE EXERCITO.militar SET pelotao=@pel
				WHERE nCC=@nCC
				RETURN 1
			END
		ELSE
			RAISERROR ('PELOTAO OU MILITAR N�O EXISTENTES',1,1)
			RETURN 0
	END
GO

/*
*	REMOVE MILITAR DE UM PELOTAO
*/
CREATE PROC EXERCITO.removeFromPelotao @nCC INT, @pel INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC = @nCC)
			BEGIN
				IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC = @nCC AND pelotao = @pel)
					BEGIN
						UPDATE EXERCITO.militar SET pelotao=NULL WHERE nCC = @nCC
						RETURN 1
					END
				ELSE
					RAISERROR ('MILITAR NAO PERTENCE AO PELOTAO',1,1)
					RETURN 0 
			END
		ELSE
			RAISERROR ('MILITAR NAO EXISTE',1,1)
	END
GO

/*
*	CRIA UM PELOTAO
*/
CREATE PROC EXERCITO.createPelotao @nome VARCHAR(150)
AS
	BEGIN
		INSERT INTO EXERCITO.pelotao(nome) VALUES (@nome)
	END


/*
*	REMOVE UM PELOTAO 
*/
CREATE PROC EXERCITO.deletePelotao @pel INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.pelotao WHERE id = @pel)
			BEGIN
				UPDATE EXERCITO.militar SET pelotao=NULL WHERE pelotao = @pel
				DELETE FROM EXERCITO.pelotao WHERE id = @pel
				RETURN 1
			END
		ELSE
			RAISERROR ('PELOTAO NAO EXISTE',1,1)
	END 
GO

/*
*	ASSIGN UM PELOTAO A UMA MISSAO
*/
CREATE PROC EXERCITO.assignPelToMissao @pel INT, @mis INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.pelotao WHERE id = @pel)
			AND EXISTS (SELECT * FROM EXERCITO.missao WHERE id = @mis)
			BEGIN
				UPDATE EXERCITO.pelotao SET idMissao = @mis WHERE id = @pel
				RETURN 0
			END
		ELSE
			RAISERROR ('MISSAO OU PELOTAO NAO EXISTEM',1,1)
			RETURN 0
	END
GO



/*
*	CRIAR UM SOLDADO
*/
CREATE PROC EXERCITO.createSoldado @nCC INT, @tipo INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC=@nCC)
			BEGIN
				INSERT INTO EXERCITO.soldado(nCC, tipo) VALUES (@nCC, @tipo)
				RETURN 1
			END
		ELSE
			RAISERROR ('nCC N�O REGISTADO',1,1)
			RETURN 0
	END
GO

/*
*	CRIAR UM ENGENHEIRO 
*/
CREATE PROC EXERCITO.createEngenheiro @nCC INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC=@nCC) AND EXERCITO.disjointMilitar(@nCC) = 1
			BEGIN
				INSERT INTO EXERCITO.engenheiro(nCC) VALUES (@nCC)
				RETURN 1
			END
		ELSE
			RAISERROR ('nCC N�O REGISTADO',1,1)
			RETURN 0
	END
GO

/*
*	CRIAR UM MEDICO
*/
CREATE PROC EXERCITO.createMedico @nCC INT, @espec INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.militar WHERE nCC=@nCC) AND EXERCITO.disjointMilitar(@nCC) = 1
			BEGIN
				INSERT INTO EXERCITO.medico(nCC, especialidade) VALUES (@nCC, @espec)
				RETURN 1
			END
		ELSE
			RAISERROR ('nCC N�O REGISTADO OU J� PERTENCE A OUTRA SUBCLASSE',1,1)
			RETURN 0
	END
GO


/*
*	DAR EQUIPAMENTO A SOLDADO
*/
CREATE PROC EXERCITO.assignEquipamento @nCC INT, @equi INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM EXERCITO.soldado WHERE nCC = @nCC)
			BEGIN
				IF EXISTS (SELECT * FROM EXERCITO.equipamento WHERE id = @equi)
					BEGIN
						IF NOT EXISTS (SELECT * FROM EXERCITO.utiliza_equipamento WHERE equipamento = @equi)
							BEGIN
								INSERT INTO EXERCITO.utiliza_equipamento(soldado, equipamento, data_i, data_f) VALUES (@nCC, @equi, GETDATE(), NULL)
							END
						ELSE
							RAISERROR ('EQUIPAMENTO JA A SER UTILIZADO',1,1)
							RETURN
					END
				ELSE
					RAISERROR ('EQUIPAMENTO NAO EXISTE',1,1)
					RETURN
			END
		ELSE
			RAISERROR ('nCC N�O � UM SOLDADO',1,1)
			RETURN
	END
GO

/*
*	CRIAR ARMA
*/
DROP PROC EXERCITO.createArma
CREATE PROC EXERCITO.createArma @modelo VARCHAR(100), @tipo INT, @nSerie INT
AS
	DECLARE @lastid INT
	BEGIN
		INSERT INTO EXERCITO.equipamento(modelo) VALUES (@modelo)
		SELECT @lastid = SCOPE_IDENTITY()
		INSERT INTO EXERCITO.arma(idEqui, idTipo, nSerie) VALUES (@lastid, @tipo, @nSerie)
	END
GO

/*
*	CRIAR VEICULO
*/ 
DROP PROC EXERCITO.createVeiculo
CREATE PROC EXERCITO.createVeiculo @modelo VARCHAR(100), @tipo INT, @matricula INT
AS
	DECLARE @lastid INT
	BEGIN
		INSERT INTO EXERCITO.equipamento(modelo) VALUES (@modelo)
		SELECT @lastid = SCOPE_IDENTITY()
		INSERT INTO EXERCITO.veiculo(idEqui, idTipo, matricula) VALUES (@lastid, @tipo, @matricula)
	END
GO



/*
*	ELIMINAR EQUIPAMENTO
*/
CREATE PROC EXERCITO.deleteEquipamento @id INT
AS
	BEGIN
		DELETE FROM EXERCITO.utiliza_equipamento WHERE equipamento = @id
		DELETE FROM EXERCITO.veiculo WHERE idEqui = @id
		DELETE FROM EXERCITO.arma WHERE idEqui = @id
		DELETE FROM EXERCITO.equipamento WHERE id = @id
	END
GO

/*
*	TERMINAR MISSAO
*/
CREATE PROC EXERCITO.endMissao @id INT
AS
	BEGIN
		UPDATE EXERCITO.pelotao SET idMissao = NULL WHERE idMissao = @id
		UPDATE EXERCITO.veiculo SET idMissao = NULL WHERE idMissao = @id
		DELETE FROM EXERCITO.missao WHERE id = @id
	END
GO

/*
*	PROMOVER MILITAR
*/
CREATE PROC EXERCITO.promote @nCC INT, @id INT
AS
	BEGIN
		UPDATE EXERCITO.militar SET cargo=@id WHERE nCC = @nCC
	END

/*
*	MOVER MILITAR PARA BASE
*/
CREATE PROC EXERCITO.moveToBase @nCC INT, @base INT
AS
	BEGIN
		UPDATE EXERCITO.militar SET base=@base WHERE nCC=@nCC
	END
SELECT TOP 1 id FROM EXERCITO.especialidade
ORDER BY NEWID()

SELECT * FROM EXERCITO.engenheiro