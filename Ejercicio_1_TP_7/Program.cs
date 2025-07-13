/*1. Crea un juego de adivinanza. El programa debe utilizar 
un arreglo de 20 lugares con
números cargados aleatoriamente entre 1 y 1000. 
Se deben utilizar los procedimientos
• cargarValoresAleatorios(int[] aNumeros) que asigne los valores aleatorios en el
arreglo.
• ordenarArregloAleatorios(int[] aNumeros) que ordena los elementos del arreglo de
forma creciente.
• int buscarNumero(int[] aNumeros, int valorObjetivo) que busca de forma eficiente
(búsqueda binaria) el valor objetivo en el arreglo y retorna su índice, si no lo
encuentra retorna -1.
El menú del juego debe tener opciones para:
a) comenzar una nueva partida (vuelve a cargar los valores aleatorios del arreglo)
b) ingresar un numero para ver si existe en el arreglo
c) salir
Funcionamiento esperado: cuando el usuario ingresa un numero para adivinar el
programa lo buscará en el arreglo, si el numero existe mostrará la posición donde se
encuentra, si no existe mostrará un mensaje. Luego volverá al menú.*/
class Program
{
    static void cargarValoresAleatorios(int[] aNumeros)
    {
        Random random = new Random();
        for (int i = 0; i < aNumeros.Length; i++)
        {
            aNumeros[i] = random.Next(1, 1001);
        }
    }

    static void ordenarArregloAleatorios(int[] aNumeros)
    {
        for (int i = 0; i < aNumeros.Length - 1; i++)
        {
            for (int j = 0; j < aNumeros.Length - i - 1; j++)
            {
                if (aNumeros[j] > aNumeros[j + 1])
                {
                    int aux = aNumeros[j];
                    aNumeros[j] = aNumeros[j + 1];
                    aNumeros[j + 1] = aux;
                }
            }
        }
    }

    static int buscarNumero(int[] aNumeros, int valorObjetivo)
    {
        int inicio = 0;
        int final = aNumeros.Length - 1;

        while (inicio <= final)
        {
            int medio = (inicio + final) / 2;
            {
                if (aNumeros[medio] == valorObjetivo)
                {
                    return medio;
                }
                else if (aNumeros[medio] < valorObjetivo)
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }
            }
        }
        return -1;
    }

    static void Menu()
    {
        Console.WriteLine("ingrese alguna de estas opciones");
        Console.WriteLine("1- Comenzar Nueva Partida");
        Console.WriteLine("2- Adivinar Numero");
        Console.WriteLine("0- Salir");
    }
    static void Main()
    {
        string opcion;
        int[] a_juego = new int[20];
        ordenarArregloAleatorios(a_juego);
        do
        {
            Menu();
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":
                    cargarValoresAleatorios(a_juego);
                    ordenarArregloAleatorios(a_juego);
                    break;
                case "2":
                    int num;
                    bool num_valido;
                    do
                    {
                        Console.WriteLine("ingrese numero a Encontrar:");
                        num_valido = int.TryParse(Console.ReadLine(), out num);
                    } while (!(num_valido && num > 0));
                    int numero_encontrado=buscarNumero(a_juego, num);
                    if (numero_encontrado != -1)
                    {
                        Console.WriteLine("el numero fue encontrado ganaste <3");
                    }
                    else
                    {
                        Console.WriteLine("el numero no fue encontrado Perdiste");
                    }
                    break;
                case "0":
                    Console.WriteLine("Saliendo...");
                    break;
            }
        } while (opcion != "0");
    }
}
