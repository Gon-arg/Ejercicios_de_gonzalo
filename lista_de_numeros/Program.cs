// Pedir al usuario un número base y un número tope, y mostrar todos los números enteros entre base y tope inclusive.
Console.WriteLine("ingrese el numero base:");
int Base=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el numero de tope:");
int tope=Convert.ToInt32(Console.ReadLine());
for(int i=Base;i<=tope;i++)
{
    Console.WriteLine($"numero:{i}");
}