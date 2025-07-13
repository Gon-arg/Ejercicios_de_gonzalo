/*Crea un procedimiento llamado IntercambiarValor que acepte dos parámetros
enteros por valor. Dentro del método, intercambia los valores de los dos parámetros.
En el programa principal, declara dos variables enteras, asigna valores, llama al
método Intercambiar. Imprimí los valores de las variables antes y después de
llamar al método para observar el cambio.*/
using System;
class Program
{
    static void IntercambiarValor(ref int num1, ref int num2)
    {
        int cambio = num1;
        num1 = num2;
        num2 = cambio;
        Console.WriteLine($"el numero (1) ahora es {num1} y el numero (2) ahora es {num2}");
    }
    static void Main()
    {
        Console.WriteLine("ingrese el primer valor:");
        int numero1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese el segundo valor:");
        int numero2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"el numero (1) {numero1} el numero (2) {numero2}");
        IntercambiarValor(ref numero1,ref numero2);

}

}




