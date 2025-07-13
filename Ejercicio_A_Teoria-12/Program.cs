/*A) Estás desarrollando una parte crucial del sistema de procesamiento 
de pagos de un banco.
Cuando se recibe una solicitud de pago con tarjeta de crédito, 
el sistema necesita verificar
rápidamente si el número de tarjeta proporcionado corresponde 
a una tarjeta habilitada para realizar transacciones. 
Tu tarea es simular este proceso implementando un programa en C#.
Requisitos:
● Crea un arreglo de números enteros que represente los números de tarjetas habilitadas en el sistema. Carga este arreglo con datos predefinidos.
● La verificación de la tarjeta debe ser extremadamente rápida, ya que un sistema bancario procesa 
miles de transacciones por segundo. Para lograr esto, 
el arreglo de tarjetas habilitadas debe estar ordenado (de forma ascendente o descendente), 
y la verificación debe realizarse utilizando el algoritmo de búsqueda binaria. 
● El programa debe permitir al usuario ingresar un número de tarjetapara consultar.
● El sistema debe informar al usuario si la tarjeta ingresada está "Habilitada" o "No Habilitada"*/
using System;

class Program
{
    static void Burbuja_Tarjeta(int[] tarjeta,bool creciente)
    {
        for (int i = 0; i < tarjeta.Length-1; i++)
        {
            for (int j = i; j < tarjeta.Length-1; j++)
            {
                if ((creciente && tarjeta[j] > tarjeta[j + 1]) || (!creciente && tarjeta[j] < tarjeta[j + 1]))
                {
                    int aux = tarjeta[j];
                    tarjeta[j] = tarjeta[j+1];
                    tarjeta[j + 1] = aux;
                }
            }
        }
    }

    static int Busqueda_Binaria(int[] tarjeta, int num_buscado)
    {
        int inicio = 0;
        int fin = tarjeta.Length - 1;
        int indice_Encontrado = -1;
        while (inicio <= fin && indice_Encontrado == -1)
        {
            int medio = (inicio + fin) / 2;
            if (tarjeta[medio] == num_buscado)
            {
                indice_Encontrado = medio;
            }
            else if (tarjeta[medio] < num_buscado)
            {
                inicio = medio + 1;
            }
            else
            {
                fin = medio - 1;
            }
        }
        return indice_Encontrado;
    }

    static void Menu()
    {
        Console.WriteLine("seleccione una opcion:");
        Console.WriteLine("1- Ver Listado de tarjetas habilitadas");
        Console.WriteLine("2- Consultar una tarjeta");
        Console.WriteLine("0- Salir");
    }
    static void Mostrar_Lisado_Tarjeta(int[] tarjeta)
    {
        for (int i = 0; i < tarjeta.Length; i++)
        {
            Console.WriteLine(tarjeta[i]);
        }
    }

    static int Pedir_Numero_Entero_Positivo(string mensaje)
    {
        int resultado;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out resultado))
        {
            Console.WriteLine("el valor ingresado es invalido:");
            Console.Write(mensaje);
        }
        return resultado;
}
    static void verificación_tarjeta(int[] tarjeta)
    {
        int tarjeta_buscada = Pedir_Numero_Entero_Positivo("ingrese el numero de la tarjeta");
        if (Busqueda_Binaria(tarjeta, tarjeta_buscada) != -1)
        {
            Console.WriteLine("tarjeta Encontrada");
        }
        else
        {
            Console.WriteLine("tarjeta No Encontrada");
        }
    }
    static void Main()
    {
        int[] a_tarjeta = new int[16] { 1111, 222, 3333, 5555, 6666, 7777, 9999, 44444, 10000, 3000, 12333, 5887, 65444, 7999, 8444, 97655 };
        Burbuja_Tarjeta(a_tarjeta, true);
        Menu();
        string opcion = Console.ReadLine()!;
        do
        {

            switch (opcion)
            {
                case "1":
                    Mostrar_Lisado_Tarjeta(a_tarjeta); break;
                case "2":
                    Console.Clear();
                    verificación_tarjeta(a_tarjeta);
                    break;
                case "0": Console.WriteLine("saliendo..."); break;
            }
            if (opcion != "0")
    {
        Menu();
        opcion = Console.ReadLine()!;
    }
        } while (opcion != "0");
    }
}


