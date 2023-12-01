def añoBisiesto(año):
    esBisiesto = False
    if (año % 4 == 0) and (año % 100 != 0):
        esBisiesto = True
    elif (año % 400 == 0):
        esBisiesto = True
    return esBisiesto

print("Listado de años bisiestos dados 2 años.")
print("Introduce un año")
año1 = int(input())
print("Introduce otro año")
año2 = int(input())

if (año1 > año2):
    orden = -1
else:
    orden = 1

for x in range(año1, año2, orden):
    if (añoBisiesto(x)):
        print(x)