/*Crea un método llamado DescomponerNumero que reciba como parámetro un
numero de dos dígitos, y retorne en parámetros por referencia las unidades y
decenas del numero.
Utiliza parámetros de salida (out) para devolver las unidades y decenas del numeroEn el programa principal, solicita al usuario que ingrese un número de dos digitos,
llama al método DescomponerNumero y luego mostrá los resultados*/
using System;
class Program
{
    static void DescomponerNumero(int numero, out int decenas, out int unidades)
    {
        decenas = numero / 10;
        unidades = numero % 10;
    }

    static void Main()
    {
        Console.Write("Ingrese un número de dos dígitos: ");
        int valor_original = int.Parse(Console.ReadLine()!);

        int decenas, unidades;
        DescomponerNumero(valor_original, out decenas, out unidades);

        Console.WriteLine($"Decenas: {decenas}");
        Console.WriteLine($"Unidades: {unidades}");
    }
}