//determinar si un numero es par o impar
Console.WriteLine("ingres un numero:");
int numero=Convert.ToInt32(Console.ReadLine());

if (numero>0)
    {
if (numero%2==0)    {
Console.WriteLine("el numero es par");
} else{
Console.WriteLine("el numeroe es impar");
}
    }
else{
    Console.WriteLine("el numeroe es negativo");
}