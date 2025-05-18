/*Hacer un programa en C# que permita el ingreso de 10 numeros enteros en un
arreglo, y luego verifique si hay duplicados, si existen valores duplicados debe
mostrar por pantalla el siguiente mensaje: “El arreglo tiene valores duplicados”.*/
int[] a_numero=new int[10];
bool numero_valido;
bool hayDuplicados=false;
for(int i=0;i<a_numero.Length;i++)
do
{
    Console.WriteLine($"ingrese el numero {i+1}:");
    numero_valido=int.TryParse(Console.ReadLine(), out a_numero[i]);
}while(!numero_valido);
for(int i=0;i<a_numero.Length;i++)
{
    Console.WriteLine($"numero:{a_numero[i]}");
}
for (int i = 0; i < a_numero.Length; i++)
{
    for (int j = i + 1; j < a_numero.Length; j++)
    {
        if (a_numero[i] == a_numero[j])
        {
            hayDuplicados = true;
        }
    }
}
if(hayDuplicados)
{
    Console.WriteLine("El arreglo tiene valores duplicados");
}
