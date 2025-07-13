/*Escriba una función llamada EsBisiesto que permita ingresar un numero de año y
devuelva verdadero en caso que el año sea bisiesto, o falso cuando no lo es. Un año
es bisiesto si: es divisible entre cuatro y (no es divisible entre 100 o es divisible entre
400). Utilizarlo en un programa que permita ingresar dia, mes y año y muestre por
pantalla si la fecha es válida o no*/
using System;
class Program
{
    static bool EsBisiesto(int  año)
    {
        return (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0));
    }

    static void Main()
    {
        Console.WriteLine("ingrese año:");
        int año = int.Parse(Console.ReadLine()!);
        if (EsBisiesto(año))
        {
            Console.WriteLine("el año es bisiesto");
        }
        else
        {
        Console.WriteLine("el año no es bisiesto");
        }
    }
}