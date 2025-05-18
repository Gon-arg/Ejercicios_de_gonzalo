int[] a_numeros;
int numero_indivual;
int numero_indivual2;
int numero2;
bool numero_valido;
int numero;
int max;
int min;
int contador=0;
int posicion_1=0;
int posicion_2=0;
do
{
    Console.WriteLine("ingrese un numero mayor a 0:");
    numero_valido=int.TryParse(Console.ReadLine(),out numero);
}while(!(numero_valido && numero>0));
Console.WriteLine($"el numero es {numero}");
numero2=numero;
while(numero>0)
{
    numero_indivual=numero%10;
    numero=numero/10;
    contador++;
}
a_numeros=new int[contador];
for(int i=0;i<a_numeros.Length;i++)
{
        numero_indivual2=numero2%10;
        a_numeros[i]=numero_indivual2;
        numero2=numero2/10;
}
max=a_numeros[0];
min=a_numeros[0];
for(int i=0;i<a_numeros.Length;i++)
{
    if(a_numeros[i]>max)
    {
        max=a_numeros[i];
        posicion_1=i;
    }
    else if(a_numeros[i]<min)
    {
        min=a_numeros[i];
        posicion_2=i;
    }
}
Console.WriteLine($"el mayor digito es {max} en el indice {posicion_2+1}");
Console.WriteLine($"el menor digito es {min} en el indice {posicion_1+1}");

