/*Una persona registra sus gastos diarios durante 10 días en un arreglo de tipo
double. Desarrollar un programa que permita ingresar los 10 montos diarios, y
luego calcular y mostrar el gasto promedio diario.*/
double[] a_gastos;
a_gastos=new double[10];
double promedio,suma;
suma=0;
bool valido;
for(int i=0;i<a_gastos.Length;i++)
{
    do
    {
        Console.WriteLine($"ingrese el gasto numero:{i+1}");
        valido=double.TryParse(Console.ReadLine(),out a_gastos[i]);
    }while(!(valido && a_gastos[i]>0));
    suma+=a_gastos[i];
}
promedio=suma/a_gastos.Length;
Console.WriteLine($"el promedio es : {promedio}");
