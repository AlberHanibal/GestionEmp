'''
Alberto Colmenar
2ºA DAM
18/10/23
x
'''
#Gestión de biblioteca

class Libro:
    def __init__(self, titulo, autor, anno):
        self.titulo = titulo
        self.autor = autor
        self.anno = anno

    def __str__(self):
        return f"{self.titulo} de {self.autor} en el año {self.anno}"

def busquedaAutor(lista, autor):
    listaAutor = []
    for libro in lista:
        if (libro.autor == autor):
            listaAutor.append(libro)
    return listaAutor

def busquedaTitulo(lista, titulo):
    listaAutor = []
    for libro in lista:
        if (libro.titulo == titulo):
            listaAutor.append(libro)
    return listaAutor

def borradoTitulo(listaLibros, titulo):
    for libro in listaLibros:
        if (libro.titulo == titulo):
            listaLibros.remove(libro)
            print("Borrado: {}".format(libro))

def borradoTituloAutor(listaLibros, titulo, autor):
    for libro in listaLibros:
        if (libro.titulo == titulo and libro.autor == autor):
            listaLibros.remove(libro)
            print("Borrado: {}".format(libro))

def mostrarLista(lista):
    for libro in lista:
        print(libro)

opcion = 0
listaLibros = []
while (not opcion == 5):
    print('''
*********************************************************
*			BIBLIOTECA			*
*	1.- Nuevo libro					*
*	2.- Busqueda					*
*	3.- Borrar libro				*
*	------------------------------			*
*	4.- Modificar libro				*
*	5.- Salir					*
*							*
*********************************************************
''')
    opcion = int(input())
    match opcion:
        case 1:
            print("Dame un título.")
            titulo = input()
            print("Dame su autor.")
            autor = input()
            print("Dame su año de publicación.")
            anno = int(input())
            listaLibros.append(Libro(titulo, autor, anno))
            pass
        case 2:
            print("1. Búsqueda por autor.")
            print("2. Búsqueda por título.")
            tipoBusqueda = int(input())
            if (tipoBusqueda == 1):
                print("Dame un autor.")
                autor = input()
                mostrarLista(busquedaAutor(listaLibros, autor))
            elif (tipoBusqueda == 2):
                print("Dame un título.")
                titulo = input()
                mostrarLista(busquedaTitulo(listaLibros, titulo))
        case 3:
            print("1. Borrado por título.")
            print("2. Borrado por título y autor.")
            tipoBorrado = int(input())
            if (tipoBorrado == 1):
                print("Dame un título.")
                titulo = input()
                borradoTitulo(listaLibros, titulo)
            elif (tipoBorrado == 2):
                print("Dame un título.")
                titulo = input()
                print("Dame un autor.")
                autor = input()
                borradoTituloAutor(listaLibros, titulo, autor)
        case 4:
            # Preguntar que le pasa el usuario
            pass
        case 5:
            pass
mostrarLista(listaLibros)