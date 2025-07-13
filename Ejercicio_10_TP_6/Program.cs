/*Una aplicación de encuestas almacenó en un arreglo de 100 posiciones las
respuestas de los clientes sobre su nivel de satisfacción (valores del 1 al 10).
a. Hacer un procedimiento que cargue en los valores (1-10) de forma aleatoria.
b. Hacer un procedimiento para contar cuántas respuestas hay en cada valor
del 1 al 10.
c. Hacer una función que devuelva el valor más frecuente.
d. Mostrar los resultados desde el programa principal.*/
using System;

class Program
{
    //inicializa los valores.
    static int[] arreglo = new int[100];
    static int[] Valor_Repetido = new int[10];

//inicializa los valores
    static void Carga_De_Valores()
    {
        Random random = new Random();
        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = random.Next(0, 11);
        }
    }

//hace en el arreglo de tamaño 10 si el numero esta en el tamaño del arreglo lo suma
    static void Contar_Valores()
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Valor_Repetido[arreglo[i] - 1]++;
            //ej:arreglo = [2, 2, 5, 1, 2]
            /*Entonces se ejecutaría:
            Valor_Repetido[1]++ → por el primer 2
            Valor_Repetido[1]++ → otro 2
            Valor_Repetido[4]++ → por el 5
            Valor_Repetido[0]++ → por el 1
            Valor_Repetido[1]++ → otro 2*/
        }
    }

//encuentra el valor mas frecuente
    static int Valor_Mas_Frecuente()
    {
        int max = Valor_Repetido[0];
        int indice = 0;
        for (int i = 0; i < Valor_Repetido.Length; i++)
        {
            if (Valor_Repetido[i] > max)
            {
                max = Valor_Repetido[i];
                indice = i;
            }
        }
        return indice;
    }
    static void Main()
    {
        Carga_De_Valores();
        Contar_Valores();
        int valor = Valor_Mas_Frecuente();
        Console.WriteLine("El valor más frecuente es: " + valor);
    }
        }
    
