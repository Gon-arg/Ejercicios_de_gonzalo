// See https://aka.ms/new-console-template for more information
int longitud;
int[,] a_matriz;
bool numero_valido;
do{
Console.WriteLine("igrese la longitud dela dimensiones:");
numero_valido=int.TryParse(Console.ReadLine(),out longitud);
}while(!(numero_valido && longitud>0));
a_matriz=new int[longitud,longitud];
for(int fila=0;fila<longitud;fila++)
{
    for(int columna=0;columna<longitud;columna++)
    {
        if(fila==columna)
        {
            a_matriz[fila,columna]=columna+1;
        }
        else
        {
            a_matriz[fila,columna]=0;
        }
    }
}
for(int fila=0;fila<longitud;fila++)
{
    for(int columna=0;columna<longitud;columna++)
    {
        Console.Write(a_matriz[fila,columna]+" ");
    }
    Console.WriteLine();
}
