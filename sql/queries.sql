-- Ver tipo, modelo e matricula de todos os veiculos
SELECT idEqui, matricula, EXERCITO.tipo_veiculo.modelo, EXERCITO.tipo_equipamento.tipo FROM EXERCITO.veiculo
																		JOIN EXERCITO.tipo_veiculo
																		ON idTipo = id
																		JOIN EXERCITO.tipo_equipamento
																		ON EXERCITO.tipo_equipamento.id = EXERCITO.tipo_veiculo.maintipo