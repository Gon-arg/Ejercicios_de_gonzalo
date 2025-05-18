// Realizar un programa en C# que solicite al usuario un número entero positivo, y
//luego en pantalla muestre solamente los números pares desde el 1 hasta el número
//ingresado.
//Ej: usuario ingresa 10, en pantalla se mostrará 2 4 6 8 10
Console.WriteLine("ingrese tope:");
int tope=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("pares:");
for (int i=1;i<=tope;i++)
{
    if (i%2==0)
    Console.Write($"{i},");
}
