import pyodbc
from pyodbc import connect

# Some other example server values are
# server = 'localhost\sqlexpress' # for a named instance
# server = 'myserver,port' # to specify an alternate port
server = 'C13-PC16\SQLEXPRESS01'
database = 'empresa'
username = 'librero'
password = 'librero'
# ENCRYPT defaults to yes starting in ODBC Driver 18. It's good to always specify ENCRYPT=yes on the client side to avoid MITM attacks.
cnxn = pyodbc.connect(
    'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';ENCRYPT=no;UID=' + username + ';PWD=' + password)

cursor = cnxn.cursor()

#Sample select query
cursor.execute("exec [PRUEBA].[pNuevo] null, null, null")
row = cursor.fetchone()
while row:
    print(row)
    row = cursor.fetchone()