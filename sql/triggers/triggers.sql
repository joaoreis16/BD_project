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
	DECLARE @cargo	INT
	DECLARE @base	INT
	DECLARE @mil_base INT
	IF UPDATE(nCC)
		BEGIN
		SELECT @targetCC = nCC, @base = id FROM INSERTED
		SELECT @cargo = cargo, @mil_base = base FROM EXERCITO.militar WHERE nCC = @targetCC
		PRINT @targetCC
		IF (@targetCC IS NULL)
			BEGIN
				UPDATE EXERCITO.base_militar
				/*TODO : GUARDAR RECORD DE GENERAL ANTIGO */
				SET nCC = NULL, data_inicio = NULL, data_fim = NULL
				WHERE id = @base
				RETURN
			END

		IF @cargo > 3
			BEGIN
				RAISERROR ('CARGO DE MILITAR INSUFICIENTE PARA POSIÇAO',1,1)
				ROLLBACK TRANSACTION
			END
		ELSE
			IF (@base != @mil_base)
				BEGIN
					RAISERROR ('MILITAR PERTENCE A OUTRA BASE',1,1)
					ROLLBACK TRANSACTION
				END
			ELSE
				UPDATE EXERCITO.base_militar
				/*TODO : GUARDAR RECORD DE CAPITAO ANTIGO */
				SET nCC = @targetCC, data_inicio = GETDATE(), data_fim = NULL
				WHERE id = @base

		END
GO

----------------EQUIPAMENTO------------------------

------------------MILITAR------------------------

/*
 *	IMPEDE QUE SEJAM ADICIONADOS MILITARES A BASES COM
 *	A CAPACIDADE MÁXIMA JÁ OCUPADA 
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
			RAISERROR ('CAPACIDADE MÁXIMA EXCEDIDA',1,1)
			ROLLBACK TRANSACTION
			END
	END

GO

-------------------PELOTAO-------------------------

/*
*	CERTIFICA QUE UM PELOTAO TEM SOMENTE UM CAPITAO
*	E (OPCIONALMENTE) UM GENEREAL. CASEO HAJA UM 
*	GENEREAL, SERÁ ELE O REPRESENTANTE DO PELOTAO
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
			SELECT @pelID = pelotao FROM INSERTED
			SELECT @targetCC = nCC FROM INSERTED
			SELECT @cargo = cargo FROM EXERCITO.militar WHERE nCC = @targetCC
			SELECT @CCinCharge = nCC FROM EXERCITO.pelotao WHERE id = @pelID

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
							RAISERROR ('JÁ EXISTE UM GENERAL NO PELOTAO',1,1)
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
	IF UPDATE(nCC)
		BEGIN			
		SELECT @targetCC = nCC, @ramo = id FROM INSERTED
		IF (@targetCC IS NULL)
			BEGIN
				UPDATE EXERCITO.ramo
				/*TODO : GUARDAR RECORD DE GENERAL ANTIGO */
				SET nCC = NULL, data_inicio = NULL, data_fim = NULL
				WHERE id = @ramo
				RETURN
			END

		SELECT @cargo = cargo, @mil_ramo = ramo FROM EXERCITO.militar WHERE nCC = @targetCC

		IF @cargo != 1
			BEGIN
			RAISERROR ('CARGO DE MILITAR INSUFICIENTE PARA POSIÇAO',1,1)
			ROLLBACK TRANSACTION
			END
		ELSE
			IF EXISTS (SELECT * FROM EXERCITO.ramo WHERE nCC = @targetCC)
				BEGIN
				RAISERROR ('MILITAR JÁ CEME DE OUTRO RAMO',1,1)
				ROLLBACK TRANSACTION
				END
			ELSE IF (@ramo != @mil_ramo)
				BEGIN
				RAISERROR ('MILITAR PERTENCE A OUTRO RAMO',1,1)
				ROLLBACK TRANSACTION
				END
			ELSE
				UPDATE EXERCITO.ramo
				/*TODO : GUARDAR RECORD DE GENERAL ANTIGO */
				SET nCC = @targetCC, data_inicio = GETDATE(), data_fim = NULL
				WHERE id = @ramo

		END
GO

------------------SOLDADO------------------------

/*
*	VERIFICAR QUE O TIPO DE SOLDADO DA MATCH AO SEU RAMO
*/
DROP TRIGGER EXERCITO.soldado_ramo_match
CREATE TRIGGER soldado_ramo_match ON EXERCITO.soldado
AFTER INSERT, UPDATE
AS
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
GO


