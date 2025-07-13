/*Creá un método ConvertirSegundos que reciba un número entero de segundos y
devuelva la cantidad de minutos y segundos restantes como parámetros out.
Por ejemplo: ConvertirSegundos(135, out minutos, out segundos); debe devolver
minutos = 2, segundos = 15*/
using System;
class Program
{
    static int ConvertirSegundos(int tiempo, out int minutos, out int segundos)
    {
        minutos = tiempo / 60;
        segundos = tiempo % 60;
        Console.WriteLine($"minutos={minutos}, segundos={segundos}");
        return minutos;
        
    }
    static void Main()
    {
        int minutos; 
        int segundos;
        Console.Write("ingrese el tiempo en segundos:");
        int tiempo = int.Parse(Console.ReadLine()!);
        ConvertirSegundos(tiempo,out minutos,out segundos);
    }
}
