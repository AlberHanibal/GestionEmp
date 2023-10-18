import random
import time
import math

jugar = "s"
numeroValido = False
while (jugar == "s"):
    while (not numeroValido):
        print("Introduce un número de 0 - 36.")
        numeroJugado = int (input())
        numeroValido = (numeroJugado >= 0 and numeroJugado <= 36)
    print("¿Cuánto dinero quiere apostar?")
    apuesta = int(input())
    print("¡No va más!")
    for x in range(5):
        time.sleep(1)
        numRuleta = random.randint(0,36)
        print(numRuleta)
    if (numRuleta == numeroJugado):
        if (numeroJugado < 15):
            ganancia = apuesta * 2
        elif (numeroJugado < 30):
            ganancia = apuesta * 3
        else:
            ganancia = math.pow(apuesta, 2)
        print("Has ganado {}€".format(ganancia))
    else:
        print("La banca siempre gana.")
    print("¿Quieres jugar de nuevo? (s/n)")
    jugar = input()
