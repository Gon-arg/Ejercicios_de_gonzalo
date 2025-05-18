/*Una clínica registró los tiempos de espera (en minutos) de 15 pacientes junto con
sus nombres.
a. Cargar en arreglos los 15 tiempos de espera y los nombres de los
pacientes.
b. Calcular y mostrar el tiempo promedio.
c. Informar cuántos pacientes esperaron más de 30 minutos.
d. Indicar cuál fue el tiempo de espera más largo y en qué posición del arreglo
se encuentra.*/
int[] a_tiempos=new int[15];
string[] a_nombres=new string[15];
bool numero_valido;
int suma=0;
int tiempo_mayor_30=0;
for(int i=0;i<a_tiempos.Length;i++)
{
do
{
    Console.WriteLine($"ingrese el tiempo numero({i+1})");
    numero_valido=int.TryParse(Console.ReadLine(),out a_tiempos[i]);
}while(!numero_valido || a_tiempos[i]<0);
    Console.WriteLine($"ingrese el nombre del paciente({i+1}):");
    a_nombres[i]=Console.ReadLine()!;
}
for(int i=0;i<a_tiempos.Length;i++)
{
suma+=a_tiempos[i];
}
int promedio=suma/a_tiempos.Length;
Console.WriteLine($"promedio:{promedio}");
for(int i=0;i<a_tiempos.Length;i++)
{
    if(a_tiempos[i]>30)
    {
        tiempo_mayor_30++;
    }
}
int max=a_tiempos[0];
int min=a_tiempos[0];
int indice_min=0;
int indice_max=0;
for(int i=0;i<a_tiempos.Length;i++)
{
    if(a_tiempos[i]>max)
    {
        max=a_tiempos[i];
        indice_max=i;
    }
    else if(a_tiempos[i]<min)
    {
        min=a_tiempos[i];
        indice_min=i;
    }
}
Console.WriteLine($"esperaron {tiempo_mayor_30} pacientes mas de 30 minutos");
Console.WriteLine($"el tiempo maximo fue {max} en el paciente {indice_max+1}");
Console.WriteLine($"el tiempo minimo fue {min} en el paciente {indice_min+1}");