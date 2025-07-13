/*Crear un nuevo proyecto en C#, y escribir un procedimiento MostrarMenu() que se
encargue de mostrar la bienvenida al programa y un menú que permita elegir qué
ejercicio del 5 al 11 de este practico desea ejecutar. Aclaración: Los puntos 12 y 13
realizarlos en proyectos nuevos para evitar confusiones con los métodos.*/
using System;

class Program
{
    static void Mostrar_Menu()
    {
        Console.WriteLine($"Bienvenido al menu");
        Console.WriteLine($"que ejercicios del 5 al 11 desea ejecutar");
    }
    static void Main()
    {
        int numero;
        bool numero_valido;
        Mostrar_Menu();
        do
        {
            Console.Write("ingrese:");
            numero_valido = int.TryParse(Console.ReadLine(), out numero);
        } while (!(numero_valido && numero>=5 && numero<=11));
    }
}
