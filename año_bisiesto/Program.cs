//dado un entero que representa un año, indique si corresponde a un año bisiesto
//o no (un año es bisiesto si es múltiplo de 4 y no de 100; o es múltiplo de 400)
Console.Write("ingrese año:");
int año=Convert.ToInt32(Console.ReadLine());
if (año%100==0)
{
    Console.Write("este año no es bisiesto");
}
else if(año%4==0 || año%400==0) 
{
    Console.Write("este año  es bisiesto");
}
else
{
    Console.Write("el año no es bisiesto");
}
