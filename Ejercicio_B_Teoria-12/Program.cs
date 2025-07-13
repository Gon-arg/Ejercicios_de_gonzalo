/*B) El Profesor Caos ha estado midiendo la cantidad de partículas energéticas
generadas por diferentes experimentos. Anotó cada medición (15 en total) en un
arreglo numérico, pero como lo hizo a las apuradas, están desordenadas.
Tu misión como asistente de laboratorio es crear un menú y programar 
las siguientes opciones:
1. Cargar aleatoriamente los valores en el arreglo con números enteros del 1 al 79. 
Crear un menú que permita utilizar las siguientes opciones:
a) Ordenar las mediciones de menor a mayor para identificar cuáles
experimentos fueron más estables.
b) Buscar si se registró exactamente cierta cantidad de partículas, 
por ejemplo 42 unidades, en alguna medición.
c) Detectar errores de medición, es decir, valores duplicados que no
deberían repetirse. Si hay valores duplicados, mostrarlos.
d) Contar cuántas mediciones cayeron dentro del rango seguro de partículas, 
por ejemplo entre 35 y 45 unidades.*/
using System;

class Program
{
    static void Menu()
    {
        Console.WriteLine("eliga alguna de estas opciones:");
        Console.WriteLine("1- Encontrar particula");
        Console.WriteLine("2- Econtrar duplicados");
        Console.WriteLine("3- Rango de mediciones");
        Console.WriteLine("0- Salir");
    }
    static void Cargar_Valores(int[] medicion)
    {
        Random random = new Random();
        for (int i = 0; i < medicion.Length; i++)
        {
            medicion[i] = random.Next(1, 80);
        }
    }

    static void Ordenar_De_Menor_A_Mayor(int[] medicion)
    {
        for (int i = 0; i < medicion.Length - 1; i++)
        {
            for (int j = i; j < medicion.Length - 1; j++)
            {
                if (medicion[j] < medicion[j + 1])
                {
                    int aux = medicion[j];
                    medicion[j] = medicion[j + 1];
                    medicion[j + 1] = aux;
                }
            }
        }
    }

    static int Busqueda_Binaria(int[] medicion,int Valor_Buscado)
    {
        int inicio = 0;
        int fin = medicion.Length - 1;
        int Indice_Encontrado = -1;
        while (inicio <= fin && Indice_Encontrado == -1)
        {
            int medio = (inicio + fin) / 2;
            if (medicion[medio] == Valor_Buscado)
            {
                Indice_Encontrado = medio;
            }
            else if (medicion[medio] < Valor_Buscado)
            {
                inicio = medio + 1;
            }
            else
            {
                fin = medio - 1;
            }
        }
        return Indice_Encontrado;
    }

    static void Valor_Repetido(int[] medicion)
    {
        bool hayDuplicados = false;
        for (int i = 0; i < medicion.Length; i++)
        {
            for (int j = i + 1; j < medicion.Length; j++)
            {
                if (medicion[i] == medicion[j])
                {
                    Console.WriteLine($"Valor repetido: {medicion[i]}");
                    hayDuplicados = true;
                    break;
                } 
                if (!hayDuplicados)
        {
            Console.WriteLine("No hay valores repetidos.");
        }
            }
        }
    }

    static void Rango_Seguro_De_Partículas(int[] medicion, int max, int min)
    {
        int inicio = Buscar_Limite_Inferior(medicion, min);
        int final = Buscar_Limite_Superior(medicion, max);
        if (inicio < final)
        {
            Console.WriteLine("rango de {min} a {max}");
            for (int i = inicio; i < final; i++)
            {
                Console.WriteLine(medicion[i]);
            }
        }
        else
        {
            Console.WriteLine("no hay rango entre estos numeros");
        }
    }

    static int Buscar_Limite_Inferior(int[] medicion, int min)
    {
        int inicio = 0;
        int Fin = medicion.Length - 1;
        while (inicio <= Fin)
        {
            int medio = (inicio + Fin) / 2;
            if (medicion[medio] < min)
            {
                inicio = medio + 1;
            }
            else
            {
                Fin = medio - 1;
            }
        }
        return inicio;
    }

        static int Buscar_Limite_Superior(int[] medicion, int max)
    {
        int inicio = 0;
        int Fin = medicion.Length - 1;
        while (inicio <= Fin)
        {
            int medio = (inicio + Fin) / 2;
            if (medicion[medio] <= max)
            {
                inicio = medio + 1;
            }
            else
            {
                Fin = medio - 1;
            }
        }
        return inicio;
    }
    static void Main()
    {
        int[] a_medicion = new int[15];
        Cargar_Valores(a_medicion);
        Ordenar_De_Menor_A_Mayor(a_medicion);
        string opcion;
        do
        {
            Menu();
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("ingrese numero a buscar:");
                    int num = int.Parse(Console.ReadLine()!);
                    int resultado = Busqueda_Binaria(a_medicion, num);
                    if (resultado != -1)
                    {
                        Console.WriteLine($"El valor {num} se encuentra en el índice {resultado}.");
                    }
                    else
                    {
                        Console.WriteLine($"El valor {num} no se encontró en el arreglo.");
                    }
                    break;
                case "2":
                    Console.Write($"El valor repetido es:");
                    Valor_Repetido(a_medicion);
                    break;
                case "3":
                    int min, max;
                    Console.WriteLine("ingrese el primer numero del rango:");
                    min = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("ingrese el segundo numero del rango:");
                    max = int.Parse(Console.ReadLine()!);
                    Rango_Seguro_De_Partículas(a_medicion, max, min);
                    break;
            }
        } while (opcion != "0");
    }
}

