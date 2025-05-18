/*Escribe un procedimiento en C# que genere un arreglo de 8 lugares y lo llene con
números aleatorios entre 1 y 100. Luego, crea otro arreglo del mismo tamaño y llena
este segundo arreglo con los valores del primero, pero en orden inverso. Finalmente,
muestra ambos arreglos en pantalla.*/
int[] arreglo=new int[8];
Random random=new Random();
for(int i=0;i<arreglo.Length;i++)
{
    arreglo[i]=random.Next(1,101);
}
for(int i=0;i<arreglo.Length;i++)
{
    
}
for(int i=arreglo.Length;i>arreglo.Length;i--)
{
    Console.WriteLine($"numero ({i+1})");
}