-----------------BASE MILITAR--------------------

/*
*	VERIFICA QUE O GENERAL DA BASE PERTENCE A BASE
*	QUE REPRESENTA	
*/
DROP TRIGGER EXERCITO.base_has_unique_captain
CREATE TRIGGER base_has_unique_captain ON EXERCITO.base_militar
INSTEAD OF UPDATE
AS
	SET NOCOUNT ON;
	DECLARE @targetCC INT
	DECLARE @curCC INT
	DECLARE @cargo	INT
	DECLARE @base	INT
	DECLARE @mil_base INT
	DECLARE @di DATE
	IF UPDATE(nCC)
		BEGIN
		SELECT @targetCC = nCC, @base = id FROM INSERTED
		SELECT @di = data_inicio, @curCC = nCC FROM EXERCITO.base_militar WHERE @base = id
		SELECT @cargo = cargo, @mil_base = base FROM EXERCITO.militar WHERE nCC = @targetCC
		PRINT @targetCC
		IF (@targetCC IS NULL)
			BEGIN
				INSERT INTO EXERCITO.historico_base(nCC, base, data_inicio) VALUES (@curCC, @base, @di)
				UPDATE EXERCITO.base_militar
				/*TODO : GUARDAR RECORD DE GENERAL ANTIGO */
				SET nCC = NULL, data_inicio = NULL, data_fim = NULL
				WHERE id = @base
				RETURN
			END

		IF @cargo > 3
			BEGIN
				RAISERROR ('CARGO DE MILITAR INSUFICIENTE PARA POSI?AO',1,1)
				ROLLBACK TRANSACTION
			END
		ELSE
			IF (@base != @mil_base)
				BEGIN
					RAISERROR ('MILITAR PERTENCE A OUTRA BASE',1,1)
					ROLLBACK TRANSACTION
				END
			ELSE
				INSERT INTO EXERCITO.historico_base(nCC, base, data_inicio) VALUES (@curCC, @base, @di)
				UPDATE EXERCITO.base_militar
				/*TODO : GUARDAR RECORD DE CAPITAO ANTIGO */
				SET nCC = @targetCC, data_inicio = GETDATE(), data_fim = NULL
				WHERE id = @base

		END
GO

----------------EQUIPAMENTO------------------------

/*
*	GUARDA NO HISTORICO UMA PARAGEM DE UTILIZA?AO 
*	DE EQUIPAMENTO
*/

------------------MILITAR------------------------

/*
 *	IMPEDE QUE SEJAM ADICIONADOS MILITARES A BASES COM
 *	A CAPACIDADE M?XIMA J? OCUPADA 
*/
DROP TRIGGER EXERCITO.base_increment
CREATE TRIGGER base_increment ON EXERCITO.militar
AFTER INSERT, UPDATE, DELETE
AS
	BEGIN
		SET NOCOUNT ON;
		DECLARE @base_id int;
		DECLARE @cur_militares int; 
		DECLARE @max_militares int;

		IF NOT EXISTS(SELECT * FROM INSERTED)
			BEGIN
			SELECT @base_id = base FROM DELETED
			END
		ELSE
			BEGIN
			IF NOT EXISTS(SELECT * FROM DELETED)
				SELECT @base_id = base FROM INSERTED
			ELSE
				SELECT @base_id = base FROM INSERTED
			END

		SELECT @cur_militares = COUNT(base) FROM EXERCITO.militar WHERE base=@base_id;
		SELECT @max_militares = maxMilitares FROM EXERCITO.base_militar WHERE id = @base_id
		
		IF (@max_militares < @cur_militares)
			BEGIN
			RAISERROR ('CAPACIDADE M?XIMA EXCEDIDA',1,1)
			ROLLBACK TRANSACTION
			END
	END

GO

-------------------PELOTAO-------------------------

/*
*	CERTIFICA QUE UM PELOTAO TEM SOMENTE UM CAPITAO
*	E (OPCIONALMENTE) UM GENEREAL. CASEO HAJA UM 
*	GENEREAL, SER? ELE O REPRESENTANTE DO PELOTAO
*/
DROP TRIGGER EXERCITO.unique_captain
CREATE TRIGGER unique_captain ON EXERCITO.militar
AFTER UPDATE
AS
	BEGIN
		SET NOCOUNT ON;
		DECLARE @cargo INT
		DECLARE @targetCC INT
		DECLARE @pelID INT
		DECLARE @CCinCharge INT
		DECLARE @CargoinCharge INT
		IF UPDATE(pelotao)
		BEGIN
			SELECT @pelID = pelotao FROM INSERTED
			SELECT @targetCC = nCC FROM INSERTED
			SELECT @cargo = cargo FROM EXERCITO.militar WHERE nCC = @targetCC
			SELECT @CCinCharge = nCC FROM EXERCITO.pelotao WHERE id = @pelID

			IF (@pelID IS NULL)
				RETURN

			IF @cargo = 5
				RETURN

			IF @cargo = 3 AND NOT EXISTS (SELECT * FROM EXERCITO.militar WHERE
												pelotao = @pelID AND cargo = 3 AND nCC != @targetCC)
				BEGIN
				IF @CCinCharge is NULL
					BEGIN
						UPDATE EXERCITO.pelotao
						SET nCC = @targetCC
						WHERE id = @pelID
						RETURN
					END
				ELSE
					SELECT @CargoinCharge = cargo FROM EXERCITO.militar WHERE nCC = @CCinCharge
					IF @CargoinCharge = 3
						BEGIN
							RAISERROR ('J? EXISTE UM GENERAL NO PELOTAO',1,1)
							ROLLBACK TRANSACTION
						END
					ELSE
						UPDATE EXERCITO.pelotao
						SET nCC = @targetCC
						WHERE id = @pelID
						RETURN
				END
			ELSE IF @cargo = 4 AND NOT EXISTS (SELECT * FROM EXERCITO.militar WHERE
												pelotao = @pelID AND cargo = 4 AND nCC != @targetCC)
				BEGIN
				IF @CCinCharge is NULL
					BEGIN
						UPDATE EXERCITO.pelotao
						SET nCC = @targetCC
						WHERE id = @pelID
					END
				RETURN
				END

			ELSE 
				RAISERROR ('CARGO INVALIDO E/OU GENERAL/CAPITAO JA SELECIONADOS',1,1)
				ROLLBACK TRANSACTION
		END
		ELSE
			RETURN
	END		
