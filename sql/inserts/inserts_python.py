import pyodbc
import random


def insert_base_ramo():
    cursor.execute('''
                SELECT id FROM EXERCITO.base_militar
                ''')

    baseids = [row[0] for row in cursor.fetchall()]

    cursor.execute('''
                    SELECT id from EXERCITO.ramo
                    ''')

    ramoids = [row[0] for row in cursor.fetchall()]

    for base in baseids:
        for ids in random.sample(ramoids,random.randint(1,len(ramoids))):
            cursor.execute(f'''
                            INSERT INTO EXERCITO.base_ramo(idBase, idRamo)
                            VALUES ({base}, {ids})
                            ''')

    conn.commit()

def move_to_base():
    cursor.execute('''
                    SELECT id FROM EXERCITO.base_militar
                    ''')

    baseids = [row[0] for row in cursor.fetchall()]

    cursor.execute('''
                    SELECT id from EXERCITO.ramo
                    ''')

    ramoids = [row[0] for row in cursor.fetchall()]

def create_subclasses():

    probs = ['S','S','S','S','M','M','E']

    cursor.execute('''
                    SELECT nCC FROM EXERCITO.militar
                    ''')

    nCCs = [row[0] for row in cursor.fetchall()]

    sol=0
    med=0
    eng=0

    for nCC in nCCs:
        subclass = probs[random.randrange(len(probs))]
        cursor.execute(f'''
                        SELECT ramo FROM EXERCITO.militar
                        WHERE nCC = {nCC}
                        ''')
        ramo = [row[0] for row in cursor.fetchall()][0]

        if subclass == 'S':
            cursor.execute(f'''
                            SELECT TOP 1 id FROM EXERCITO.tipo_soldado WHERE ramo={ramo}
                            ORDER BY NEWID()
                            ''')
            sol_type = [row[0] for row in cursor.fetchall()][0]

            cursor.execute(f'''
                            EXEC EXERCITO.createSoldado {nCC}, {sol_type}
                            ''')
            sol+=1


        elif subclass == 'M':
            cursor.execute(f'''
                            SELECT TOP 1 id FROM EXERCITO.especialidade
                            ORDER BY NEWID()
                            ''')

            med_espec = [row[0] for row in cursor.fetchall()][0]

            cursor.execute(f'''
                    EXEC EXERCITO.createMedico {nCC}, {med_espec}
                    ''')

            med+=1

        elif subclass == 'E':
            cursor.execute(f'''
                    EXEC EXERCITO.createEngenheiro {nCC}
                    ''')

            eng+=1

    conn.commit()
    print(f"soldados : {sold} \nmedicos : {med}\nengenheiros : {eng}\n")


if __name__ == '__main__':
    global conn 
    global cursor

    conn = pyodbc.connect('Driver={SQL Server};'
                        'Server=tcp:mednat.ieeta.pt\SQLSERVER,8101;'
                        'Database=p9g6;'
                        'UID=p9g6;'
                        'PWD=-99745397@BD;'
                        'Trusted_Connection=no;')

    cursor = conn.cursor()



