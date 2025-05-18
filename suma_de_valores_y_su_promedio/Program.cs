/*Desarrollar un programa que permita al usuario indicar cuantos valores quiere
ingresar, luego que permita la carga de los valores por teclado y nos muestre
posteriormente la suma de los valores ingresados y su promedio.*/
Console.Write("ingrese la cantidad de valores:");
int valores=Convert.ToInt32(Console.ReadLine());
int contador=0;
int valor=1;
int suma=0;
while(valores!=contador)
{
    Console.WriteLine($"ingrese el valor{valor}:");
    int num = Convert.ToInt32(Console.ReadLine());
    valor++;
    contador++;
    suma=suma+num;
}
Console.Write($"suma={suma} y promedio={suma/valores}");