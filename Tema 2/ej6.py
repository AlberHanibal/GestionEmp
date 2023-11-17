'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
import random
prima = [random.randint(1, 49)]
while len(prima) < 6:
    numDuplicado =  True
    while numDuplicado:
        num = random.randint(1, 49)
        if (prima.count(num) == 1):
            numDuplicado = True
        else:
            numDuplicado = False
    if not numDuplicado:
        prima.append(num)
prima.sort()
print(prima)