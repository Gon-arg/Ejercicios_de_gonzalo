Random random = new Random();
int[] a_numeros = new int[10];
int buscar_numero = 0;

for (int i = 0; i < a_numeros.Length; i++)
{
    a_numeros[i] = random.Next(1, 21); 
}
Console.WriteLine("Números generados:");
for (int i = 0; i < a_numeros.Length; i++)
{
    Console.WriteLine($"Posición {i+1}: {a_numeros[i]}");
}
bool numeroValido;
while (buscar_numero >= 0)
{
    Console.WriteLine("Ingrese número a buscar (finalice con un número negativo):");
    numeroValido = int.TryParse(Console.ReadLine(), out buscar_numero);
    if (!numeroValido)
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
    }
    if (buscar_numero < 0)
    {
        Console.WriteLine("Número negativo ingresado. Finalizando el programa...");
    }

    bool encontrado = false;
    int posicion = 0;

    for (int i = 0; i < a_numeros.Length; i++)
    {
        if (a_numeros[i] == buscar_numero)
        {
            encontrado = true;
            posicion = i;
        }
    }
    if (encontrado)
    {
        Console.WriteLine($"El número {buscar_numero} se encontró en la posición {posicion+1}.");
    }
    else
    {
        Console.WriteLine($"El número {buscar_numero} no se encontró en el arreglo.");
    }
}