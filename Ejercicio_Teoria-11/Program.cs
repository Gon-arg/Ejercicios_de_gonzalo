/*Una empresa realizó una encuesta de satisfacción sobre un producto a 15 clientes,
donde cada cliente calificó el producto con un puntaje entero entre 1 y 10. Se desea analizar los resultados. Nos encargaron crear un programa en C# que permita cargar los nombres de los clientes y sus calificaciones al producto, para luego generar la siguiente información:
● Implementar un procedimiento llamado OrdenarBurbuja(int[] aCalificaciones, string[] aNombres, bool creciente) que implemente el ordenamiento burbuja para modificar la secuencia de elementos en ambos arreglos a la vez, considerando el orden deseado para las calificaciones, el parámetro booleano determina el tipo de ordenamiento creciente/decreciente.
● Mostrar la lista de clientes con las calificaciones de menor a mayor
● Mostrar quien le dio el menor puntaje al producto
● Mostrar quien le dio el mayor puntaje al producto
● Determinar si hubo (o no) calificaciones repetidas*/
using System;

class Program
{
    static void Menu()
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1 - Cargar calificaciones de los clientes");
        Console.WriteLine("2 - Ver la menor calificación");
        Console.WriteLine("3 - Ver la mayor calificación");
        Console.WriteLine("4 - Ver si hay calificaciones repetidas");
        Console.WriteLine("5 - Mostrar lista de calificaciones");
        Console.WriteLine("6 - Ordenar listado de calificaciones crecientes");
        Console.WriteLine("7 - Ordenar listado de calificaciones decrecientes");
        Console.WriteLine("0 - Salir");
    }

    static void Cargar(int[] calificaciones, string[] nombres)
    {
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write($"Ingrese el nombre del cliente ({i + 1}): ");
            nombres[i] = Console.ReadLine()!;
            calificaciones[i] = Pedir_Calificacion(i + 1);
        }
    }

    static int Pedir_Calificacion(int numero_cliente)
    {
        Console.WriteLine($"Ingrese la calificación del cliente {numero_cliente} (1-10):");
        int calificacion;
        while (!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 1 || calificacion > 10)
        {
            Console.Write("El valor ingresado es inválido. Ingrese un valor válido (1-10): ");
        }
        return calificacion;
    }

    static void MostrarListado(int[] calificaciones, string[] nombres)
    {
        Console.WriteLine("Lista de calificaciones:");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"{nombres[i]} - {calificaciones[i]}");
        }
    }

    static void OrdenarBurbuja(int[] a_calificaciones, string[] a_nombres, bool creciente)
    {
        for (int i = 0; i < a_calificaciones.Length - 1; i++)
        {
            for (int j = 0; j < a_calificaciones.Length - i - 1; j++)
            {
                if ((creciente && a_calificaciones[j] > a_calificaciones[j + 1]) || (!creciente && a_calificaciones[j] < a_calificaciones[j + 1]))
                {
                    // Intercambiar calificaciones
                    int auxCalificacion = a_calificaciones[j];
                    a_calificaciones[j] = a_calificaciones[j + 1];
                    a_calificaciones[j + 1] = auxCalificacion;

                    // Intercambiar nombres
                    string auxNombre = a_nombres[j];
                    a_nombres[j] = a_nombres[j + 1];
                    a_nombres[j + 1] = auxNombre;
                }
            }
        }
    }

    static void VerMenorCalificacion(int[] calificaciones, string[] nombres)
    {
        int menorIndex = 0;
        for (int i = 1; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < calificaciones[menorIndex])
            {
                menorIndex = i;
            }
        }
        Console.WriteLine($"La menor calificación es de {nombres[menorIndex]}: {calificaciones[menorIndex]}");
    }

    static void VerMayorCalificacion(int[] calificaciones, string[] nombres)
    {
        int mayorIndex = 0;
        for (int i = 1; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] > calificaciones[mayorIndex])
            {
                mayorIndex = i;
            }
        }
        Console.WriteLine($"La mayor calificación es de {nombres[mayorIndex]}: {calificaciones[mayorIndex]}");
    }

    static void VerCalificacionesRepetidas(int[] calificaciones)
    {
        bool hayRepetidos = false;
        for (int i = 0; i < calificaciones.Length; i++)
        {
            for (int j = i + 1; j < calificaciones.Length; j++)
            {
                if (calificaciones[i] == calificaciones[j])
                {
                    hayRepetidos = true;
                    break;
                }
            }
            if (hayRepetidos) break;
        }
        Console.WriteLine(hayRepetidos ? "Hay calificaciones repetidas." : "No hay calificaciones repetidas.");
    }

    static void Main()
    {
        int[] a_calificaciones = new int[15];
        string[] a_nombres = new string[15];
        string opcion;

        do
        {
            Menu();
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1": 
                    Cargar(a_calificaciones, a_nombres); 
                    break;
                case "2": 
                    VerMenorCalificacion(a_calificaciones, a_nombres); 
                    break;
                case "3": 
                    VerMayorCalificacion(a_calificaciones, a_nombres); 
                    break;
                case "4": 
                    VerCalificacionesRepetidas(a_calificaciones); 
                    break;
                case "5": 
                    MostrarListado(a_calificaciones, a_nombres); 
                    break;
                case "6": 
                    OrdenarBurbuja(a_calificaciones, a_nombres, true); 
                    break;
                case "7": 
                    OrdenarBurbuja(a_calificaciones, a_nombres, false); 
                    break;
            }
        } while (opcion != "0");
    }
}
