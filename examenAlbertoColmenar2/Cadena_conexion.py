import pyodbc
from pyodbc import connect

server = 'LAPTOP-9FQ8DH6I\SQLEXPRESS'
database = 'PEDIDOS'
username = 'librero'
password = '7894'

cnxn = pyodbc.connect(
    'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';ENCRYPT=no;UID=' + username + ';PWD=' + password)

cursor = cnxn.cursor()

cursor.execute("SELECT * FROM PEDIDOS..CATEGORIAS;")
row = cursor.fetchone()
while row:
    print(row)
    row = cursor.fetchone()

   
