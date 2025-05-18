// Cree un programa que pida los tres lados de un triángulo e indique el tipo de triángulo
//que es según sus lados: Equilátero (tres lados iguales), Isósceles (dos lados iguales) o
//Escaleno (tres lados distintos).
Console.WriteLine("ingrese el primer lado del triangulo");
double lado1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el segundo lado del triangulo");
double lado2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el tercer lado del triangulo");
double lado3=Convert.ToDouble(Console.ReadLine());
if(lado1==lado2 && lado1==lado3)
{
    Console.Write("el triangulo es Equilatero");
}
else if(lado1==lado2 || lado1==lado3 || lado2==lado3)
{
    Console.Write("el triangulo es isosceles");
}
else
{
    Console.Write("El triangulo es Escaleno");
}