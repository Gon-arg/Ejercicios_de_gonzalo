/*Hacer un programa en C#, que ayude a una empresa a incrementar los salarios de
los trabajadores de la siguiente manera:
● De 0 a $900.000 aumentan un 15%
● De $900.001 a $1.350.000 aumentan un 10%
● De $1.350.001 a $1.750.000 aumentan un 7%
● Más de $1.750.000 aumentan un 5%
La entrada de datos finaliza cuando el usuario ingresa que no desea ingresar más
sueldos, para ello se le debe consultar si “¿desea ingresar otro sueldo para calcular
el nuevo valor? si/no: “.*/
string seguir;
double salario;
do
{
Console.WriteLine("ingrese el salario:");
salario=double.Parse(Console.ReadLine()!);
if(salario>=0 && salario<=900000)
{
    Console.WriteLine($"salario original {salario}");
    Console.WriteLine($"salario con aumento: {salario+(15.0/100)*salario}");
}
else if(salario>=900001 && salario<=1350000)
{
    Console.WriteLine($"salario original {salario}");
    Console.WriteLine($"salario con aumento: {salario+((10.0/100)*salario)}");
}
else if(salario>=1350001 && salario<=1750000)
{
    Console.WriteLine($"salario original {salario}");
    Console.WriteLine($"salario con aumento: {salario+((7.0/100)*salario)}");
}
else if(salario>175000)
{
    Console.WriteLine($"salario original {salario}");
    Console.WriteLine($"salario con aumento: {salario+((5.0/100)*salario)}");
}
else
{
    Console.WriteLine("algo fue mal ingresado");
}
Console.WriteLine("desea calcular otro salario?si/no:");
seguir=Console.ReadLine()!;
}while(seguir.ToLower()=="si");





