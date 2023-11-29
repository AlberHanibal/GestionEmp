import pyodbc
from pyodbc import connect
cnxn = 0

# falta la funcion formatear


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


def añadirLibro(titulo, isbn, annoPublicacion, autor, editorial, genero, stock, idioma):
    cnxn = conectar()
    cursor = cnxn.cursor()
    cursor.execute("exec [biblio].[buscarNombreAutor] ?", autor)
    idAutor = cursor.fetchone()
    cursor.execute("exec [biblio].[añadirLibro] ?, ?, ?, ?, ?, ? ,?, ?", titulo,
                   isbn, annoPublicacion, idAutor[0], editorial, genero, stock, idioma)
    cursor.commit()
    desconectar(cnxn)


def añadirAutor(nombre, apellido, fechaNac, nacionalidad):
    cnxn = conectar()
    cursor = cnxn.cursor()
    cursor.execute("exec [biblio].[añadirAutor] ?, ?, ?, ?",
                   nombre, apellido, fechaNac, nacionalidad)
    cursor.commit()
    desconectar(cnxn)


def comprobarAutor(autor):
    cnxn = conectar()
    cursor = cnxn.cursor()
    cursor.execute("exec [biblio].[buscarNombreAutor] ?", autor)
    row = cursor.fetchone()
    if (row is not None):
        desconectar(cnxn)
        return True
    desconectar(cnxn)
    return False


def pedirDigito():
    comprobarDigito = False
    while (not comprobarDigito):
        num = input()
        comprobarDigito = num.isdigit()
        if (not comprobarDigito):
            print("Tienes que introducir un número")
    return int(num)


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
            else:
                print("No tenemos a ese autor. Vamos a añadirlo.")
                print("Dame su nombre")
                nombre = input()
                print("Dame su apellido")
                apellido = input()
                print("Dame su fecha de nacimiento (YYYY/MM/DD)")
                fechaNac = input()
                # comprobar fecha
                print("Dame su nacionalidad")
                nacionalidad = input()
                añadirAutor(nombre, apellido, fechaNac, nacionalidad)
                autor = nombre + " " + apellido
                print("Autor añadido.")
            print("Dame la editorial")
            editorial = input()
            print("Dame el genero")
            genero = input()
            print("Dame el stock")
            stock = pedirDigito()
            print("Dame el idioma")
            idioma = input()
            añadirLibro(titulo, isbn, annoPublicacion, autor,
                        editorial, genero, stock, idioma)
