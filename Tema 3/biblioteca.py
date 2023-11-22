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

def desconectar():
    cnxn.close()


def añadirLibro():

    conectar()

    desconectar()