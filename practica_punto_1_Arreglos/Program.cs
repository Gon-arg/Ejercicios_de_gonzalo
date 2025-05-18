/*Crear un programa que le pida al usuario 5 números enteros y los
almacene en un arreglo, y luego muestre la suma total de los números
ingresados*/
int numeros;
bool Numero_Valido;
int suma=0;
int[] a_Numeros=new int [5];
for (int i=0;i<5;i++)
{
    do
{
    Console.WriteLine($"ingrese numero para la posicion {i+1}:");
    Numero_Valido=int.TryParse(Console.ReadLine(), out numeros);
}while(!(Numero_Valido && numeros>0));
a_Numeros[i]=numeros;
}
for(int k=0;k<5;k++)
{
    suma+=a_Numeros[k];
}
Console.WriteLine($"el valor de la suma de los arreglos es:{suma}");