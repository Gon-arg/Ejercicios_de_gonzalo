/*Crea otro procedimiento llamado IntercambiarReferencia que acepte dos
parámetros por referencia (ref). Dentro del método, intercambia los valores de los dos parámetros.
En el programa principal, declara dos variables enteras, asigna valores, llama al
método Intercambiar. Imprimí los valores de las variables antes y después de
llamar al método para observar el cambio.*/
using System;
class Program
{
    static void IntercambiarReferencia(ref int num1, ref int num2)
    {
        int cambio = num1;
        num1 = num2;
        num2 = cambio;
        Console.WriteLine($"despues de llamar el metodo:numero1={num1} y num2={num2}");
    }

    static void Main()
    {
        Console.Write("ingrese el numero (1):");
        int numero1 = int.Parse(Console.ReadLine()!);
        Console.Write("ingrese el numero (2):");
        int numero2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"antes de llamar a la funcion:num1={numero1}, num2={numero2}");
        IntercambiarReferencia(ref numero1,ref numero2);
    }
}