/*Se desea realizar una aplicación que solicite al usuario un carácter y un número
natural N, y que la aplicación muestre en pantalla dicho carácter repetido N veces
consecutivas.
Ej: Ingrese un caracter: +
Ingrese la cantidad de repeticiones: 15
+++++++++++++++*/
string caracter;
int numero;
Console.Write("ingrese el caracter que quiere mostrar:");
caracter=Console.ReadLine()!;
Console.Write("ingrese cuantas veces lo quiere mostrar:");
numero=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<numero;i++)
{
    Console.Write($"{caracter}");
}


