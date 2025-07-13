/*Una empresa quiere analizar las ventas de una de sus sucursales, para ello debe
cargar las ventas mensuales en un arreglo de 12 posiciones (una por mes) para
realizar las siguientes estadísticas:
a. Hacer un procedimiento que se encargue de cargar los valores de las ventas.
b. Hacer un procedimiento que muestre todas las ventas.
c. Hacer una función que devuelva el total anual vendido.
d. Hacer otra función que devuelva el promedio mensual de ventas.
e. Hacer una función que muestre los meses donde las ventas superaron el
promedio anual.
f. Hacer una función donde se muestren los meses que las ventas estuvieron
por debajo del promedio anual.
g. Desde el programa principal llamar a los métodos correspondientes y mostrar
los resultados.
*/
using System;

class Program
{
    static int[] a_ventas = new int[12];
    static int[] a_meses = new int[12];


    static void Cargar_Valores()
    {
        int num;
        bool num_valido;
        for (int i = 0; i < a_ventas.Length; i++)
        {
            Console.WriteLine($"ingrese las ventas de las ventas del mes({i + 1})");
            num_valido = int.TryParse(Console.ReadLine(), out num);
            a_ventas[i] = num;
        }
    }

    static void Mostrar_Ventas()
    {
        for (int i = 0; i < a_ventas.Length; i++)
        {
            Console.WriteLine($"ventas del mes ({i+1}):{a_ventas[i]}$");
        }
    }

    static int Total_Vendido()
    {
        int suma = 0;
        for (int i = 0; i < a_ventas.Length; i++)
        {
            suma += a_ventas[i];
        }
        Console.WriteLine($"total vendido:{suma}");
        return suma;
    }

    static int Promedio_Mensual()
    {
        int suma = 0;
        for (int i = 0; i < a_ventas.Length; i++)
        {
            suma += a_ventas[i];
        }
        int promedio = suma / a_ventas.Length;
        return promedio;
    }

    static int Meses_Que_Superaron_Promedio_Anual()
    {
        Console.WriteLine("meses que superaron el promedio anual:");
        int Superaron=0;
        for (int i = 0; i < a_ventas.Length; i++)
        {
            if (a_ventas[i] > Promedio_Mensual())
            {
                Superaron = i;
                Console.WriteLine($"mes:{Superaron+1

                }");
            }
        }
                return Superaron;
    }

        static int Meses_Que_No_Superaron_Promedio_Mensual()
    {
        Console.WriteLine("meses que no superaron el promedio mensual:");
        int No_Superaron=0;
        for (int i = 0; i < a_ventas.Length; i++)
        {
            if (a_ventas[i] < Promedio_Mensual())
            {
                No_Superaron = a_ventas[i];
                Console.WriteLine($"mes:{i+1}");
            }
        }
                return No_Superaron;

    }

    static void Main()
    {
        Cargar_Valores();
        Mostrar_Ventas();
        Total_Vendido();
        Console.WriteLine($"promedio mensual:{Promedio_Mensual()}");
        Meses_Que_Superaron_Promedio_Anual();
        Meses_Que_No_Superaron_Promedio_Mensual();
    }
}

