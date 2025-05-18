/*Dado un arreglo ordenado con una longitud máxima determinada en MaxPos y la
cantidad realmente ocupada en UltPos, hacer algoritmos para agregar y para borrar
un elemento en el arreglo. Ambos procesos deben mantener el arreglo ordenado.
Escriba el programa en C# que pregunte al usuario el tamaño del arreglo, y luego
muestre un menú que permita seleccionar qué hacer con el arreglo: agregar
elementos, borrar elementos, mostrar los elementos del arreglo y salir. 
El menú debe repetirse hasta que el usuario elija la opción para salir*/
bool numero_valido;
int tamaño;
int valor;
string accion;
do
{
    Console.WriteLine("ingrese el tamaño del arreglo:");
    numero_valido=int.TryParse(Console.ReadLine(),out tamaño);
}while(!(numero_valido && tamaño>0));
int[] arreglo=new int[tamaño];
Console.WriteLine("ingrese que quiere hacer:");
Console.WriteLine($"(agregar elementos=a):\n(borrar elementos=b):\n(mostrar los elementos del arreglo y salir=c):");
accion=Console.ReadLine()!;
if(accion=="a")
{
    
    do
    {
        Console.WriteLine("ingrese valor a cargar:");
        numero_valido=int.TryParse(Console.ReadLine(),out valor);
    }while(!(numero_valido && valor>0));
    
}

