/*C) Una emisora de radio muy famosa organizó un ranking musical con canciones de
todos los estilos. Cada canción recibió un puntaje numérico (entre 0 y 100) dado por
oyentes de toda la zona de influencia de la radio.
Tus tareas como programador de la radio:
Crear un menú que permita utilizar las siguientes opciones:
1. Cargar aleatoriamente los valores en el arreglo (1-100)
2. Crear un menú que permita utilizar las siguientes opciones:
a) Ordenar el ranking de canciones de menor a mayor o de mayor a menor,
según se desee.
b) Buscar si alguna canción recibió exactamente una cantidad 
de puntosingresados por el usuario. 
c) Verificar si hay empates, es decir, canciones con puntajes duplicados. 
d) Determinar cuántas canciones obtuvieron una puntuación dentro 
del rango de 80 a 100, 
consideradas "canciones destacadas del ranking".*/
using System;

class Program
{
    static void Cargar_Valores(int[] canciones)
    {
        Random random = new Random();
        for (int i = 0; i < canciones.Length; i++)
        {
            canciones[i] = random.Next(0, 101);
        }
    }

    static void Menu()
    {
        Console.WriteLine("elija alguna de estas opciones:");
        Console.WriteLine("1- Ordenar de menor a Mayor");
        Console.WriteLine("2- Ordenar de Mayor a Menor");
    }

    static void Burbuja_Canciones(int[] canciones,bool creciente)
    {
        for (int i = 0; i < canciones.Length - 1; i++)
        {
            for (int j = 0; j < canciones.Length; j++)
            {
                if ((creciente && canciones[j] > canciones[j + 1]) || (!creciente && canciones[j] > canciones[j + 1]))
                {
                    int aux = canciones[j];
                    canciones[j] = canciones[j + 1];
                    canciones[j + 1] = aux;
                }
            }
        }
    }

    static int Busqueda_Binaria(int[] canciones, int Valor_A_Encontrar)
    {
        int inicio = 0;
        int fin = canciones.Length - 1;
        Valor_A_Encontrar = -1;
        while (inicio <= fin && Valor_A_Encontrar == -1)
        {
            int medio = (inicio + fin) / 2;
            if (canciones[medio] == Valor_A_Encontrar)
            {
                return medio;
            }
            else if (canciones[medio] < Valor_A_Encontrar)
            {
                inicio = medio + 1;
            }
            else
            {
                fin = medio - 1;
            }
        }
        return -1;
    }

    static void Canciones_Repetidas(int[] canciones)
    {
        bool cancion_repetida=false;
        for (int i = 0; i < canciones.Length; i++)
        {
            for (int j = i + 1; j < canciones.Length; j++)
            {
                if (canciones[i] == canciones[j])
                {
                    cancion_repetida = true;
                    break;
                }
            }
        }
        if (!cancion_repetida)
        {
            Console.WriteLine("no hay valores repetidos");
        }
    }

    static int Limite_Inferior(int[] canciones, int min = 80)
    {
        int inicio = 0;
        int fin = canciones.Length - 1;
        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;
            if (canciones[medio] < min)
            {
                inicio = medio + 1;
            }
            else
            {
                fin = medio - 1;
            }
        }
        return inicio;
    }

    static int Limite_Superior(int[] canciones, int max = 100)
    {
        int inicio = 0;
        int fin = canciones.Length - 1;
        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;
            if (canciones[medio] <= max)
            {
                inicio = medio + 1;
            }
            else
            {
                fin = medio - 1;
            }
        }
        return inicio;
}
    static void Rango_De_80_A_100(int[] canciones, int min=80, int max=100)
    {
        int inicio = Limite_Inferior(canciones);
        int final = Limite_Superior(canciones);
        if (inicio < final)
        {
            Console.WriteLine($"rango de numeros entre {inicio} y {final}");
            for (int i = inicio; i < final; i++)
            {
                Console.WriteLine(canciones[i]);
            }
        }
        else
        {
            Console.WriteLine("no hay rango entre estos numeros");
        }

    }
    static void Main()
    {
        int[] a_canciones = new int[10];
        Cargar_Valores(a_canciones);
        string opcion;
        do
        {
            Menu();
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1": Burbuja_Canciones(a_canciones, false); break;
                case "2": Burbuja_Canciones(a_canciones, true); break;
                case "3":
                    Console.WriteLine("ingrese El valor a buscar");
                    int Valor_A_Buscar = int.Parse(Console.ReadLine()!);
                    int resultado=Busqueda_Binaria(a_canciones, Valor_A_Buscar);
                    if (resultado != -1)
                    {
                        Console.WriteLine($"El puntaje {Valor_A_Buscar} se encuentra en el índice {resultado}.");
                    }
                    else
                    {
                        Console.WriteLine($"El puntaje {Valor_A_Buscar} no se encontró en el arreglo.");
                    }
                    break;
                case "4": Canciones_Repetidas(a_canciones); break;
                case "5": Rango_De_80_A_100(a_canciones); break;
            }
        } while (opcion != "0");
    }
}
