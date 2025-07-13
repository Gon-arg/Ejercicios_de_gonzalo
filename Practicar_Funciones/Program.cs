/*Ejercicio 1: Encuesta de Satisfacción de un Restaurante
Descripción: Una cadena de restaurantes realizó una encuesta de satisfacción a 20 clientes, donde cada cliente calificó su experiencia con un puntaje entero entre 1 y 5. Crea un programa en C# que permita:

Cargar los nombres de los clientes y sus calificaciones.
Implementar un procedimiento llamado OrdenarBurbuja(int[] aCalificaciones, string[] aNombres, bool creciente) para ordenar las calificaciones.
Mostrar la lista de clientes con sus calificaciones.
Mostrar quién le dio la calificación más baja y quién le dio la calificación más alta.
Determinar si hubo calificaciones repetidas.*/
/*using System;

class Program
{
    static void Menu()
    {
        Console.WriteLine("elija alguna de estas opciones:");
        Console.WriteLine("1- Cargar lista");
        Console.WriteLine("2- Ordenar las calificaciones de mas alta a mas baja");
        Console.WriteLine("3- Ordenar las calificaciones de mas baja a mas alta");
        Console.WriteLine("4- Mostrar clientes con sus calificaciones");
        Console.WriteLine("5- elegir la nota mas alta");
        Console.WriteLine("6- elegir la nota mas baja");
        Console.WriteLine("7- Ver si hay notas repetidas");
        Console.WriteLine("0- Salir");

    }

    static void Cargar(int[] calificaciones, string[] nombres)
    {
        for (int i = 0; i < calificaciones.Length; i++)
        {
            //pedir nobre de los clientes
            Console.Write($"ingrese el nombre del cliente({i + 1})");
            nombres[i] = Console.ReadLine()!;

            //pedir calificaciones
            int calificacion;
            Console.WriteLine("ingrese una calificacio del (1-5)");
            while (!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 1 || calificacion > 5)
            {
                Console.Write("El valor ingresado es inválido. Ingrese un valor válido (1-5): ");
            }
            calificaciones[i] = calificacion;
        }
    }

    static void OrdenarBurbuja(int[] calificaciones, string[] nombres, bool creciente)
    {
        for (int i = 0; i < calificaciones.Length; i++)
        {
            for (int j = 0; j < calificaciones.Length - i - 1; j++)
            {
                if ((creciente && calificaciones[j] > calificaciones[j + 1]) || (!creciente && calificaciones[j] < calificaciones[j + 1]))
                {
                    int temp = calificaciones[j];
                    calificaciones[j] = calificaciones[j + 1];
                    calificaciones[j + 1] = temp;

                    string auxNombre = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = auxNombre;
                }
            }
        }
    }

    static void Mostrar_valores(int[] calificaciones, string[] nombres)
    {
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"{nombres[i]} - {calificaciones[i]}");
        }
    }

    static void Calificacion_Mas_Baja(int[] calificaciones, string[] nombres)
    {
        int min = calificaciones[0];
        int indice = 0;
        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < min)
            {
                min = calificaciones[i];
                indice = i;
            }
        }
        Console.WriteLine($"La calificacion mas baja fue {nombres[indice]} con una calificacion de {min}");
    }

    static void Calificacion_Mas_Alta(int[] calificaciones, string[] nombres)
    {
        int max = calificaciones[0];
        int indice = 0;
        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] > max)
            {
                max = calificaciones[i];
                indice = i;
            }
        }
        Console.WriteLine($"La calificacion mas alta fue {nombres[indice]} con una calificacion de {max}");
    }

    static void Nota_Repetida(int[] calificaciones )
    {
        bool repetida = false;
        for (int i = 0; i < calificaciones.Length; i++)
        {
            for (int j = i+1; j < calificaciones.Length; j++)
            {
                if (calificaciones[i] == calificaciones[j])
                {
                    repetida = true;
                }
            }
        }
        Console.WriteLine(repetida ? "Hay calificaciones repetidas" : "No Hay calificaciones repetidas");
    }
    static void Main()
    {
        string[] a_clientes = new string[10];
        int[] a_calificacioes = new int[10];
        Menu();
        string opcion = Console.ReadLine()!;
        do
        {
            switch (opcion)
            {
                case "1": Cargar(a_calificacioes, a_clientes); break;
                case "2": OrdenarBurbuja(a_calificacioes, a_clientes, true); break;
                case "3": OrdenarBurbuja(a_calificacioes, a_clientes, false); break;
                case "4": Mostrar_valores(a_calificacioes, a_clientes); break;
                case "5": Calificacion_Mas_Alta(a_calificacioes, a_clientes); break;
                case "6": Calificacion_Mas_Baja(a_calificacioes, a_clientes); break;
                case "7": Nota_Repetida(a_calificacioes); break;

            }
        } while (opcion != "0");
} }*/

