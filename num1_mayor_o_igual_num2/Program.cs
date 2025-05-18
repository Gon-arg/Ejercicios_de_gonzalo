// dados dos números num1 y num2, determinar si num1 es mayor o igual a
//num2.
Console.WriteLine("ingrese el primer numero");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero");
int num2= Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.Write($"el numero {num1} es mayor que {num2}");
}
else if (num1==num2)
{
    Console.Write($"el numero {num1} es es igual que {num2}");
}
