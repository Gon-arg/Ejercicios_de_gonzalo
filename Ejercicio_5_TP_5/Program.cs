int[] arreglos_1=new int[5];
int[] arreglos_2=new int[5];
int[] arreglos_3=new int[5];
Random aleatorio=new Random();
for(int i=0;i<arreglos_1.Length;i++)
{
    arreglos_1[i]=aleatorio.Next(4,58);
    Console.WriteLine($"arreglo1:{arreglos_1[i]}");
}
for(int i=0;i<arreglos_2.Length;i++)
{
    arreglos_2[i]=aleatorio.Next(3,58);
        Console.WriteLine($"arreglo 2:{arreglos_2[i]}");
}
for(int i=0;i<arreglos_3.Length;i++)
{
    arreglos_3[i]=arreglos_1[i]+arreglos_2[i];
        Console.WriteLine($"suma:{arreglos_3[i]}");
}

