/*Escriba un programa que permita el ingreso de números enteros positivos,
finalizando el ingreso con 0, y luego indique si la secuencia estaba ordenada de
menor a mayor.*/
int numero;
int suma=0;
int contador=0;
bool secuencia=true;
int comparacion=0;
bool numero_valido;
do{
do
{
Console.WriteLine("ingrese un numero entero positivo fnalice el programa con (0):");
numero_valido=int.TryParse(Console.ReadLine(),out numero);
}while(!numero_valido);
if(comparacion<numero)
{
    comparacion=numero;
}
else if(comparacion>numero)
{
    secuencia=false;
}
suma+=numero;
contador++;
}while(!(numero==0));

