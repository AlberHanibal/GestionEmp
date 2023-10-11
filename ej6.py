'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
import random
prima = [random.randint(1, 49)]
numDuplicado = True
x = 0
while len(prima) < 6:
    num = random.randint(1, 49)
    while numDuplicado:
        if (prima.count(num) == 1):
            numDuplicado = True
            num = random.randint(1, 49)
        else:
            numDuplicado = False
    if not numDuplicado:
        prima.append(num)
prima.sort()
print(prima)