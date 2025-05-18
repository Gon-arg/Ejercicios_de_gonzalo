int notas;
int max;
int min;
int posicion_1=0;
int posicion_2=0;
bool numero_valido;
do
{
Console.WriteLine("ingrese cuantas notas quiere ingresar:");
numero_valido=int.TryParse(Console.ReadLine(),out notas);
}while(!(numero_valido && notas>=0));
int[] a_notas=new int[notas];
for(int i=0;i<a_notas.Length;i++)
{
    do
    {
        Console.WriteLine($"ingrese la nota numero:({i+1})");
        numero_valido=int.TryParse(Console.ReadLine(),out a_notas[i] );
    }while(!(numero_valido && a_notas[i]>=0 && a_notas[i]<=10));

}
max=a_notas[0];
min=a_notas[0];
for(int i=0;i<a_notas.Length;i++)
{
    if(a_notas[i]>max)
    {
        max=a_notas[i];
        posicion_1=i;
    }
    else if(a_notas[i]<min)
    {
        min=a_notas[i];
        posicion_2=i;
    }
}
Console.WriteLine($"la nota mas alta fue {max} en la posicion: {posicion_1+1}");
Console.WriteLine($"la nota mas alta fue {min} en la posicion: {posicion_2+1}");



