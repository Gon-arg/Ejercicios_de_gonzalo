/*Escriba un programa que permita el ingreso de números enteros positivos para
calcular su promedio, el ingreso finaliza cuando el usuario ingresa un número
negativo. Luego mostrar el promedio y la cantidad de valores que se ingresaron. Ej:
“El promedio es ….. con un total de …. ingresos.”*/
int num=0;
int suma=0;
int ingreso=0;
while(num>=0)
{
    Console.WriteLine("ingrese un numero entero positivo:");
    num=int.Parse(Console.ReadLine()!);
    suma=suma+num;
    ingreso++;
}
Console.WriteLine($"el promedio es {suma/ingreso} con un total de {ingreso} ingresos");