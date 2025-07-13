/*Una aplicación de encuestas almacenó en un arreglo de 100 posiciones las
respuestas de los clientes sobre su nivel de satisfacción (valores del 1 al 10).
a. Hacer un procedimiento que pida los valores para cargar en el arreglo.
b. Hacer un procedimiento para contar cuántas respuestas hay en cada valor
del 1 al 10.
c. Hacer una función que devuelva el valor más frecuente.
d. Mostrar los resultados desde el programa principal.
*/
using System;

class Program
{
    //inicializa los valores.
    static int[] arreglo = new int[10];
    static int[] Valor_Repetido = new int[11];

//inicializa los valores
    static void Carga_De_Valores()
    {
        int num;
        bool num_valido;
        for (int i = 0; i < arreglo.Length; i++)
        {
            do
            {
                Console.WriteLine($"ingrese el numero{i + 1}");
                num_valido = int.TryParse(Console.ReadLine(), out num);
            } while (!(num_valido && num > 0 && num <= 10));
            arreglo[i] = num;
        }
    }

//hace en el arreglo de tamaño 10 si el numero esta en el tamaño del arreglo lo suma
    static void Contar_Valores()
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Valor_Repetido[arreglo[i] ]++;
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
        for (int i = 1; i < Valor_Repetido.Length; i++)
        {
            if (Valor_Repetido[i] > max)
            {
                max = Valor_Repetido[i];
                indice = i;
            }
        }
        return indice+1;
    }
    static void Main()
    {
        Carga_De_Valores();
        Contar_Valores();
        int valor = Valor_Mas_Frecuente();
        Console.WriteLine("El valor más frecuente es el: " + valor);
    }
        }
    
