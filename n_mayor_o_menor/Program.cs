// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese el primer numero: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero: ");
int num2=Convert.ToInt32(Console.ReadLine());
if (num1>0 && num2>0){
    Console.WriteLine("los numeros son positivos");
    if(num1>num2)
    {
        Console.WriteLine($"{num1} es mayor que {num2}");
    }
    else if (num2>num1)
    {
        Console.WriteLine($"{num2} es mayor que {num1}");
    }
    else
    {
        Console.WriteLine("los dos numeros son iguales");
    }
}else if (num1<0 && num2<0){
    Console.WriteLine("los dos son negativos");
}
