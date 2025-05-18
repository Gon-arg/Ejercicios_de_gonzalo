/* Se desea realizar una aplicación que solicite al usuario tres números enteros
positivos (A, B, y X), y que muestre por pantalla todos los múltiplos de X que estén
entre A y B inclusive. Realice un algoritmo antes de escribir el programa, luego
implemente en C# utilizando un ciclo FOR.*/
Console.WriteLine("ingrese el primer numero positivo: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero positivo: ");
double b=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el tercer numero positivo: ");
double x=Convert.ToDouble(Console.ReadLine());
for(double i=0;i<=x;i++)
{
    if(x%i==0 && b%i==0 && a%i==0)
    {
        Console.WriteLine($"{i} es multiplo de los 3");
    }
}
