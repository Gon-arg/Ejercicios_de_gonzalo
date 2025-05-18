/*Crear un programa que le solicite al usuario 5 nombres. Luego pedirle al usuario un nombre a buscar, si el nombre existe en el arreglo mostrarle
un mensaje diciendo que existe y en qué posición se encuentra.*/
string[] aNombres = new string[5];
string nombreBuscado;
int posicion;
bool encontrado=false;

for (int i = 0; i < aNombres.Length; i++)
{
    Console.Write($"Ingrese el nombre {i + 1}: ");
    aNombres[i] = Console.ReadLine()!;
}

Console.Write("Ingrese el nombre a buscar: ");
nombreBuscado = Console.ReadLine()!;
posicion = 1;
for(int i=0;i<5;i++)
{
    if(nombreBuscado.ToLower()==aNombres[i].ToLower())
    {
        Console.WriteLine($"{nombreBuscado} esta en la posicion:{posicion=i+1}");
        encontrado=true;
    }
    
}
if(encontrado==false)
{
    Console.WriteLine("no se encontro ");
}
/*encontrado = false;
while (posicion < aNombres.Length && !encontrado)
{
    if (aNombres[posicion] == nombreBuscado)
    {
        encontrado = true;
        Console.WriteLine($"El nombre {nombreBuscado} se encuentra en la posición {posicion+1}.");
    }
    else
    {
        posicion++;
    }
}*/
