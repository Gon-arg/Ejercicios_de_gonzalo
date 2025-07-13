/*9. La Biblioteca organiza cada año un Torneo Lúdico abierto al público, 
donde se juegan
diferentes juegos de mesa. Como parte del equipo organizador, 
te encargaron desarrollar
un pequeño sistema que permita registrar los juegos disponibles 
y consultar información
relevante para organizar las mesas de juego.
Para esto, necesitás crear un programa en C# que utilice un arreglo de structs. Cada
Juego de Mesa tiene un nombre, una cantidad mínima y una cantidad máxima de
jugadores, y una duración estimada en minutos.
Permití al usuario cargar los datos de 5 juegos de mesa distintos.
Luego, el menú del programa debe ofrecer las opciones:
a. Mostrar todos los juegos cargados.
b. Listar los juegos que permiten entre 3 y 6 jugadores (inclusive).
c. Calcular y mostrar el promedio de duración de los juegos.
d. Mostrar todos los juegos cuya duración sea menor a 30 minutos (ideales para
rondas rápidas).*/
using System;

class Program
{
    public struct Tipo_Juego_De_Mesa
    {
        public string nombre;
        public int cantidad_Max_Jugadores;
        public int cantidad_Min_Jugadores;
        public int duracion;
    }

    static void Menu()
    {
        Console.WriteLine("elija alguna de estas opciones");
        Console.WriteLine("1- Cargar 5 juegos de mesa");
        Console.WriteLine("2- Mostrar todos los juegos cargados");
        Console.WriteLine("3- juegos que permiten entre 3 y 6 jugadores (inclusive)");
        Console.WriteLine("4- Promedio de duración de los juegos");
        Console.WriteLine("5- Todos los juegos cuya duración sea menor a 30 minutos");
        Console.WriteLine("0- Salir");
    }
    static void Cargar_Juegos(Tipo_Juego_De_Mesa[] juego)
    {
        for (int i = 0; i < juego.Length; i++)
        {
            Tipo_Juego_De_Mesa Nuevo = new Tipo_Juego_De_Mesa();
            Console.WriteLine($"ingrese el nombre del juego({i + 1})");
            Nuevo.nombre = Console.ReadLine()!;
            Nuevo.cantidad_Max_Jugadores = Verificar_Num_Positivo($"ingrese la cantidad maxima de jugadores del juego({i + 1}):");
            Nuevo.cantidad_Min_Jugadores = Verificar_Num_Positivo($"ingrese la cantidad minima de jugadores del juego({i + 1}):");
            Nuevo.duracion = Verificar_Num_Positivo($"ingrese la duracion del juego({+1})");
            juego[i] = Nuevo;
        }
    }

    static int Verificar_Num_Positivo(string mensaje)
    {
        int resultado;
        do
        {
            Console.Write(mensaje);
        } while (!(int.TryParse(Console.ReadLine(), out resultado) && resultado > 0));
        return resultado;
    }

    static void Mostrar_Juegos_Cargados(Tipo_Juego_De_Mesa[] juego)
    {
        for (int i = 0; i < juego.Length; i++)
        {
            Console.WriteLine($"\t Nombre del juego:{juego[i].nombre}");
            Console.WriteLine($"\t Cantidad Maxima de jugadores del juego:{juego[i].cantidad_Max_Jugadores}");
            Console.WriteLine($"\t Cantidad minima de jugadores del juego:{juego[i].cantidad_Min_Jugadores}");
            Console.WriteLine($"\t Duracion del juego:{juego[i].duracion}");
            Console.WriteLine();
        }
    }

    static void Juegos_Que_Permiten_3_a_6_Jugadores(Tipo_Juego_De_Mesa[] juego)
    {
        for (int i = 0; i < juego.Length; i++)
        {
            if (juego[i].cantidad_Max_Jugadores <= 6 && juego[i].cantidad_Min_Jugadores >= 3)
            {
                Console.WriteLine($"\t Nombre del juego:{juego[i].nombre}");
                Console.WriteLine($"\t Cantidad Maxima de jugadores del juego:{juego[i].cantidad_Max_Jugadores}");
                Console.WriteLine($"\t Cantidad minima de jugadores del juego:{juego[i].cantidad_Min_Jugadores}");
                Console.WriteLine($"\t Duracion del juego:{juego[i].duracion}");
                Console.WriteLine();
            }
        }
    }

    static void Promedio_Duracion_De_Juegos(Tipo_Juego_De_Mesa[] juego)
    {
        int suma = 0;
        for (int i = 0; i < juego.Length; i++)
        {
            suma += juego[i].duracion;
        }
        int promedio = suma / juego.Length;
        Console.WriteLine($"El promedio de duración es: {promedio} minutos");
    }

    static void Juegos_Duracion_Mayor_30(Tipo_Juego_De_Mesa[] juego)
    {
        for (int i = 0; i < juego.Length; i++)
        {
            if (juego[i].duracion < 30)
            {
                Console.WriteLine($"\t Nombre del juego:{juego[i].nombre}");
                Console.WriteLine($"\t Cantidad Maxima de jugadores del juego:{juego[i].cantidad_Max_Jugadores}");
                Console.WriteLine($"\t Cantidad minima de jugadores del juego:{juego[i].cantidad_Min_Jugadores}");
                Console.WriteLine($"\t Duracion del juego:{juego[i].duracion}");
                Console.WriteLine();
            }
        }
    }

    static void Main()
    {
        Tipo_Juego_De_Mesa[] juegos = new Tipo_Juego_De_Mesa[5];
        string opcion;

        do
        {
            Menu();
            opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    Cargar_Juegos(juegos);
                    break;
                case "2":
                    Mostrar_Juegos_Cargados(juegos);
                    break;
                case "3":
                    Juegos_Que_Permiten_3_a_6_Jugadores(juegos);
                    break;
                case "4":
                    Promedio_Duracion_De_Juegos(juegos);
                    break;
                case "5":
                    Juegos_Duracion_Mayor_30(juegos);
                    break;
                case "0":
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != "0");
    }
}
