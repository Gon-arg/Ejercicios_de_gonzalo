/*Crear un programa que pida al usuario 10 números enteros y los
almacene en un arreglo. Luego mostrar los valores ingresados en el
orden inverso.*/
int numeros;
bool Numero_Valido;
int[] a_Numeros=new int [10];
for (int i=0;i<10;i++)
{
    do
{
    Console.WriteLine($"ingrese numero para la posicion {i+1}:");
    Numero_Valido=int.TryParse(Console.ReadLine(), out numeros);
}while(!(Numero_Valido && numeros>0));
a_Numeros[i]=numeros;
}
for(int k=9;k>=0;k--)
{
    Console.WriteLine($"{a_Numeros[k]}");
}
