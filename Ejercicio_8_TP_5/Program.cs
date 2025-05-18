/*Hacer un programa en C# que permita cargar 10 números enteros en un arreglo, y
luego muestre la lista completa de valores y pida al usuario un valor a eliminar. Si el
valor a eliminar no existe en el arreglo debe mostrar un mensaje y volver a mostrar
los valores y pedir el numero a eliminar. Luego debe eliminar el valor del arreglo y
mostrar el arreglo final por pantalla.*/
int[] a_numeros=new int[10];
bool numero_valido;
bool encontrar=false;
int conteo=0;
int numero_a_eliminar=0;
for(int i=0;i<a_numeros.Length;i++)
            {
    do
    {
        Console.WriteLine($"ingrese el numero entero numero({i+1}):");
        numero_valido=int.TryParse(Console.ReadLine(),out a_numeros[i]);
    }while(!(numero_valido && a_numeros[i]>0));
            }

for(int i=0;i<a_numeros.Length;i++)
{
    Console.WriteLine($"posicion: {i+1},numero:{a_numeros[i]}");
}

do
        {
do
{
    Console.WriteLine("ingrese numero a eliminar:");
    numero_valido=int.TryParse(Console.ReadLine(),out numero_a_eliminar);
}while(!numero_valido);
for(int i=0;i<a_numeros.Length;i++)
{
    if(a_numeros[i]==numero_a_eliminar)
    {
        encontrar=true;
    }
}
        }while(!encontrar);


for(int i=0;i<a_numeros.Length;i++)
{
    if(a_numeros[i]!=numero_a_eliminar)
    {
        conteo++;
    }
}

int[] nuevo_arreglo=new int[conteo];
int indice_nuevo=0;

for(int i=0;i<a_numeros.Length;i++)
{
    if(a_numeros[i]!=numero_a_eliminar)
    {
        nuevo_arreglo[indice_nuevo]=a_numeros[i];
        indice_nuevo++;
    }
}

Console.WriteLine("nueva lista:");
for(int i=0;i<nuevo_arreglo.Length;i++)
{
    Console.WriteLine(nuevo_arreglo[i]);
}