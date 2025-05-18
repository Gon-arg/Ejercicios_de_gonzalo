// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("ingrese la altura del piso de asteriscos:");
int pisos=Convert.ToInt32(Console.ReadLine());
string asterisco="";
string aste="*";
int contador=0;
while (pisos!=contador)
{
    contador++;
    asterisco=asterisco+aste;
    Console.WriteLine(asterisco);
}*/
/*Console.Write("ingrese pisos:");
int pisos=int.Parse(Console.ReadLine()!);
while(pisos!=0)
{
Console.WriteLine(new string('*', pisos));
pisos--;
}*/
Console.WriteLine("ingrese la altura del piso de asteriscos:");
int pisos=Convert.ToInt32(Console.ReadLine());
string asterisco="";
string aste="*";
int contador=0;
while (pisos!=contador)
{
    contador++;
    asterisco=asterisco+aste;
    Console.WriteLine(asterisco);
}
while(pisos!=0)
{
Console.WriteLine(new string('*', pisos-1));
pisos--;
}