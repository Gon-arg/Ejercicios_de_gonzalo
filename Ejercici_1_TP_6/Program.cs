/*Considerando la siguiente función
static int Invertir(int numero)
{
int invertido = 0;
while (numero > 0)
{
 invertido = invertido * 10 + (numero % 10);
numero = numero / 10;
}
return invertido;
}
Realice un programa que pida al usuario un número entero y utilice dicha función
para determinar si el número ingresado es capicúa o no.
Por ejemplo: si Num=45654, el programa deberá mostrar “El número 45654 es
capicúa”. Si Num=12341 el programa deberá mostrar “El número 12341 no es
capicúa”.
*/
using System;

class Program
{
    static int Invertir(int numero)
    {
        int invertido = 0;
        while (numero > 0)
        {
            invertido = invertido * 10 + (numero % 10);
            numero = numero / 10;
        }
        return invertido;
    }

    static void Main()
    {
        Console.WriteLine($"ingrese un numero:");
        int numero = int.Parse(Console.ReadLine()!);
        if (numero == Invertir(numero))
        {
            Console.WriteLine($"el numero {numero} es capicua");
        }
        else
        {
            Console.WriteLine($"el numero {numero} no es capicua");
        }

}
}