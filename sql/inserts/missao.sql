SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, EXERCITO.cargo.cargo
                           FROM EXERCITO.militar 
                           JOIN EXERCITO.cargo 
                           ON EXERCITO.militar.cargo = EXERCITO.cargo.id
                           WHERE Pnome LIKE '%Cob%' OR Unome LIKE '%Cob%'

SELECT * FROM EXERCITO.militar