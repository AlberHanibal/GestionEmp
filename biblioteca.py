'''
Alberto Colmenar
2ºA DAM
18/10/23
x
'''
#Gestión de biblioteca
#Comprobar si es número en añadir y modificar

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
        if (libro.autor.lower() == autor.lower()):
            listaAutor.append(libro)
    return listaAutor

def busquedaTitulo(lista, titulo):
    listaAutor = []
    for libro in lista:
        if (libro.titulo.lower() == titulo.lower()):
            listaAutor.append(libro)
    return listaAutor

def borradoTitulo(lista, titulo):
    nuevaLista = lista.copy()
    for libro in lista:
        if (libro.titulo.lower() == titulo.lower()):
            nuevaLista.remove(libro)
            print("Borrado: {}".format(libro))
    return nuevaLista

def borradoTituloAutor(lista, titulo, autor):
    nuevaLista = lista.copy()
    for libro in lista:
        if (libro.titulo.lower() == titulo.lower() and libro.autor.lower() == autor.lower()):
            nuevaLista.remove(libro)
            print("Borrado: {}".format(libro))
    return nuevaLista

def mostrarLista(lista):
    numero = 1
    for libro in lista:
        print("{}. {}".format(numero, libro))
        numero += 1

def hayLibros(lista):
    return len(lista) != 0

def modificarLibro(lista, index):
    print(lista[index - 1])
    libroAModificar = lista[index - 1]
    lista.pop(index - 1)
    print("¿Quieres modificar el título? (s/n)")
    opcion = input()
    if (opcion == "s"):
        titulo = input()
        libroAModificar.titulo = titulo
    print("¿Quieres modificar el autor? (s/n)")
    opcion = input()
    if (opcion == "s"):
        autor = input()
        libroAModificar.autor = autor
    print("¿Quieres modificar el año de publicación? (s/n)")
    opcion = input()
    if (opcion == "s"):
        anno = int(input())
        libroAModificar.anno = anno
    lista.insert(index - 1, libroAModificar)
    print("Modificado correctamente: {}".format(lista[index - 1]))
    return lista

opcion = 0
listaLibros = [Libro("Mesa", "Alberto", "2023"), Libro("Mesa", "Roberto", "1237")]
#listaLibros = []
while (not opcion == 5):
    print('''
*********************************************************
*			BIBLIOTECA			*
*	1.- Nuevo libro					*
*	2.- Búsqueda					*
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
            anno = input()
            print(anno.isdigit())
            # comprobar caso.isdigit()
            listaLibros.append(Libro(titulo, autor, anno))
        case 2:
            if (hayLibros(listaLibros)):
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
            else:
                print("No hay libros en la biblioteca.")
        case 3:
            if (hayLibros(listaLibros)):
                print("1. Borrado por título.")
                print("2. Borrado por título y autor.")
                tipoBorrado = int(input())
                if (tipoBorrado == 1):
                    print("Dame un título.")
                    titulo = input()
                    listaLibros = borradoTitulo(listaLibros, titulo)
                elif (tipoBorrado == 2):
                    print("Dame un título.")
                    titulo = input()
                    print("Dame un autor.")
                    autor = input()
                    listaLibros = borradoTituloAutor(listaLibros, titulo, autor)
            else:
                print("No hay libros en la biblioteca.")
        case 4:
            if (hayLibros(listaLibros)):
                print("1. Buscar por título.")
                print("2. Mostrar todos los libros.")
                opcion = int(input())
                if (opcion == 1):
                    print("Dame un título.")
                    titulo = input()
                    listaTitulo = busquedaTitulo(listaLibros, titulo)
                    if (hayLibros(listaTitulo)):
                        print("¿Cuál quieres modificar?")
                        mostrarLista(listaTitulo)
                        numero = int(input())
                        if (len(listaTitulo) >= numero):
                            libroBuscado = listaTitulo[numero - 1]
                            posLibro = listaLibros.index(libroBuscado)
                            listaLibros = modificarLibro(listaLibros, posLibro + 1)
                    else:
                        print("No hay libros con ese título.")
                elif (opcion == 2):
                    print("¿Cuál quieres modificar?")
                    mostrarLista(listaLibros)
                    numero = int(input())
                    if (len(listaLibros) >= numero):
                        listaLibros = modificarLibro(listaLibros, numero)
                    
            else:
                print("No hay libros en la biblioteca.")
        case 5:
            pass