'''
Alberto Colmenar
2ºA DAM
11/10/23
11/10/23
'''

print("""
 1 - IVA del cine
 2 - IVA de un libro
 3 - IVA de un recibo de la electricidad
 4 - IVA de un recibo del gas natural
 5 - IVA de la alimentación
 6 - IVA de un medicamento
 7 - IVA de un producto de electrónica (teléfono móvil, portátil, PC de sobremesa...)
 8 - IVA general
 """)
opcion = int(input())
if opcion == 1:
    print("El IVA del cine es el 10%")
elif opcion == 2:
    print("El IVA de un libro es el 10%")
elif opcion == 3:
    print("El IVA de un recibo de la electricidad es el 21%")
elif opcion == 4:
    print("El IVA de un recibo del gas natural es el 21%")
elif opcion == 5:
    print("El IVA de la alimentación es el 10%")
elif opcion == 6:
    print("El IVA de un medicamento es el 4%")
elif opcion == 7:
    print("El IVA de un producto de electrónica es el 21%")
elif opcion == 8:
    print("El IVA general es el 21%")