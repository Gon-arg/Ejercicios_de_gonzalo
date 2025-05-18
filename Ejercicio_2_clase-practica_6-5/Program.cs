/*En una estación meteorológica se registraron las temperaturas diarias (máxima y
mínima) durante una semana (7 días). Nos piden desarrollar un programa en C#
que permita calcular y mostrar el promedio de la semana, informar cuántos días
tuvieron una temperatura menor al promedio, mostrar la temperatura más baja
registrada y en qué día ocurrió (usar índice) y mostrar la temperatura más alta
registrada y en qué día ocurrió (usar índice).*/
double[,] a_temperaturas=new double[7,2];
bool numero_valido;
double suma=0;
double promedio_semana;
double promedio_dia;
double  cant_temperatura_menor;
double temperatura_minima;
double temperatura_maxima;
int cantidad_de_max=0;
int cantidad_de_minima=0;
for(int dia=0;dia<7;dia++)
{
    do
    {
        Console.WriteLine($"ingrese la temperatura maxima del dia({dia}):");
        numero_valido=double.TryParse(Console.ReadLine(),out a_temperaturas[dia,0]);
    }while(!numero_valido);
    do
    {
        Console.WriteLine($"ingrese la temperatura minima del dia({dia}):");
        numero_valido=double.TryParse(Console.ReadLine(),out a_temperaturas[dia,1]);
    }while(!numero_valido);
}
for(int dia=0;dia<7;dia++)
{
    suma=suma+ (a_temperaturas[dia,0] + a_temperaturas[dia,1])/2;
}
promedio_semana=suma/7;
Console.WriteLine($"el promedio de la semana es {promedio_semana:F2}");
cant_temperatura_menor=0;
temperatura_maxima=a_temperaturas[0,1];
temperatura_minima=a_temperaturas[0,0];
for(int dia=0;dia<7;dia++)
{
promedio_dia=(a_temperaturas[dia,0]+a_temperaturas[dia,1])/2;
if(promedio_dia<promedio_semana)
{
    cant_temperatura_menor++;
}
if(a_temperaturas[dia,0]>temperatura_maxima)
{
    temperatura_maxima=a_temperaturas[dia,0];
    cantidad_de_max=dia;
}
if(a_temperaturas[dia,1]<temperatura_minima)
{
    temperatura_minima=a_temperaturas[dia,1];
    cantidad_de_minima=dia;
}
}
Console.WriteLine($"el promedio de la semana es:{promedio_semana}");
Console.WriteLine($"hubo {cant_temperatura_menor} dias con una temperatura menor al promedio");
Console.WriteLine($"la temperatura mas alta fue {temperatura_maxima} grados el dia {cantidad_de_max}");
Console.WriteLine($"la temperatura mas baja fue {temperatura_minima} grados el dia {cantidad_de_minima}");