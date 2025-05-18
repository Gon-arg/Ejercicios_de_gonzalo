int cantidad;
bool esta_creciente;
double[] a_precios;
bool numero_valido;
do
{
Console.WriteLine("ingrese cuantos precios quiere cambiar");
numero_valido=int.TryParse(Console.ReadLine(),out cantidad );
}while(!(numero_valido && cantidad>0));
a_precios=new double[cantidad];
for(int i=0;i<a_precios.Length;i++)
{
    do
    {
        Console.WriteLine($"ingrse el numero {i+1}");
        numero_valido=double.TryParse(Console.ReadLine(),out a_precios[i]);
    }while(!(numero_valido && a_precios[i]>0));
}
esta_creciente=true;
for(int i=0;i<cantidad-1;i++)
{
    if(a_precios[i]>a_precios[i+1])
    {
        esta_creciente=false;
    }
}
if(esta_creciente)
{
    Console.WriteLine("esta en orden creciente");
}
else
{
    Console.WriteLine("no esta en orden creciente");

}