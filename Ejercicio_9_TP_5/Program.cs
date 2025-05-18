/*Hacer un programa en C# que permita leer 10 numeros enteros entre 1 y 5
(inclusive), y luego muestre por pantalla cuántas veces aparece cada número.*/
int[] a_numero=new int[10];
bool numero_valido;
int num_1=0;
int num_2=0;
int num_3=0;
int num_4=0;
int num_5=0;
for(int i=0;i<a_numero.Length;i++)
do
{
    Console.WriteLine($"ingrese el numero entero numero({i+1}) (entre el 1 y el 5):");
    numero_valido=int.TryParse(Console.ReadLine(), out a_numero[i]);
}while(!(numero_valido && a_numero[i]>=1 && a_numero[i]<=5));
for(int i=0;i<a_numero.Length;i++)
{
    Console.WriteLine($".{a_numero[i]}");
}
for (int i=0;i<a_numero.Length;i++)
{
    switch(a_numero[i])
    {
        case 1:
        num_1++;
        break;

        case 2:
        num_2++;
        break;

        case 3:
        num_3++;
        break;

        case 4:
        num_4++;
        break;

        case 5:
        num_5++;
        break;
    }
}
Console.WriteLine($"el numero 1 aparece:{num_1}");
Console.WriteLine($"el numero 2 aparece:{num_2}");
Console.WriteLine($"el numero 3 aparece:{num_3}");
Console.WriteLine($"el numero 4 aparece:{num_4}");
Console.WriteLine($"el numero 5 aparece:{num_5}");