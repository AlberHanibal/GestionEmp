import pyodbc
from pyodbc import connect
cnxn = 0

def conectar():
    server = 'C13-PC16\SQLEXPRESS01'
    database = 'LIBRERIA'
    username = 'librero'
    password = 'librero'
    cnxn = pyodbc.connect(
    'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';ENCRYPT=no;UID=' + username + ';PWD=' + password)
    return cnxn

def desconectar(cnxn):
    cnxn.close()


def añadirLibro():
    cnxn = conectar()
    cursor = cnxn.cursor()

    desconectar()

def pedirDigito():
    comprobarDigito = False;
    while (not comprobarDigito):
        num = input()
        comprobarDigito = num.isdigit()
        if (not comprobarDigito):
            print("Tienes que introducir un número")
    return int(num)

def comprobarAutor(autor):
    cnxn = conectar()
    cursor = cnxn.cursor()
    cursor.execute("exec [biblio].[buscarNombreAutor] \'" + autor + "\'")
    # hay que usar row no se bien como
    if (cursor.rowcount) > 0:
        desconectar(cnxn)
        return True
    desconectar(cnxn)
    return False


opcion = 0
while (not opcion == 5):
    print('''
*********************************************************
*			BIBLIOTECA			*
*	1.- Nuevo libro					*
*	2.- Búsqueda					*
*	3.- Borrar libro				*
*	------------------------------			*
*	4.- Modificar libro				*
*	5.- Salir					*
*							*
*********************************************************
''')
    opcion = pedirDigito()
    match opcion:
        case 1:
            print("Dame su título.")
            titulo = input()
            print("Dame su ISBN.")
            isbn = pedirDigito()
            print("Dame su año de publicación.")
            annoPublicacion = pedirDigito()
            print("Dame el nombre y apellido del autor.")
            autor = input()
            if comprobarAutor(autor):
                print("El autor existe")
            




