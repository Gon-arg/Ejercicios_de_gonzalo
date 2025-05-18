/*Escribir un programa en C# que permita el ingreso de dos listas de valores enteros
positivos. Se debe preguntar cuántos valores se cargarán en cada lista, y luego se
cargarán los valores.
Una vez cargadas ambas listas de números, generar un tercer arreglo que
contenga la intersección de los dos arreglos ingresados (es decir, los elementos
que están en ambas listas).*/
Console.WriteLine("Ingrese el tamaño del primer arreglo:");
int tamaño1 = int.Parse(Console.ReadLine()!);
int[] arreglo_1 = new int[tamaño1];

Console.WriteLine("Ingrese el tamaño del segundo arreglo:");
int tamaño2 = int.Parse(Console.ReadLine()!);
int[] arreglo_2 = new int[tamaño2];

// Cargar el primer arreglo
for (int i = 0; i < tamaño1; i++)
{
    Console.Write($"Ingrese el valor ({i + 1}) del primer arreglo: ");
    arreglo_1[i] = int.Parse(Console.ReadLine()!);
}

// Cargar el segundo arreglo
for (int i = 0; i < tamaño2; i++)
{
    Console.Write($"Ingrese el valor ({i + 1}) del segundo arreglo: ");
    arreglo_2[i] = int.Parse(Console.ReadLine()!);
}

// Arreglo para la intersección (suponemos que puede haber hasta tamaño1 elementos)
int[] interseccion = new int[tamaño1];
int cantidadInterseccion = 0;

// Buscar intersección
for (int i = 0; i < tamaño1; i++)
{
    for (int j = 0; j < tamaño2; j++)
    {
        if (arreglo_1[i] == arreglo_2[j])
        {
            // Verificar que no esté repetido
            bool repetido = false;
            for (int k = 0; k < cantidadInterseccion; k++)
            {
                if (interseccion[k] == arreglo_1[i])
                {
                    repetido = true;
                }
            }

            if (repetido == false)
            {
                interseccion[cantidadInterseccion] = arreglo_1[i];
                cantidadInterseccion++;
            }
        }
    }
}

// Mostrar resultado
Console.WriteLine("Elementos en la intersección:");
if (cantidadInterseccion == 0)
{
    Console.WriteLine("No hay elementos en común.");
}
else
{
    for (int i = 0; i < cantidadInterseccion; i++)
    {
        Console.WriteLine(interseccion[i]);
    }
}
