// See https://aka.ms/new-console-template for more information
int numero;
bool numero_valido;
do
{
    Console.WriteLine("ingrese un numero entero positivo:");
    numero_valido=int.TryParse(Console.ReadLine(),out numero);
}while(!numero_valido || numero<1);
for(int renglon=1;renglon<=numero;renglon++)
{
    for(int pos=1;pos<=renglon;pos++)
    {
        Console.Write(pos);
    }
    Console.WriteLine();
}