/*Te encargaron desarrollar un sistema para registrar a los atletas que participarán en una maratón local. El sistema debe ser capaz de gestionar la inscripción de hasta 100 atletas.

Cada atleta tiene los siguientes campos:

NumeroInscripcion (entero)
NombreCompleto (cadena de texto)
Edad (entero)
Club
La organización del torneo te pidió implementar un menú con las siguientes opciones:

Funcionalidades requeridas:

Inscribir Atleta: Solicita al usuario los datos del nuevo atleta 
(número de inscripción, nombre, edad, club que representa). 
El sistema debe validar que no se supere la capacidad del arreglo 
y que el número de inscripción no esté ya en uso. 
Cada vez que se agrega un atleta se debe ordenar el arreglo.
Consultar Atleta por Número: Pide al usuario un número de inscripción 
y, si existe, muestra todos los datos del atleta. 
De lo contrario, informa que no se encontró.
Salir: Finaliza la ejecución del programa.*/
using System;

class Program
{
    public struct Tipo_Atleta
    {
        public int NumeroInscripcion;
        public string NombreCompleto;
        public int edad;
        public string Club;
    }
    static void MostrarMenu()
    {
        Console.WriteLine("Bienvenido al sistema de gestión de atletas");
        Console.WriteLine("1. Inscribir atleta");
        Console.WriteLine("2. Buscar atleta por número de inscripción");
        Console.WriteLine("3. Modificar nombre de atleta");
        Console.WriteLine("4. Mostrar todos los atletas");
        Console.WriteLine("0. Salir");
        Console.Write("opción: ");
    }

    static void Cargar_Atletas(Tipo_Atleta[] atletas)
    {

        for (int j = 0; j < atletas.Length; j++)
        {
            if (Numero_Repetido(atletas) != -1)
            {
                atletas[j].NumeroInscripcion = PedirNumeroEnteroPositivo($"ingrese el numero de inscripcion del atleta({j + 1}):");
                Console.WriteLine($"ingrese el nombre completo del atleta ({j + 1}):");
                atletas[j].NombreCompleto = Console.ReadLine()!;
                atletas[j].edad = PedirNumeroEnteroPositivo($"ingrese la edad del atleta({j + 1}):");
                Console.WriteLine($"ingrese el nombre del club ({j + 1}):");
                atletas[j].Club = Console.ReadLine()!.ToLower();
            }
            else
            {
                Console.WriteLine("el codigo ya existe");
            }
                }
    }

    static void Mostrar_Todos_Los_Atletas(Tipo_Atleta[] atletas)
    {
        for (int i = 0; i < atletas.Length; i++)
        {
            Console.WriteLine($"\t Nombre Atleta:{atletas[i].NombreCompleto}");
            Console.WriteLine($"\t Numero de inscripcion Atleta:{atletas[i].NumeroInscripcion}");
            Console.WriteLine($"\t Edad Atleta:{atletas[i].edad}");
            Console.WriteLine($"\t Club Atleta:{atletas[i].Club}");
            Console.WriteLine();
        }
    }
    static int Busqueda_Binaria(Tipo_Atleta[] atletas, int numero_a_buscar)
    {
        int inicio = 0;
        int final = atletas.Length-1;
        while (inicio <= final)
        {
            int medio = (inicio + final) / 2;
            if (atletas[medio].NumeroInscripcion == numero_a_buscar)
            {
                return medio;
            }
            else if (atletas[medio].NumeroInscripcion < numero_a_buscar)
            {
                inicio = medio + 1;
            }
            else
            {
                final = medio - 1;
            }
        }
        return -1;
    }

    static void Modificar_Nombre_Atleta(ref Tipo_Atleta[] atleta)
    {
        int numero = PedirNumeroEnteroPositivo("ingrese el numero de inscripcion a buscar:");
        int indice = Busqueda_Binaria(atleta, numero);
        if (indice != -1)
        {
            Console.WriteLine("modificar nombre:");
            atleta[indice].NombreCompleto = Console.ReadLine()!;
        }
    }

    static int Numero_Repetido(Tipo_Atleta[] atletas)
    {
        for (int i = 0; i < atletas.Length; i++)
        {
            for (int j = 0; j < atletas.Length; j++)
            {
                if (atletas[i].NumeroInscripcion == atletas[j].NumeroInscripcion)
                {
                    return -1;
                }
            }
        }
        return 1;
    }
    static int PedirNumeroEnteroPositivo(string mensaje)
    {
        int numero;
        bool esValido;
        do
        {
            Console.Write(mensaje);
            esValido = int.TryParse(Console.ReadLine(), out numero);
            if (!esValido)
            {
                Console.WriteLine("La entrada no es válida, debe ingresar un número entero positivo.");
            }
            else if (numero <= 0)
            {
                Console.WriteLine("La entrada no es válida, el número debe ser mayor que cero.");
            }
        } while (!esValido || numero <= 0);
        return numero;
    }

    static void Main()
    {
        Tipo_Atleta[] atletas = new Tipo_Atleta[2];
        string opcion;
        do
        {
            MostrarMenu();
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":Cargar_Atletas(atletas); break;
                case "2":
                    int num = PedirNumeroEnteroPositivo("ingrese el numero a buscar:");
                    int resultado=Busqueda_Binaria(atletas,num);
                    if (resultado != -1)
                    {
                        Console.WriteLine("atleta encontrado");
                        Console.WriteLine($"nombre:{atletas[resultado].NombreCompleto}");
                        Console.WriteLine($"edad:{atletas[resultado].edad}");
                        Console.WriteLine($"Club:{atletas[resultado].Club}");
                    }
                    else
                    {
                        Console.WriteLine("atleta no encontrado");
                    }
                    break;
                case "3":
                    int numero = PedirNumeroEnteroPositivo("ingrese el numero del atleta:");
                    Modificar_Nombre_Atleta( ref atletas);
                    break;
                case "4":Mostrar_Todos_Los_Atletas(atletas); break;
                case "0":Console.WriteLine("Saliendo..."); break;
            }
        } while (opcion != "0");
    }
}