GO

---------------------RAMO------------------------

/* 
*	VERIFICA QUE O CEME DO RAMO COMANDO UM UNICO RAMO
*	E QUE REPRESENTA O RAMO A QUE PERTENCE
*/
DROP TRIGGER EXERCITO.ramo_has_unique_CEME
CREATE TRIGGER ramo_has_unique_CEME ON EXERCITO.ramo
INSTEAD OF UPDATE
AS
	SET NOCOUNT ON;
	DECLARE @targetCC INT
	DECLARE @cargo	INT
	DECLARE @ramo	INT
	DECLARE @mil_ramo INT
	DECLARE @cur_CC INT
	DECLARE @di DATE
	IF UPDATE(nCC)
		BEGIN			
		SELECT @targetCC = nCC, @ramo = id FROM INSERTED
		SELECT @cur_CC = nCC, @di = data_inicio FROM EXERCITO.ramo WHERE id = @ramo
		IF (@targetCC IS NULL)
			BEGIN
				INSERT INTO EXERCITO.historico_ramo(nCC, ramo, data_inicio) VALUES (@cur_CC, @ramo, @di)
				UPDATE EXERCITO.ramo
				/*TODO : GUARDAR RECORD DE GENERAL ANTIGO */
				SET nCC = NULL, data_inicio = NULL, data_fim = NULL
				WHERE id = @ramo
				RETURN
			END

		SELECT @cargo = cargo, @mil_ramo = ramo FROM EXERCITO.militar WHERE nCC = @targetCC

		IF @cargo != 1
			BEGIN
			RAISERROR ('CARGO DE MILITAR INSUFICIENTE PARA POSI?AO',1,1)
			ROLLBACK TRANSACTION
			END
		ELSE
			IF EXISTS (SELECT * FROM EXERCITO.ramo WHERE nCC = @targetCC)
				BEGIN
				RAISERROR ('MILITAR J? CEME DE OUTRO RAMO',1,1)
				ROLLBACK TRANSACTION
				END
			ELSE IF (@ramo != @mil_ramo)
				BEGIN
				RAISERROR ('MILITAR PERTENCE A OUTRO RAMO',1,1)
				ROLLBACK TRANSACTION
				END
			ELSE
				INSERT INTO EXERCITO.historico_ramo(nCC, ramo, data_inicio) VALUES (@cur_CC, @ramo, @di)
				UPDATE EXERCITO.ramo
				/*TODO : GUARDAR RECORD DE GENERAL ANTIGO */
				SET nCC = @targetCC, data_inicio = GETDATE(), data_fim = NULL
				WHERE id = @ramo

		END
GO

------------------MILITAR------------------------

------------------SOLDADO------------------------

/*
*	VERIFICAR QUE O TIPO DE SOLDADO DA MATCH AO SEU RAMO
*/
DROP TRIGGER EXERCITO.soldado_ramo_match
CREATE TRIGGER soldado_ramo_match ON EXERCITO.soldado
AFTER INSERT, UPDATE
AS
	IF UPDATE(tipo)
	BEGIN
		SET NOCOUNT ON
		DECLARE @tipo_inserted INT
		DECLARE @ramo_inserted INT
		DECLARE	@nCC	INT
		DECLARE @ramo_militar INT


		SELECT @tipo_inserted = tipo FROM INSERTED
		SELECT @ramo_inserted = ramo FROM EXERCITO.tipo_soldado WHERE id = @tipo_inserted
		SELECT @nCC = nCC FROM INSERTED
		SELECT @ramo_militar = ramo FROM EXERCITO.militar WHERE nCC = @nCC

		IF (@ramo_inserted != @ramo_militar)
			BEGIN
				RAISERROR ('TIPO DE SOLDADO INCOMPATIVEL COM RAMO',1,1)
				ROLLBACK TRANSACTION
			END
	END
GO


/*
*	VERIFICAR QUE BASE DO MILITAR ABRANGE O SEU RAMO
*/
CREATE TRIGGER militar_base_ramo_match ON EXERCITO.militar
AFTER INSERT,UPDATE
AS
	IF UPDATE(base) OR UPDATE(ramo)
		BEGIN
		DECLARE @base INT
		DECLARE @ramo INT

		SELECT @base=base FROM INSERTED
		SELECT @ramo=ramo FROM INSERTED

			IF NOT EXISTS (SELECT * FROM EXERCITO.base_ramo WHERE idBase = @base AND idRamo = @ramo) AND (@base IS NOT NULL)
			BEGIN
				RAISERROR ('BASE NAO ABRANGE RAMO DO MILITAR',1,1)
				ROLLBACK TRANSACTION
			END
		END


SELECT * FROM EXERCITO.tipo_veiculo
SELECT matricula, tipo, modelo FROM EXERCITO.veiculo
							JOIN EXERCITO.equipamento
							ON idEqui = EXERCITO.equipamento.id
							JOIN EXERCITO.tipo_veiculo
							ON idTipo = EXERCITO.tipo_veiculo.id


/*
*	GUARDA REGISTO DA MISSAO
*/
		