/*Diseñar y escribir una función de tipo double llamada RedondearCentesima que
devuelva un numero double redondeado a dos posiciones decimales. Usarla en un
programa o procedimiento que la invoque.
Por ejemplo: RedondearCentesima(1.236589) debe devolver 1.24
mientras que RedondearCentesima(1.9238) debe devolver 1.92
Sugerencia: utilizar multiplicaciones, módulo y divisiones 
para obtener el resultado.*/
using System;
class Program
{
    static double RedondearCentesima(double num)
    {
        Console.WriteLine($"el numero redondeado:{Math.Round(num,2)}");
        return num;
    }
    static void Main()
    {
        double numero;
        bool numero_valido;
        do
        {
            Console.Write("ingrese un numero de tipo double");
            numero_valido = double.TryParse(Console.ReadLine(), out numero);
        } while (!numero_valido);
        Console.WriteLine($"numero sin redondear:{numero}");
        RedondearCentesima(numero);
    }
}