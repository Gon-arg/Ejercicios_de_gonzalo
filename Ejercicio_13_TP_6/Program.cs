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
/*La misma empresa del punto anterior decidió ahora repetir el proceso de análisis de
ventas extendiéndolo a sus 5 sucursales. Para ello se necesita un arreglo de
nombres de sucursales y una matriz que permita identificar las ventas de cada mes
en cada sucursal. Luego se deben realizar las siguientes estadísticas:
a. Mostrar la sucursal que más vendió en el año
b. Mostrar el mes de mayores ventas en la sucursal que más vendió en el año
c. Elegir una sucursal y mostrar las ventas mensuales que tuvo
d. Mostrar el promedio mensual de ventas de la empresa, y luego el promedio
anual de ventas. (considerando las ventas de todas las sucursales)*/

using System;

class Program
{
    static int[] a_ventas = new int[5];
    static int[] a_promedio = new int[5];
    static int[,] a_sucursales = new int[5, 12];


    static void Cargar_Valores()
    {
        int num;
        bool num_valido;
        for (int i = 0; i < a_sucursales.GetLength(0); i++) // filas
        {
            for (int j = 0; j < a_sucursales.GetLength(1); j++) // columnas
            {
                do
                {
                    Console.Write($"ingrese los datos de la sucursal {i + 1} del mes({j + 1})");
                    num_valido = int.TryParse(Console.ReadLine(), out num);
                } while (!(num_valido && num > 0));
                a_sucursales[i, j] = num;
            }
        }
    }

    static void Mostrar_Ventas()
    {
        for (int i = 0; i < a_sucursales.GetLength(0); i++)
        {
            for (int j = 0; j < a_sucursales.GetLength(1); j++)
            {
                Console.WriteLine($"ventas sucurscal {i + 1} mes:{j + 1}:{a_sucursales[i, j]}$");
            }
        }
    }

    static int Total_Vendido()
    {
        int suma = 0;
        for (int i = 0; i < a_sucursales.GetLength(0); i++)
        {
            for (int j = 0; j < a_sucursales.GetLength(1); j++)
            {
                suma += a_sucursales[i, j];
            }
        }
        return suma;
    }

    static int[] Promedio_Mensual()
    {
        int suma_1 = 0;
        int suma_2 = 0;
        int suma_3 = 0;
        int suma_4 = 0;
        int suma_5 = 0;
        for (int i = 0; i < a_sucursales.GetLength(0); i++)
        {
            for (int j = 0; j < a_sucursales.GetLength(1); j++)
            {
                switch (a_sucursales[i, 0])
                {
                    case 1:
                        suma_1 += a_sucursales[i, j];
                        break;
                    case 2:
                        suma_2 += a_sucursales[i, j];
                        break;
                    case 3:
                        suma_3 += a_sucursales[i, j];
                        break;
                    case 4:
                        suma_4 += a_sucursales[i, j];
                        break;
                    case 5:
                        suma_5 += a_sucursales[i, j];
                        break;
                }
            }
        }
        int[] promedios = new int[5];
        promedios[0] = suma_1 / a_ventas.Length;
        promedios[1] = suma_2 / a_ventas.Length;
        promedios[2] = suma_3 / a_ventas.Length;
        promedios[3] = suma_4 / a_ventas.Length;
        promedios[4] = suma_5 / a_ventas.Length;
        return promedios;
    }

    static int Meses_Que_Superaron_Promedio_Anual()
    {
        int total_anual = Total_Vendido();
        int cantidad_meses = a_sucursales.GetLength(1);
        int promedio_anual = total_anual / cantidad_meses;

        Console.WriteLine("Meses que superaron el promedio anual:");
        int contador = 0;

        for (int mes = 0; mes < cantidad_meses; mes++)
        {
            int total_mes = 0;

            for (int sucursal = 0; sucursal < a_sucursales.GetLength(0); sucursal++)
            {
                total_mes += a_sucursales[sucursal, mes];
            }

            if (total_mes > promedio_anual)
            {
                Console.WriteLine($"Mes {mes + 1} superó el promedio con: {total_mes}");
                contador++;
            }
        }

        return contador;
    }


    static int Meses_Que_No_Superaron_Promedio_Mensual()
    {
        int total_anual = Total_Vendido();
        int cantidad_meses = a_sucursales.GetLength(1);
        int promedio_anual = total_anual / cantidad_meses;

        Console.WriteLine("Meses que no superaron el promedio mensual:");
        int contador = 0;

        for (int mes = 0; mes < cantidad_meses; mes++)
        {
            int total_mes = 0;

            for (int sucursal = 0; sucursal < a_sucursales.GetLength(0); sucursal++)
            {
                total_mes += a_sucursales[sucursal, mes];
            }

            if (total_mes < promedio_anual)
            {
                Console.WriteLine($"Mes {mes + 1} no superó el promedio con: {total_mes}");
                contador++;
            }
        }
        return contador;
    }

    //Mostrar la sucursal que más vendió en el año
    static int Sucursal_Que_Mas_Vendio_En_El_Año()
    {
        int[] totales = new int[5];

        for (int i = 0; i < a_sucursales.GetLength(0); i++)
        {
            for (int j = 0; j < a_sucursales.GetLength(1); j++)
            {
                totales[i] += a_sucursales[i, j];
            }
        }

        int maxVenta = totales[0];
        int maxIndex = 0;

        for (int i = 1; i < totales.Length; i++)
        {
            if (totales[i] > maxVenta)
            {
                maxVenta = totales[i];
                maxIndex = i;
            }
        }

        return maxIndex + 1;
    }

    //Mostrar el mes de mayores ventas en la sucursal que más vendió en el año
    static int Mes_De_Mayor_Ventas_En_Sucursal(int sucursalIndex)
    {
        int maxMes = 0;
        int maxVenta = a_sucursales[sucursalIndex, 0];

        for (int mes = 1; mes < a_sucursales.GetLength(1); mes++)
        {
            if (a_sucursales[sucursalIndex, mes] > maxVenta)
            {
                maxVenta = a_sucursales[sucursalIndex, mes];
                maxMes = mes;
            }
        }

        return maxMes + 1; // Para mostrar mes 1-12
    }

    static void Main()
    {
        Cargar_Valores();
        Mostrar_Ventas();

        int total = Total_Vendido();
        Console.WriteLine($"Total anual vendido: {total}");

        int[] promedios = Promedio_Mensual();
        Console.WriteLine("Promedio mensual por sucursal:");
        for (int i = 0; i < promedios.Length; i++)
        {
            Console.WriteLine($"Sucursal {i + 1}: {promedios[i]}");
        }

        Meses_Que_Superaron_Promedio_Anual();
        Meses_Que_No_Superaron_Promedio_Mensual();

        int mejorSucursal = Sucursal_Que_Mas_Vendio_En_El_Año();
        Console.WriteLine($"La sucursal que más vendió en el año es la sucursal: {mejorSucursal}");

        int mejorMes = Mes_De_Mayor_Ventas_En_Sucursal(mejorSucursal - 1);
        Console.WriteLine($"El mes de mayor venta en esa sucursal fue el mes: {mejorMes}");
    }
}

