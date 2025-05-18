/*Escriba un programa que permita el ingreso de números enteros positivos para
calcular su promedio, el ingreso finaliza cuando el usuario ingresa un número
negativo. Luego mostrar el promedio y la cantidad de valores que se ingresaron. Ej:
“El promedio es ….. con un total de …. ingresos.”*/
int numero;
int suma=0;
int contador=0;
bool numero_valido;
do{
do
{
Console.WriteLine("ingrese un numero entero positivo fnalice el programa con (0):");
numero_valido=int.TryParse(Console.ReadLine(),out numero);
}while(!numero_valido);
suma+=numero;
contador++;
}while(!(numero==0));
int promedio=suma/contador;
Console.WriteLine($"el promedio es :{promedio} con un total de {contador-1} ingresos");
