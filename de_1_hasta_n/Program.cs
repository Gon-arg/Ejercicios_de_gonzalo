// Realizar un programa en C# que solicite al usuario un número entero positivo, y
//luego en pantalla muestre la secuencia de números desde el 1 hasta el número
//ingresado.
//Ej: usuario ingresa 10, en pantalla se mostrará 1 2 3 4 5 6 7 8 9 10

Console.WriteLine("ingrese numero tope:");
int tope=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=tope;i++)
{
    Console.WriteLine($"numero: {i}");
}
