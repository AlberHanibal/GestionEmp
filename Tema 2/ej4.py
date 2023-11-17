'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
print("Dame un número")
numero = int(input())
suma = 0
for x in range(1,numero + 1):
    suma += x
print("La suma de los primeros {} números es {}".format(numero, suma))