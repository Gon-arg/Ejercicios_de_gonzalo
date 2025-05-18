/*Pedir un número del 1 al 10 y mostrar su tabla de multiplicar del 1 al 10. Luego
preguntar si quiere ver otra tabla (si/no).*/
string seguir;
int numero;
bool numero_valido;
        do
{
    do {Console.WriteLine("ingrese el numero a multiplicar:");
numero_valido=int.TryParse(Console.ReadLine(), out  numero);
    }while(!(numero_valido && numero>0));
    for(int i=1;i<=10;i++)
    {
        Console.WriteLine($"{numero} X {i} = {numero*i}");
    }
    Console.WriteLine("desea ingresar otro numero a multiplicar?:");
    seguir=Console.ReadLine()!;
}while(seguir.ToLower()=="si");
