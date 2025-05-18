// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese ancho:");
int ancho=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese largo:");
int largo=Convert.ToInt32(Console.ReadLine());
string a="";
for(int i=0;i<=largo-1;i++)
{
    a=a+" *";
}
Console.WriteLine(a);
for(int i=1;i<=largo;i++)
{
    Console.WriteLine(a);
}