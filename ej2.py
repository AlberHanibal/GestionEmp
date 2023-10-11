'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
# Consiste en cada vez que introduces un número comprobar si ha sido el mayor que se ha introducido previamente
print("Introduce 4 números")
numMayor = 0
num1 = int (input())
if num1 > numMayor:
    print("EL PRIMERO ES EL MAYOR")
    numMayor = num1
num2 = int (input())
if num2 > numMayor:
    print("EL SEGUNDO ES EL MAYOR")
    numMayor = num2
else:
    print("EL SEGUNDO ES EL MENOR")
num3 = int (input())
if num3 > numMayor:
    print("EL TERCERO ES EL MAYOR")
    numMayor = num3
else:
    print("EL TERCERO ES EL MENOR")
num4 = int (input())
if num4 > numMayor:
    print("EL CUARTO ES EL MAYOR")
    numMayor = num4
else:
    print("EL CUARTO ES EL MENOR")