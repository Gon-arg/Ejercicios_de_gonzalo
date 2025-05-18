// Cree un programa que calcule la edad actual del usuario. Considerar días y meses, y
//si, en el momento de la evaluación cumple años, imprimir un mensaje con la
//felicitación.
Console.WriteLine("ingrese dia de nacimiento:");
int dia =int.Parse(Console.ReadLine()!);
Console.WriteLine("ingrese mes de nacimiento:");
int mes =int.Parse(Console.ReadLine()!);
Console.WriteLine("ingrese año de nacimiento:");
int año =int.Parse(Console.ReadLine()!);
Console.WriteLine("ingrese dia y mes de hoy");
int dia_hoy =int.Parse(Console.ReadLine()!);
Console.WriteLine("ingrese dia y mes de hoy");
int mes_hoy =int.Parse(Console.ReadLine()!);
int edad=2025-año;
Console.Write($"edad:{edad}");
if (dia==dia_hoy && mes==mes_hoy)
{
    Console.Write("Feliz Cumpleaños");
}