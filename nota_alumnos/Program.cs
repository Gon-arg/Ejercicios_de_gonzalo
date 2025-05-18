// Realizar un programa que pida tres notas de un alumno, (primer parcial, segundo
//parcial y proyecto integrador), calcule el promedio 
Console.WriteLine("ingrese notas del 1 al 10");
Console.WriteLine("primer parcial");
int nota1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("segundo parcial");
int nota2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" proyecto integrador");
int nota3=Convert.ToInt32(Console.ReadLine());
double promedio=(nota1+nota2+nota3)/3;
if (promedio>=6 && promedio<=10)
{
    Console.Write("cursa y promociona");
}
else if (promedio>=4 && promedio<6)
{
    Console.Write("Cursa y rinde examen final");
}
else
{
    Console.Write("no cursa");
}