'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
print("¿Quieres ejecutar mis ejercicios?")
print("""
    1.  Hola Mundo.
    2.  Mayor 4 números.
    3.  IVA de cosas.
    4.  Suma de números naturales.
    5.  Número aleatorio.
    6.  Primitiva.
    7.  Quiniela.
    8.  Euromillón.
    9.  Encuentra el número.
    11. Potencia de números.
""")
opcion = int(input())
if opcion == 1:
    exec(open("ej1.py").read())
elif opcion == 2:
    exec(open("ej2.py").read())
elif opcion == 3:
    exec(open("ej3.py").read())
elif opcion == 4:
    exec(open("ej4.py").read())
elif opcion == 5:
    exec(open("ej5.py").read())
elif opcion == 6:
    exec(open("ej6.py").read())
elif opcion == 7:
    exec(open("ej7.py").read())
elif opcion == 8:
    exec(open("ej8.py").read())
elif opcion == 9:
    exec(open("ej9.py").read())
elif opcion == 11:
    exec(open("ej11.py").read())