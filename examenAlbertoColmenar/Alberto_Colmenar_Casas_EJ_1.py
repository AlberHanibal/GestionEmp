import random

categoria1 = []
categoria2 = []

def rellenarCategoria():
    categoria = []
    print("Dame una categoría")
    cat = input()
    print("Dame tres palabras relacionadas con ella:")
    print("1.")
    palabra1 = input()
    print("2.")
    palabra2 = input()
    print("3.")
    palabra3 = input()
    categoria.append(cat)
    categoria.append(palabra1)
    categoria.append(palabra2)
    categoria.append(palabra3)
    return categoria

def jugarCategoria(categoria):
    numIntentos = 0
    numeroPalabra = random.randint(1,3)
    print("Adivina: {}, tienes 5 intentos".format(categoria[numeroPalabra][0]))
    acierto = False
    while (numIntentos < 5 and not acierto):
        palabra = input()
        if (palabra == categoria[numeroPalabra]):
            acierto = True
        else:
            numIntentos += 1
    if (acierto):
        print("Has acertado!")
    return acierto


ganador = False
while (not ganador):
    print("Juego de DamnName")
    print("Turno del jugador 1")
    categoria1 = rellenarCategoria()
    categoria2 = rellenarCategoria()

    print("Turno del jugador 2")
    print("Elije entre una de las dos:")
    print("1. {}".format(categoria1[0]))
    print("2. {}".format(categoria2[0]))
    opcion = 0

    while (opcion != 1 and opcion != 2):
        opcion = int(input())

    # habría que sacarlo a un método, código opción 1 y 2 casi igual
    if (opcion == 1):
        print("Has elegido la categoría {}".format(categoria1[0]))
        seguirJugando = jugarCategoria(categoria1)
        if (seguirJugando):
            print("¿Quieres jugar con la otra categoría? (s/n)")
            seguir = input()
            if (seguir == "s"):
                print("La otra categoría es {}".format(categoria2[0]))
                jugarCategoria(categoria2)
                ganador = True
        else:
            print("No has acertado, juguemos con la otra categoría {}".format(categoria2[0]))
            ganador = jugarCategoria(categoria2)

    elif (opcion == 2):
        print("Has elegido la categoría {}".format(categoria2[0]))
        seguirJugando = jugarCategoria(categoria2)
        if (seguirJugando):
            print("¿Quieres jugar con la otra categoría? (s/n)")
            seguir = input()
            if (seguir == "s"):
                print("La otra categoría es {}".format(categoria1[0]))
                jugarCategoria(categoria1)
                ganador = True
        else:
            print("No has acertado, juguemos con la otra categoría {}".format(categoria1[0]))
            ganador = jugarCategoria(categoria1)

    if (not ganador):
        print("No has ganado, se reinicia el juego")
        print("------------------------")