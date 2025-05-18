/*Escriba un programa que dado un texto ingresado por el usuario cuente la cantidad
total de vocales que aparecen y la muestre por pantalla.*/
string texto;
int largo;
int contador=0;
Console.Write("ingrese el texto:");
texto=Console.ReadLine()!;
largo=texto.Length;
for(int i=0;i<largo;i++)
{
if(texto[i]=='a' || texto[i]=='e' || texto[i]=='i' || texto[i]=='o' || texto[i]=='u')
{
contador++;
}
}
Console.WriteLine($"{texto} tiene {contador} vocales:");