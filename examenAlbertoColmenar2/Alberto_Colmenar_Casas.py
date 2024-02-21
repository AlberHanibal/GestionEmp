import math
import random
import pyodbc
from pyodbc import connect

class Jugador:
    def __init__(self, num, apuesta, nick):
        self.jugada = 0
        self.estado = ""
        self.num = num
        self.apuesta = apuesta
        self.nick = nick


valorCartas = {
    "1" : 1,
    "2" : 2,
    "3" : 3,
    "4" : 4,
    "5" : 6,
    "6" : 6,
    "7" : 7,
    "8" : 8,
    "9" : 9,
    "sota" : 0.5,
    "caballo" : 0.5,
    "rey" : 0.5
}
baraja = {
    "1" : 4,
    "2" : 4,
    "3" : 4,
    "4" : 4,
    "5" : 4,
    "6" : 4,
    "7" : 4,
    "8" : 4,
    "9" : 4,
    "sota" : 4,
    "caballo" : 4,
    "rey" : 4
}

cartas = ["1","2","3","4","5","6","7","8","9","sota","caballo","rey"]

jugadores = []

def inicializarJuego():
    baraja = {
    "1" : 4,
    "2" : 4,
    "3" : 4,
    "4" : 4,
    "5" : 4,
    "6" : 4,
    "7" : 4,
    "8" : 4,
    "9" : 4,
    "sota" : 4,
    "caballo" : 4,
    "rey" : 4
    }
    jugadores = []
    ganador = Jugador(0, 0, "")

def creacionJugadores(numJugadores):
    for j in range (1, numJugadores + 1):
        apuesta = int(input("Apuesta: "))
        nick = input("Nombre: ")
        # pedir los datos de los jugadores
        jugadores.append(Jugador(j, apuesta, nick))

def repartirCartas():

    for j in jugadores:
        if j.estado != "plantado" and j.estado != "eliminado":
            carta = seleccionarCarta()
            print("Jugador " + str(j.num) + " Carta: " + carta)
            j.jugada = j.jugada + valorCartas[carta]
            comprobarJugada(j)
            if j.estado == "eliminado":
                print("Te has pasado, eliminado")
            else:
                respuesta = input("¿Te plantas? (s/n) ")
                if respuesta == "s":
                    j.estado = "plantado"

def comprobarJugada(jugador):
    if jugador.jugada > 7.5:
        jugador.estado = "eliminado"

def seleccionarCarta():
    while (True):
        carta = random.choice(cartas)
        if baraja[carta] > 0:
            baraja[carta] = baraja[carta] - 1
            return carta

def juegoTerminado():
    numJugadores = 0
    for j in jugadores:
        if j.estado != "plantado" and j.estado != "eliminado":
            numJugadores += 1
        if numJugadores >= 2:
            return False
    return True

def ganador():
    jGanador = Jugador(0, 0, "a")
    for j in jugadores:
        if j.estado == "plantado":
            if j.jugada > jGanador.jugada:
                jGanador = j
    return jGanador

def empate(jugadaMax):
    ganadores = []
    for j in jugadores:
        if j.estado == "plantado" and j.jugada == jugadaMax:
            ganadores.append(j)
    return ganadores

def apuestaTotal():
    total = 0
    for j in jugadores:
        total =+ j.apuesta
    return total

def introducirRegistro(ganadores, ganancia):
    server = 'C13-PC16\SQLEXPRESS01'
    database = 'LIBRERIA'
    username = 'librero'
    password = 'librero'

    cnxn = pyodbc.connect(
        'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';ENCRYPT=no;UID=' + username + ';PWD=' + password)

    cursor = cnxn.cursor()
    for g in ganadores:
        cursor.execute("INSERT INTO SIETEyMEDIA(Nick_Jugador, Apuesta, Ganancia) VALUES (?, ?, ?)", g.nick, g.apuesta, ganancia)
    cursor.commit()
    cnxn.close()

jugarDeNuevo = "s"


while jugarDeNuevo == "s":
    inicializarJuego()
    print("Número de jugadores, máximo 8")
    while True:
        numJugadores = int(input())
        if (numJugadores > 0 and numJugadores <= 8):
            break
    creacionJugadores(numJugadores)
    while not juegoTerminado():
        repartirCartas()

    totalApostado = apuestaTotal()
    ganador = ganador()
    print(ganador)
    ganadores = []
    if ganador.num == 0:
        print("Nadie ha ganado")
    else:
        ganadores = empate(ganador.jugada)
        for g in ganadores:
            print("Ha ganado:")
            print(str(g.nick) + " con un " + str(g.jugada))
        ganancia = totalApostado # no se reparten lo apostado
        introducirRegistro(ganadores, ganancia)
    
    # peta al jugar de nuevo
    jugarDeNuevo = input("Desea jugar de nuevo (s/n) ")


