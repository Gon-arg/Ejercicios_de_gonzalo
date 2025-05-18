// Cree un programa que solicite al usuario el lado de un cuadrado. Luego le debe pedir
//una opción al usuario, si elige 1, le debe mostrar el perímetro del cuadrado, si elige 2,
//le debe mostrar el área del cuadrado.
Console.WriteLine("ingrese el valor del dado del cuadrado:");
double lado=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el 1 para calcular perimetro o 2 para calcular area:");
int calculo=Convert.ToInt32(Console.ReadLine());
if (calculo==1 && lado>0)
{
    Console.Write($"Perimetro:{lado*4}");
}
else if(calculo==2 && lado>0)
{
    Console.Write($"Area:{lado*lado}");
}
else
{
    Console.Write("un valor a sido mal ingresado");
}
