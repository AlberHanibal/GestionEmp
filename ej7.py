'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''
import random
posibilidades = ["1", "x", "2"]
for x in range(1,16):
    resultado = random.choice(posibilidades)
    linea = str(x) + ". "
    if resultado == "1":
        linea += "1"
    elif resultado == "x":
        linea += " X"
    elif resultado == "2":
        linea += "  2"
    print(linea)