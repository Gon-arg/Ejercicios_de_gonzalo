/*Crea una función llamada PedirNumeroEnteroPositivo que se encargue de
solicitar un numero entero positivo 
validando el ingreso, y luego lo devuelva como retorno de la función.*/
using System;
class Program
{
    
    static void Main()
    {
        int numero = PedirNumeroEnteroPositivo();
        Console.WriteLine("El número ingresado es: " + numero);
    }

    static int PedirNumeroEnteroPositivo()
    {
        int numero;
        bool num_valido;
        do
        {
            Console.WriteLine("ingrese un numero positivo");
            num_valido = int.TryParse(Console.ReadLine(), out numero);
        } while (!(num_valido && numero > 0));
        return numero;
    }
}
