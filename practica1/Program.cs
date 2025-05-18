// See https://aka.ms/new-console-template for more information
using System.IO.Compression;

Console.WriteLine("ingrese un numero mayor a 10: ");
int num=Convert.ToInt32(Console.ReadLine());
if (num>10)
{
    Console.WriteLine("el numero es mayor a 10");
}

while (num<10)
{
    Console.WriteLine("ingrese otro numero:");
    num=Convert.ToInt32(Console.ReadLine());
}