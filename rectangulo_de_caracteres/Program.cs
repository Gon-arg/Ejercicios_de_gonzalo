/*Escriba un programa que permita al usuario ingresar las medidas de 2 lados de un
rectángulo, y que luego mediante la impresión repetida de un caracter (ej: *) lo dibuje
en la pantalla. Por ejemplo, si el usuario ingresa ancho = 5, largo = 9, se mostraría el
siguiente rectángulo en pantalla:*/
Console.WriteLine("ingrese ancho:");
int ancho=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese largo:");
int largo=Convert.ToInt32(Console.ReadLine());
string a="";
for(int i=0;i<=largo-1;i++)
{
    a=a+" *";
}
for(int i=1;i<=ancho;i++)
{
    Console.WriteLine(a);
}