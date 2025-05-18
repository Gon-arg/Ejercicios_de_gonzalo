// Escriba un programa que dados tres valores enteros “base”, “tope” y “num”
//ingresados por el usuario, muestre y cuente cuantos enteros 
//hay entre “base” y “tope” que sean múltiplos de “num”
Console.WriteLine("ingrese el numero base:");
int Base=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el numero de tope:");
int tope=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el numero multiplo:");
int multiplo=Convert.ToInt32(Console.ReadLine());
int contador=0;
for(int i=Base;i<=tope;i++)
{
    if(i%multiplo==0)
    {
        contador=contador+1;
    }
}
Console.Write($"entre {Base} y {tope} hay {contador} numeros multiplos de {multiplo}");

