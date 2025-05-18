/*Pedir al usuario un número entero positivo que indique la altura de un rombo. Dibujarlo en
consola, alineada al centro, usando asteriscos (*). Dividir el problema en subproblemas. En
los casos de altura par, considerar el impar siguiente para obtener la figura adecuada.*/
Console.Write("Ingrese la altura del rombo: ");
int altura = Convert.ToInt32(Console.ReadLine());
// Asegurar altura impar
if (altura % 2 == 0)
    {
        altura++;
    }
int mitad = altura / 2 + 1;
        // Parte superior
        for (int i = 1; i <= mitad; i++)
        {
            for (int espacio = 1; espacio <= mitad - i; espacio++)
            {
                Console.Write(" ");
            }
            for (int c = 1; c <= (2 * i) - 1; c++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Parte inferior
        for (int i = mitad - 1; i >= 1; i--)
        {
            for (int espacio = 1; espacio <= mitad - i; espacio++)
            {
                Console.Write(" ");
            }
            for (int c = 1; c <= (2 * i) - 1; c++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

