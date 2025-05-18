/*Hacer un programa en C# que permita ingresar una lista de nombres de invitados a
un evento. El programa debe permitir ingresar nombres hasta que se ingrese la
palabra “salir”. Luego mostrar por pantalla la cantidad de invitados y la lista
completa. El programa no debe preguntar cuántos nombres desea ingresar, sino que
debe comenzar con un arreglo de 10 lugares y manejar internamente la longitud del
arreglo a medida que se cargan los nombres, ampliándolo cuando sea necesario.
Cada vez que sea necesario redimensionar el arreglo se agregarán 10 posiciones. Al
momento de finalizar debe “eliminar” las posiciones sobrantes del arreglo si es que
hubieran quedado posiciones sin utilizar.*/
string[] a_personas=new string[10];
int cantidad=0;
string nombre;
string salir;
int contador=0;
do
{
    Console.WriteLine($"ingrese el nombre del invitado :");
    nombre=Console.ReadLine()!;
    if(cantidad==a_personas.Length)
    {
        string[] a_nuevo=new string[a_personas.Length+10];
        for(int i=0;i<a_personas.Length;i++)
        {
            a_nuevo[i]=a_personas[i];
        }
        a_personas=a_nuevo;
    }
    a_personas[cantidad]=nombre;
    cantidad++;
    Console.WriteLine("desea seguir,para salir ingrese (salir):");
    salir=Console.ReadLine()!;
}while(salir.ToLower()!="salir");
for(int i=0;i<a_personas.Length;i++)
{
    if(a_personas[i]!=null)
    {
        contador++;
    }
}
string[] Nuevo_Arreglo=new string[contador];
int indice=0;
for(int i=0;i<a_personas.Length;i++)
{
    if(a_personas[i]!=null)
    {
        Nuevo_Arreglo[indice]=a_personas[i];
        indice++;
    }
}
for(int i=0;i<Nuevo_Arreglo.Length;i++)
{
    Console.WriteLine($"invitado numero ({i+1}):{Nuevo_Arreglo[i]}");
}
