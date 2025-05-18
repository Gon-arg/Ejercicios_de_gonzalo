/*Una empresa realiza una encuesta a 20 clientes sobre la calidad del servicio. Cada
cliente califica el servicio con un valor entre 1 y 5. Desarrollar un programa que
permita cargar las 20 calificaciones. Calcular la cantidad de votos recibidos en cada
nivel (1 a 5) y mostrar los resultados por pantalla.*/
int[] a_clientes;
a_clientes=new int[20];
bool numero_valido;
int nivel_1=0;
int nivel_2=0;
int nivel_3=0;
int nivel_4=0;
int nivel_5=0;
for(int i=0;i<20;i++)
{
    do
    {
        Console.WriteLine($"ingrese la calificacion numero ({i+1})");
        numero_valido=int.TryParse(Console.ReadLine(),out a_clientes[i]);
    }while(!(numero_valido && a_clientes[i]>=1 && a_clientes[i]<=5));
}
for(int i=0;i<20;i++)
{
    if(a_clientes[i]==1)
    {
        nivel_1++;
    }
    else if(a_clientes[i]==2)
    {
        nivel_2++;
    }
    else if(a_clientes[i]==3)
    {
        nivel_3++;
    }
    else if(a_clientes[i]==4)
    {
        nivel_4++;
    }
    else if(a_clientes[i]==5)
    {
        nivel_5++;
    }
}
Console.WriteLine($"{nivel_1} estan en nivel 1");
Console.WriteLine($"{nivel_2} estan en nivel 2");
Console.WriteLine($"{nivel_3} estan en nivel 3");
Console.WriteLine($"{nivel_4} estan en nivel 4");
Console.WriteLine($"{nivel_5} estan en nivel 5");