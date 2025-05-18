/*Una tienda registra el valor total de sus ventas diarias durante una semana (7 días).
Desarrollar un programa que permita cargar los totales diarios de ventas y luego
muestre por pantalla cuántos días superaron el promedio.*/
double[] a_ventas;
a_ventas=new double[7];
double promedio,suma;
suma=0;
int contador;
bool valido;
for(int i=0;i<a_ventas.Length;i++)
{
    do
    {
        Console.Write($"ingrese el gasto numero {i+1}:");
        valido=double.TryParse(Console.ReadLine(),out a_ventas[i]);
    }while(!(valido && a_ventas[i]>0));
    suma+=a_ventas[i];
}
promedio=suma/a_ventas.Length;
contador=0;
for(int i=0;i<a_ventas.Length;i++)
{
    if(a_ventas[i]>promedio)
    {
        contador++;
    }
}
Console.WriteLine($"el promedio de ventas diarios es: {promedio:f2}");
Console.WriteLine($"hay {contador} registros que superan el promedio diario");
