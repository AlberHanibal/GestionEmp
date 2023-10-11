'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
import math
masNumeros = "s"
numeros = []
print("Introduce números")
while masNumeros == "s":
    numeros.append(int(input()))
    print("¿Quieres introducir más números? (s/n)")
    masNumeros = input()
print("¿A qué potencia los quieres elevar?")
potencia = int(input())
for n in numeros:
    print("{} elevado a {} es {}".format(n, potencia, math.pow(n, potencia)))