/*3. Crea un programa que gestione una lista de libros. 
Cada libro debe tener los campos:
título, autor, año de publicación y stock. 
El programa debe permitir agregar libros, buscar
libros por autor, buscar libros por año de publicación y 
mostrar el listado completo de
libros ordenado por año de publicación.*/
using System;

class Program
{
    public struct Lista_Libros
    {
        public string titulo;
        public string autor;
        public int año;
        public int stock;
    }
    static void Menu()
    {
        Console.WriteLine("ingrese alguna de estas opciones:");
        Console.WriteLine("1- Agregar Libro");
        Console.WriteLine("2- Buscar Libro Por Autor");
        Console.WriteLine("3- Buscar Libro Por año de publicacion");
        Console.WriteLine("4- Mostrar listado completo de libros por año de publicacion");
        Console.WriteLine("0- Salir");
    }
    static void Cargar_Datos(ref Lista_Libros[] libros, ref int ultima_posicion)
    {
        if (ultima_posicion >= libros.Length)
        {
            Lista_Libros[] nuevoArreglo = new Lista_Libros[libros.Length * 2];
            for (int i = 0; i < libros.Length; i++)
            {
                nuevoArreglo[i] = libros[i]; 
            }
            libros = nuevoArreglo;
        }
        Lista_Libros Nuevo_Libro = new Lista_Libros();
        Console.WriteLine("ingrese el titulo del libro:");
        string titulo = Console.ReadLine()!;
        Nuevo_Libro.titulo = titulo;
        Console.WriteLine("ingrese el autor del libro:");
        string autor = Console.ReadLine()!;
        Nuevo_Libro.autor = autor;
        int año = CargarEnteroPositivo("ingrese el año de publicacion:");
        Nuevo_Libro.año = año;
        int stock = CargarEnteroPositivo("ingrese el stock del libro:");
        Console.WriteLine("ingrese cualquier tecla para seguir...");
        Console.ReadKey();
        libros[ultima_posicion] = Nuevo_Libro;
        ultima_posicion++;
    }

    public static int CargarEnteroPositivo(string mensaje)
    {

        int numero;
        bool Es_Valido;
        do
        {
            Console.WriteLine(mensaje);
            Es_Valido = int.TryParse(Console.ReadLine(), out numero);
        } while (!(Es_Valido && numero > 0));
        return numero;
    }

    static void Ordenar_Libro_Por_Autor(Lista_Libros[] libros, int ultima_posicion)
    {
        for (int i = 0; i < ultima_posicion; i++)
        {
            for (int j = 0; j < ultima_posicion; j++)
            {
                if (string.Compare(libros[j].autor, libros[j + 1].autor) > 0)
                {
                    Lista_Libros aux = libros[j];
                    libros[j] = libros[j + 1];
                    libros[j + 1] = aux;
                }
            }
        }
    }

    static int Busqueda_Binaria_Por_Autor(Lista_Libros[] libros, string indice_a_encontrar, int ultima_posicion)
    {
        int inicio = 0;
        int final = ultima_posicion;
        while (inicio <= final)
        {
            int medio = (inicio + final) / 2;
            if (string.Compare(libros[medio].autor, indice_a_encontrar) == 0)
            {
                return medio;
            }
            else if (string.Compare(libros[medio].autor, indice_a_encontrar) < 0)
            {
                inicio = medio + 1;
            }
            else
            {
                final = medio - 1;
            }
        }
        return -1;
    }

        static void Ordenar_Libro_Por_Año(Lista_Libros[] libros, int ultima_posicion)
    {
        for (int i = 0; i < ultima_posicion; i++)
        {
            for (int j = 0; j < ultima_posicion; j++)
            {
                if (libros[j].año>libros[j+1].año)
                {
                    Lista_Libros aux = libros[j];
                    libros[j] = libros[j + 1];
                    libros[j + 1] = aux;
                }
            }
        }
    }

        static int Busqueda_Binaria_Por_Año(Lista_Libros[] libros, int indice_a_encontrar, int ultima_posicion)
    {
        int inicio = 0;
        int final = ultima_posicion;
        while (inicio <= final)
        {
            int medio = (inicio + final) / 2;
            if (libros[medio].año==indice_a_encontrar)
            {
                return medio;
            }
            else if (libros[medio].año<indice_a_encontrar)
            {
                inicio = medio + 1;
            }
            else
            {
                final = medio - 1;
            }
        }
        return -1;
    }

    static void Mostrar_Libros(Lista_Libros[] libros, int ultima_posicion)
    {
        for (int i = 0; i < ultima_posicion; i++)
        {
            Console.WriteLine($"\t titulo:{libros[i].titulo}");
            Console.WriteLine($"\t autor:{libros[i].autor}");
            Console.WriteLine($"\t año de publicacion:{libros[i].año}");
            Console.WriteLine($"\t stock:{libros[i].stock}");
        }
    }

    static void Main()
    {
    int Cantidad_De_Libros = 1;
    Lista_Libros[] a_libros = new Lista_Libros[Cantidad_De_Libros];
    int ultima_posicion = 0;

    int opcion;
    do
    {
        Menu();
        Console.Write("Opción: ");
        int.TryParse(Console.ReadLine(), out opcion);

        switch (opcion)
        {
            case 1:
                Cargar_Datos(ref a_libros, ref ultima_posicion);
                break;

            case 2:
                if (ultima_posicion == 0)
                {
                    Console.WriteLine("No hay libros cargados.");
                    break;
                }
                Console.Write("Ingrese el autor a buscar: ");
                string autor = Console.ReadLine()!;
                Ordenar_Libro_Por_Autor(a_libros, ultima_posicion);
                int posAutor = Busqueda_Binaria_Por_Autor(a_libros, autor, ultima_posicion - 1);
                    if (posAutor != -1)
                    {
                        Console.WriteLine("Libro encontrado:");
                    Lista_Libros libro = a_libros[posAutor];
                    Console.WriteLine($"\t titulo: {libro.titulo}");
                    Console.WriteLine($"\t autor: {libro.autor}");
                    Console.WriteLine($"\t año de publicacion: {libro.año}");
                    Console.WriteLine($"\t stock: {libro.stock}");

                }
                    else
                    {
                        Console.WriteLine("Autor no encontrado.");
                    }
                break;

            case 3:
                if (ultima_posicion == 0)
                {
                    Console.WriteLine("No hay libros cargados.");
                    break;
                }
                int año = CargarEnteroPositivo("Ingrese el año a buscar:");
                Ordenar_Libro_Por_Año(a_libros, ultima_posicion);
                int posAño = Busqueda_Binaria_Por_Año(a_libros, año, ultima_posicion - 1);
                if (posAño != -1)
                {
                    Console.WriteLine("Libro encontrado:");
                    Lista_Libros libro = a_libros[posAño];
                    Console.WriteLine($"\t titulo: {libro.titulo}");
                    Console.WriteLine($"\t autor: {libro.autor}");
                    Console.WriteLine($"\t año de publicacion: {libro.año}");
                    Console.WriteLine($"\t stock: {libro.stock}");
                }
                else
                {
                    Console.WriteLine("Año no encontrado.");
                }
                break;

            case 4:
                if (ultima_posicion == 0)
                {
                    Console.WriteLine("No hay libros cargados.");
                    break;
                }
                Ordenar_Libro_Por_Año(a_libros, ultima_posicion);
                Console.WriteLine("Listado completo de libros:");
                Mostrar_Libros(a_libros, ultima_posicion);
                break;

            case 0:
                Console.WriteLine("Saliendo...");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

    } while (opcion != 0);
}
}
