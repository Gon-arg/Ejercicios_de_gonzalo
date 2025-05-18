/*Escribe un programa en C# que genere un arreglo de 20 lugares y lo llene con
números aleatorios entre 1 y 100. Luego el programa debe calcular el promedio de
los valores contenidos en el arreglo, y mostrar por pantalla cuántos elementos son
mayores l promedio calculado.*/
Random random=new Random();
int[] a_lugares=new int[20];
int suma=0;
int contador=0;
int contador2=0;
for(int i=0;i<a_lugares.Length;i++)
{
    a_lugares[i]=random.Next(1,101);
}
for(int i=0;i<a_lugares.Length;i++)
{
    Console.WriteLine($"numero ({i+1}):{a_lugares[i]}");
}
for(int i=0;i<a_lugares.Length;i++)
{
    suma+=a_lugares[i];
    contador++;
}
double promedio=suma/contador;
for(int i=0;i<a_lugares.Length;i++)
{
    if(a_lugares[i]>promedio)
    {
        contador2++;
    }
}
Console.WriteLine($"promedio:{promedio}");
Console.WriteLine($"hay {contador2} numeros que superan el promedio");