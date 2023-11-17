'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
import random
numero = random.randint(1,100)
print("Encuentra el número del 1 al 100")
for x in range(1,7):
    print("Intento {}º".format(x))
    intento = int(input())
    if intento < numero:
        print("Mayor")
    elif intento > numero:
        print("Menor")
    else:
        print("Enhorabuena")
        break
