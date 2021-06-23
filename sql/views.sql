CREATE VIEW EXERCITO.militar_info AS SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, pelotao, base, EXERCITO.cargo.cargo, EXERCITO.militarEmMissao(nCC) AS EmMissao, EXERCITO.subclass(nCC) AS tipo, estado_militar.estado
                           FROM EXERCITO.militar 
                           JOIN EXERCITO.cargo 
                           ON militar.cargo = cargo.id
                           JOIN EXERCITO.estado_militar
                           ON militar.estado = estado_militar.id

						   select * from exercito.militar_info


CREATE VIEW EXERCITO.missao_info AS
									SELECT missao.id,nome, tipo_missao.tipo, pais,brief, estado_missao.estado FROM EXERCITO.missao
									JOIN EXERCITO.tipo_missao
									ON missao.tipo = tipo_missao.id
									JOIN EXERCITO.estado_missao
									ON missao.estado = estado_missao.id


CREATE VIEW EXERCITO.pelotao_infos AS SELECT id, nome, Pnome, Unome, idMissao, militar.nCC  
										FROM EXERCITO.pelotao 
										LEFT JOIN EXERCITO.militar 
										ON militar.nCC=pelotao.nCC

CREATE VIEW EXERCITO.arma_infos AS SELECT * FROM EXERCITO.arma JOIN 
				    EXERCITO.equipamento
				    ON arma.idEqui = equipamento.id JOIN
				    EXERCITO.utiliza_equipamento 
				    ON utiliza_equipamento.equipamento = equipamento.id JOIN
				    EXERCITO.militar
				    ON militar.nCC = utiliza_equipamento.soldado

CREATE VIEW EXERCITO.veiculos_infos AS SELECT * FROM EXERCITO.veiculo JOIN 
				    EXERCITO.equipamento
				    ON veiculo.idEqui = equipamento.id JOIN
				    EXERCITO.utiliza_equipamento 
				    ON utiliza_equipamento.equipamento = equipamento.id JOIN
				    EXERCITO.militar
				    ON militar.nCC = utiliza_equipamento.soldado


CREATE VIEW EXERCITO.ramo_base_info AS	SELECT design, nome FROM
                                             EXERCITO.militar
                                             JOIN EXERCITO.base_militar
                                             ON militar.base = base_militar.id
                                             JOIN EXERCITO.ramo
                                             ON militar.ramo = ramo.id
                                             JOIN EXERCITO.tipo_ramo
                                             ON tipo_ramo.id = ramo.tipo
