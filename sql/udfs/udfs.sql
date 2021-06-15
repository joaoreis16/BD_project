/*
*	RETORNA 0 SE MILITAR DE nCC JA EXISTE EM SOLDADO
*	MEDICO OU ENGENHEIRO
*/
ALTER FUNCTION EXERCITO.disjointMilitar (@nCC INT)
RETURNS BIT
AS
BEGIN
	IF EXISTS (SELECT * FROM EXERCITO.soldado WHERE nCC = @nCC)
	OR EXISTS (SELECT * FROM EXERCITO.medico WHERE nCC = @nCC)
	OR EXISTS (SELECT * FROM EXERCITO.engenheiro WHERE nCC = @nCC)
		BEGIN
			RETURN 0
		END
	RETURN 1
END
GO

SELECT * FROM EXERCITO.equipamento
SELECT * FROM EXERCITO.arma

/*
*	RETORNA 0 SE EQUIPAMENTO JA ESTA A SER UTILIZADO
*	RETORNA 1 SE ESTIVER LIVRE
*/
CREATE FUNCTION EXERCITO.equipIsAvailable (@id INT)
RETURNS BIT
AS
BEGIN
	IF EXISTS (SELECT * FROM EXERCITO.utiliza_equipamento WHERE equipamento=@id)
		RETURN 0
	RETURN 1
END


/*
*
*	RETORNA TABLE COM O CONJUNTO DE NACIONALIDADES DOS MILITARES
*/
CREATE FUNCTION EXERCITO.getNacionalidades() RETURNS @nac TABLE (id INT, nacionalidade VARCHAR(50))
AS
	BEGIN
		DECLARE @id INT
		DECLARE @nacionalidade VARCHAR(50)
		
		DECLARE cur CURSOR FAST_FORWARD 
		FOR SELECT DISTINCT nacionalidade FROM EXERCITO.militar
		OPEN cur;

		FETCH cur INTO @nacionalidade
		SELECT @id=1

		WHILE @@FETCH_STATUS = 0
			BEGIN
				INSERT INTO @nac VALUES(@id, @nacionalidade)
				SELECT @id = @id + 1
				FETCH cur INTO @nacionalidade
			END
		CLOSE cur;
		DEALLOCATE cur;

		RETURN

	END
GO

SELECT * FROM EXERCITO.getNacionalidades()

CREATE FUNCTION EXERCITO.basesOfRamos(@r1 BIT, @r2 BIT, @r3 BIT) RETURNS @tab TABLE (id INT)
AS
	BEGIN
		DECLARE @id INT
		DECLARE @cnt INT

		SELECT @cnt = 0

		DECLARE cur CURSOR FAST_FORWARD 
		FOR SELECT DISTINCT id FROM EXERCITO.base_militar
		OPEN cur;

		FETCH cur INTO @id

		WHILE @@FETCH_STATUS = 0
			BEGIN
				IF NOT ( ((@r1 = 1) AND NOT EXISTS (SELECT * FROM EXERCITO.base_ramo WHERE idBase = @id AND idRamo = 1))
					OR ((@r2 = 1) AND NOT EXISTS (SELECT * FROM EXERCITO.base_ramo WHERE idBase = @id AND idRamo = 2))
					OR ((@r3 = 1) AND NOT EXISTS (SELECT * FROM EXERCITO.base_ramo WHERE idBase = @id AND idRamo = 3)) )
					BEGIN
						INSERT INTO @tab VALUES (@id)
					END
				FETCH cur INTO @id
			END
		CLOSE cur;
		DEALLOCATE cur;

		RETURN
	END
GO

/*
* -1 -> MILITAR NAO EM MISSAO
* idMissao -> MILITAR EM MISSAO
*/

CREATE FUNCTION EXERCITO.militarEmMissao (@nCC INT) RETURNS INT
AS
	BEGIN
		DECLARE @id INT
		SELECT @id = pelotao.idMissao FROM EXERCITO.militar JOIN EXERCITO.pelotao
								ON	militar.pelotao = pelotao.id
								WHERE militar.nCC = @nCC
		IF @id IS NOT NULL
			BEGIN
				RETURN @id
			END

		RETURN -1
	END


/*
*	RETORNA TODOS OS MILITARES QUE PARTICIPARAM NA MISSAO @id
*/

CREATE FUNCTION EXERCITO.militaresDaMissao (@id INT) RETURNS @mils TABLE (nCC INT)
AS
	BEGIN
		DECLARE @nCC INT
		
		Insert into @mils SELECT militar.nCC FROM EXERCITO.militar JOIN
					EXERCITO.pelotao ON pelotao = pelotao.id
					JOIN EXERCItO.missao ON pelotao.idMissao = missao.id
					WHERE missao.id = 5	
					
		RETURN	

	END



