import pyodbc
import random

def create_armas(num):
    modelos = {
        1:["Glock 17 Gen 5", "Heckler & Koch P30"],
        2:["Heckler & Koch MP5"],
        3:["Barrett M107","Arctic Warfare"],
        4:["Franchi SPAS-15","Benelli Super Nova"],
        5:["MG3", "M4A4","M4A1","Browning M2"],
        6:["Milkor MGL", "Mk 19 mod 3"],
        7:["Heckler & Koch HK416","SCAR-H STD"]
    }

    cursor.execute('''
                    SELECT id FROM EXERCITO.tipo_arma
                    ''')

    tipos = [row[0] for row in cursor.fetchall()]

    for i in range(1,num):
        t = tipos[random.randrange(1,len(tipos))]
        m = modelos[t][random.randrange(0,len(modelos[t]))]
        serie = random.randrange(111111,999999)

        cursor.execute(f'''
                        EXEC EXERCITO.createArma '{m}', {t}, {serie}
                        ''')

        print(f"ADDED ARMA {serie}")

    conn.commit()
        

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


def create_veiculos(num):   
    modelos = {
        1:["Leopard 2", "M577A2", "M113 BGM-71 TOW", "Pandur II"],
        2:["Unimog 1750L","MAN KAT1","Iveco 90.17 WM","DAF Trucks YA 4440 D"],
        3:["MQM-170A Outlaw","Tekever AR4"],
        4:["NRP Arpão","NRP Tridente"],
        5:["NRP Hidra"],
        6:["NRP Vasco da Gama","NRP Corte-Real"],
        7:["EH101 Merlin","AgustaWestland AW119 Koala"],
        8:["F-16 Fighting Falcon"],
        9:["C-130 Hercules","C-130 Hercules"]
    }

    cursor.execute('''
                    SELECT id FROM EXERCITO.tipo_veiculo
                    ''')

    tipos = [row[0] for row in cursor.fetchall()]

    for i in range(1,num):
        t = tipos[random.randrange(1,len(tipos))]
        m = modelos[t][random.randrange(0,len(modelos[t]))]
        matricula = random.randrange(111111,999999)

        cursor.execute(f'''
                        EXEC EXERCITO.createVeiculo '{m}', {t}, {matricula}
                        ''')

        print(f"ADDED VEICULO {matricula}")

    conn.commit()
        

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
    bases={}
    cursor.execute('''
                    SELECT nCC FROM EXERCITO.militar
                    ''')

    nCCs = [row[0] for row in cursor.fetchall()]

    ramos = [1,2,3]

    for r in ramos:
        cursor.execute(f'''
                        SELECT idBase FROM EXERCITO.base_ramo WHERE idRamo={r}
                        ''')

        bases[r] = [row[0] for row in cursor.fetchall()]

    for nCC in nCCs:
        cursor.execute(f'''
                        SELECT ramo, cargo FROM EXERCITO.militar
                        WHERE nCC = {nCC}
                        ''')

        ramo = [row[0] for row in cursor.fetchall()][0]
        while(True):
            try:
                b = bases[ramo][random.randrange(len(bases[ramo]))]

                cursor.execute(f'''
                                EXEC EXERCITO.moveToBase {nCC}, {b}
                                ''')
                break
            except pyodbc.ProgrammingError:
                print(f"BASE {b} FULL")

        print(f"MOVED {nCC} to base {b}")
        conn.commit()


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
    print(f"soldados : {sol} \nmedicos : {med}\nengenheiros : {eng}\n")


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



