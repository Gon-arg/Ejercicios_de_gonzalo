/* Pedir al usuario un número y descomponerlo en dígitos. Mostrar cada dígito por separado
y luego mostrar la suma de todos los dígitos.*/
int num;
bool Es_numerovalido;
do
{
Console.WriteLine("Ingrese un número a descomponer:");
Es_numerovalido=int.TryParse(Console.ReadLine() ,out num);
}while(!Es_numerovalido);
if(num<0)
{
    num=-1*num;
}
int suma = 0;
do
{
    int digito = num % 10;
    suma = suma + digito;
    num = num / 10;
}
while (num != 0);
Console.WriteLine("La suma de los dígitos es: " + suma);
