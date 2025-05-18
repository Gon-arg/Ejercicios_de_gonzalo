/*Un profesor desea calcular la nota final de los alumnos y determinar si promocionaron la
materia, aprobaron el cursado o deben recursar. Para ello se tiene en cuenta el promedio
de aprobación de los parciales (si aprueban el recuperatorio se considera sólo esa nota).
Para promocionar la materia el promedio debe ser mayor o igual a 80 con ambos parciales
aprobados, para aprobar el cursado debe ser mayor o igual a 60 con ambos parciales
aprobados, y si alguno de los parciales queda desaprobado deben recursar.
Una vez determinada la situación del alumno se debe mostrar en pantalla el promedio y su
estado, y a continuación se debe permitir calcular otro promedio. El programa debe
preguntarle al usuario si “¿desea calcular el promedio de otro alumno?: si/no”. Si la
respuesta es “si” debe pedirle las notas para calcular su promedio y determinar su estado*/
string continuar;
do
{Console.WriteLine("inrese nota del primer parcial:");
int parcial1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("inrese nota del segundo parcial:");
int parcial2=Convert.ToInt32(Console.ReadLine());
if (parcial1<60)
{
    Console.Write("ingrese nota de recuperatorio");
    parcial1=Convert.ToInt32(Console.ReadLine());
}
else if(parcial1>=60)
{
    Console.WriteLine("ingrese parcial numero dos:");
    parcial2=Convert.ToInt32(Console.ReadLine());
}
else if (parcial2<=60)
{
    Console.Write("ingrese nota de recuperatorio");
    parcial2=Convert.ToInt32(Console.ReadLine());
}
else if(parcial1<60 || parcial2<60)
{
    Console.WriteLine("recursa");
    int promedio=parcial1+parcial2/2;
    if(promedio>=80)
    {
        Console.WriteLine("promociona");
    }
    else
    {
        Console.WriteLine("cursa");
    }
} 
Console.WriteLine(parcial1+parcial2/2);
Console.WriteLine("continuar si/no:");
continuar=Console.ReadLine()!;}while(continuar=="si");
