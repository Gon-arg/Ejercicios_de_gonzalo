/*Escribir un programa en C# que permita ingresar caracteres de a uno y determinar si
es o no un dígito. Crear la función lógica Es_Digito que devuelve Verdadero si el
caracter es un dígito, y Falso si no lo es.*/
using System;
class Program
{
    // Esta función devuelve true o false según si el carácter es un dígito
    static bool Es_Digito(char caracter)
    {
        return caracter >= '0' && caracter <= '9';
    }
    static void Main()
    {
        char caracter;
        bool char_valido;

        do
        {
            Console.Write("Ingrese un carácter: ");
            char_valido = char.TryParse(Console.ReadLine(), out caracter);
        } while (!char_valido);
        if (Es_Digito(caracter))
        {
            Console.WriteLine("El carácter es un dígito.");
        }
        else
        {
            Console.WriteLine("El carácter no es un dígito.");
        }
    }
}
