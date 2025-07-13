/*Escribir un procedimiento Reverso que permita ingresar como parametro una
cadena, y mediante un parametro por referencia devuelva la cadena invertida (“hola”
se convierte en “aloh”). Escribir luego un programa que determine si una cadena de
caracteres es un palíndromo (un palíndromo es un texto que se lee igual en sentido
directo y en inverso, ej.: “radar”). Sugerencia: para evitar diferencias entre
mayúsculas y minúsculas en las cadenas, utilice la función del tipo string .ToUpper()
ó .ToLower() en las cadenas, ya que si evaluamos estrictamente las cadenas Radar
es distinto a radaR.*/
using System;
class Program
{
    static void Reverso(ref string cadena)
    {
        Console.WriteLine("reverso:");
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            Console.Write($"{cadena[i]}");
        }
        Console.WriteLine();
    }

    static void Palíndromo(ref string cadena)
    {
        string vacio = "";
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            vacio += cadena[i];
        }
        if (vacio == cadena)
        {
            Console.WriteLine($"la cadena {cadena} es un palindromo");
        }
        else
        {
            Console.WriteLine($"la cadena {cadena} no es un palindromo");

        }
    }
    static void Main()
    {
        Console.Write("ingrese la cadena:");
        string cadenaa = Console.ReadLine()!;
        Console.WriteLine($"cadena:{cadenaa}");
        Reverso(ref cadenaa);
        Palíndromo(ref cadenaa);
    }
}
