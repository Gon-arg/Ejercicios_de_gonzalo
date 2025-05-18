/*Descripción: Pide al usuario un entero m (> 0) para crear una matriz cuadrada de tamaño m × m. Luego recorre e imprime la matriz de forma que solo los elementos de las dos diagonales principales sean 1 y el resto 0.*/
bool numero_valido;
int numero;
do
{
    Console.Write($"ingrese el numero entero:");
    numero_valido=int.TryParse(Console.ReadLine(),out numero);
}while(!(numero_valido && numero>0));
for(int i=1;i<=numero;i++)
{
    for(int j=1;j<=numero;j++)
    {
        if(j==1 && i==1 || j==numero && i==1 || j==numero && i==numero || j==1 && i==numero)
        {
            Console.Write("1");
            Console.Write(" ");
        }
        else if(i>1 && i<numero)
        {
        if(j>1 && j<numero)
        {
            Console.Write("1");
            Console.Write(" ");
        }
        else
        {
            Console.Write("0");
            Console.Write(" ");
        }
        }
        else
        {
            Console.Write("0");
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}