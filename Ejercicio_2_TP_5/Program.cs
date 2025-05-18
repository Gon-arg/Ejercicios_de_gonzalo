/*Escribe un programa en C# que genere un arreglo de 10 lugares y lo llene con
números aleatorios entre 1 y 100. Luego, muestra por pantalla cuántos elementos
son mayores a 50.*/
Random random=new Random();
int contador=0;
int[] a_numeros=new int[10];
for(int i=0;i<a_numeros.Length;i++)
{
    a_numeros[i]=random.Next(1,101);
}
for(int i=0;i<a_numeros.Length;i++)
{
    Console.WriteLine($"numero ({i+1}):{a_numeros[i]}");
}
for(int i=0;i<a_numeros.Length;i++)
{
    if(a_numeros[i]>50)
    {
        contador++;
    }
}
Console.WriteLine($"hay {contador} mayores a 50");