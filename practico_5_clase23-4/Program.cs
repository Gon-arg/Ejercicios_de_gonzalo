/*Pedir al usuario un número entero positivo que indique la altura de una pirámide.
La pirámide deberá formarse con números, cada piso tendrá una secuencia
creciente y decreciente*/
/*ejemplo de como se veria si ingresamos el numero 4:
   1
  121
 12321
1234321*/
int numero;
bool numero_valido;
do
{
    Console.WriteLine("ingrese un numero entero positivo:");
    numero_valido=int.TryParse(Console.ReadLine(),out numero);
}while(!numero_valido || numero<1);
for(int renglon=1;renglon<=numero;renglon++)
{
    //agregamos los espacios para centrar los numeros
    for(int espacios=renglon;espacios<=numero-1;espacios++)
    {
        Console.Write(" ");
    }

    //incrementacion de numeros
    for(int pos=1;pos<=renglon;pos++)
    {
        Console.Write(pos);
    }

    //decremento de numeros
    for (int i=renglon-1;i>=1; i--)
    {
        Console.Write(i);
    }

    //Salto de Linea
    Console.WriteLine();
}
