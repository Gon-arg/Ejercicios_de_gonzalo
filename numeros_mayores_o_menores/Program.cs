// Cree un programa que pida tres números e indique cuál es el menor y el mayor
Console.WriteLine("ingrese el primer numero");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el tercer numero");
int num3=Convert.ToInt32(Console.ReadLine());
if(num1>num2 && num1>num3)
{
    Console.WriteLine($"{num1}: es el numero mayor");
    if( num2>num3)
    {
        Console.WriteLine($"{num3}: es el numero menor");
    }
    else
    {
        Console.WriteLine($"{num2}:es el numero menor");
    }
}
else if(num2>num1 && num2>num3)
{
    Console.WriteLine($"{num2}: es el numero mayor");
    if(num1>num3)
    {
        Console.WriteLine($"{num3}: es el numero menor");
    }
    else
    {
        Console.WriteLine($"{num1}: es el numero menor");
    }
}
else if(num3>num1 && num3>num2)
{
    Console.WriteLine($"{num3}: es el numero mayor");
    if(num2>num1)
    {
        Console.WriteLine($"{num1}: es el numero menor");
    }
    else
    {
        Console.WriteLine($"{num2}: es el numero menor");
    }
}
