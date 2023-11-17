'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
import random
numeros = [random.randint(1, 49)]
while len(numeros) < 5:
    numDuplicado =  True
    while numDuplicado:
        num = random.randint(1, 49)
        if (numeros.count(num) == 1):
            numDuplicado = True
        else:
            numDuplicado = False
    if not numDuplicado:
        numeros.append(num)
numeros.sort()
estrellas = [random.randint(1, 12)]
while True:
    estrella = random.randint(1, 12)
    if (estrellas.count(estrella) == 0):
        estrellas.append(estrella)
        break
estrellas.sort()

print("El EUROMILLONES que vas a jugar es: {} {} {} {} {} + {} {}".format(
    numeros[0], numeros[1], numeros[2], numeros[3], numeros[4], estrellas[0], estrellas[1]))