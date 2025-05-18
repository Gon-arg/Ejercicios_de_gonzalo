//dados tres números a, b, y c, si la diferencia entre a y b es mayor que c,
//calcular el producto de a y b; de lo contrario, calcular el cociente entre a y b.
Console.WriteLine("ingrese el primer numero:");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero:");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el tercer numero:");
int c=Convert.ToInt32(Console.ReadLine());
if (a+b>c)
{
    Console.Write($"producto de a y b {a*b}");
}
else
{
    Console.Write($"cociente de a y b {a%b}");
}

