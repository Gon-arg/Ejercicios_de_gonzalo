/*Un atleta se está preparando para una competencia importante, y nos pidió que
registráramos sus marcas durante un entrenamiento. Realizará la misma prueba 10
veces, debemos registrar sus marcas (en segundos). Luego calcular el promedio y
mostrar cuál fue su mejor marca y su peor marca (tiempo y posición).*/
double[] a_segundos;
a_segundos=new double[10];
double promedio,suma;
suma=0;
int posicion_mejor=0;
int posicion_peor=0;
bool valido;
for(int i=0;i<a_segundos.Length;i++)
{
    do
    {
        Console.Write($"ingrese el tiempo de la marca numero ({i+1}):");
        valido=double.TryParse(Console.ReadLine(),out a_segundos[i]);
    }while(!(valido && a_segundos[i]>0));
    suma+=a_segundos[i];
}
promedio=suma/a_segundos.Length;
double max=a_segundos[0];
double min=a_segundos[0];
for(int i=0;i<a_segundos.Length;i++)
{
    if(a_segundos[i]>max)
    {
        max=a_segundos[i];
        posicion_mejor=i;
    }
    else if(a_segundos[i]<min)
    {
        min=a_segundos[i];
        posicion_peor=i;
    }
}
Console.WriteLine($"el promedio de segundos es: {promedio:f2} segundos");
Console.WriteLine($"su mejor marca fue {min} segundos en la posicion: {posicion_peor+1}");
Console.WriteLine($"su mejor peor marca fue {max} segundos en la posicion: {posicion_mejor+1}");