/*Ejercicio 2: Registro de Temperaturas
Descripción: Se desea llevar un registro de las temperaturas diarias de una ciudad durante una semana (7 días). Crea un programa en C# que permita:

Cargar las temperaturas diarias.
Implementar un procedimiento llamado OrdenarBurbuja(double[] aTemperaturas, bool creciente) para ordenar las temperaturas.
Mostrar la lista de temperaturas ordenadas.
Mostrar la temperatura más baja y la más alta de la semana.
Calcular y mostrar la temperatura promedio de la semana.*/
using System;

class Program
{
    static void Menu()
    {
        Console.WriteLine("opciones:");
        Console.WriteLine("1- Cargar Las Calificaciones");
        Console.WriteLine("2- Ordenar temperaturas de forma creciente");
        Console.WriteLine("3- Ordenar temperaturas de forma decreciente");
        Console.WriteLine("4- Mostrar temperaturas");
        Console.WriteLine("5- Mostrar temperatura mas alta");
        Console.WriteLine("6- Mostrar temperatura mas baja");
        Console.WriteLine("7- Temperatura promedio de la semana");
        Console.WriteLine("0- Salir");
    }
    static void Cargar_Temperaturas(double[] temperaturas)
    {
        double temp;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            Console.WriteLine($"ingrese la temperatura del dia({i + 1}):");
            while (!double.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("Temperatura Incorrecta.vuelva ingresar la temperatura");
            }
            temperaturas[i] = temp;
        }

    }

    static void OrdenarBurbuja(double[] temperaturas, bool creciente)
    {
        for (int i = 0; i < temperaturas.Length; i++)
        {
            for (int j = 0; j < temperaturas.Length - i - 1; j++)
            {
                if ((creciente && temperaturas[j] > temperaturas[j + 1]) || (!creciente && temperaturas[j] < temperaturas[j + 1]))
                {
                    double aux = temperaturas[j];
                    temperaturas[j] = temperaturas[j + 1];
                    temperaturas[j + 1] = aux;
                }
            }
        }
    }

    static void Mostrar_Temperaturas(double[] temperaturas)
    {
        for (int i = 0; i < temperaturas.Length; i++)
        {
            Console.WriteLine($"valor dia({i+1}):{temperaturas[i]}");
        }
    }

    static void Temperatura_Mas_Alta(double[] temperaturas)
    {
        double max = temperaturas[0];
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > max)
            {
                max = temperaturas[i];
            }
        }
        Console.WriteLine($"mayor temperatura:{max}");
    }

    static double Temperatura_Promedio(double[] temperatura)
    {
        double suma = 0;
        for (int i = 0; i < temperatura.Length; i++)
        {
            suma += temperatura[i];
        }
        double promedio = suma / temperatura.Length;
        return promedio;
    }

    static void Temperatura_Mas_Baja(double[] temperaturas)
    {
        double min = temperaturas[0];
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < min)
            {
                min = temperaturas[i];
            }
        }
        Console.WriteLine($"menor temperatura:{min}");
    }
    static void main()
    {
        double[] a_temperaturas = new double[7];
        Menu();
        string opcion = Console.ReadLine()!;
        do
        {
            switch (opcion)
            {
                case "1": Cargar_Temperaturas(a_temperaturas); break;
                case "2": OrdenarBurbuja(a_temperaturas, true); break;
                case "3": OrdenarBurbuja(a_temperaturas, false); break;
                case "4": Mostrar_Temperaturas(a_temperaturas); break;
                case "5": Temperatura_Mas_Alta(a_temperaturas); break;
                case "6": Temperatura_Mas_Baja(a_temperaturas); break;
                case "7": Temperatura_Promedio(a_temperaturas); break;
            }
        } while (opcion != "0");
    }
}