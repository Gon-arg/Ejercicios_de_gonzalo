/*Hacer un programa en C# que pida un texto al usuario, y que retorne la cadena de
texto invertida.*/
string texto = "";
string textoInvertido = "";
int largo;
Console.WriteLine("Ingrese texto:");
texto = Console.ReadLine()?? "";
if (texto.Length == 0)
{
    Console.WriteLine(" No se ingresó texto. Fin del programa.");
    return;
}
largo = texto.Length;
for (int lugar = largo - 1; lugar >= 0; lugar--)
{
    textoInvertido += texto[lugar];
}
Console.WriteLine($"El texto invertido es: {textoInvertido}");
