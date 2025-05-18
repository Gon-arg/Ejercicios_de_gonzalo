/*Realizar un programa en C# que pida al usuario un número entero positivo y luego
muestre sus divisores.*/
Console.Write("ingrese un numero entero positivo:");
int num = Convert.ToInt32(Console.ReadLine());
int contador=1;
while(contador<=num)
{
    if (num%contador==0)
    {
        Console.WriteLine($"{contador}");
    }
    contador++;
}
