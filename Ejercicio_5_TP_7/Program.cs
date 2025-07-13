/*Crea un programa que permita cargar una lista de alumnos junto con las notas del
parcial. Para ello se debe crear un struct que contenga los campos legajo, apellido,
nombre y nota. Pregunta al usuario cuántos alumnos va a cargar
y declara un arreglo con
la dimensión requerida. Luego de ingresados 
los datos se debe ordenar el listado por
apellido y mostrarlos en orden alfabético. 
Definí un procedimiento propio que reciba el
arreglo de alumnos y lo ordene por orden alfabético de los apellidos.*/
using System;
class Program
{
    public struct Alumnos_Notas
    {
        public int legajo;
        public string apellido;
        public string nombre;
        public int nota;
    }

    static int Verficar_Numero_Positivo(string mensaje)
    {
        int resultado;
        do
        {
            Console.Write(mensaje);
        } while (!int.TryParse(Console.ReadLine(), out resultado) || resultado < 1);
        return resultado;
    }
    static void Cargar_Alumnos(ref Alumnos_Notas[] notas, ref int tamaño)
    {
        tamaño = Verficar_Numero_Positivo("ingrese el tamaño del arreglo:");
        notas = new Alumnos_Notas[tamaño];
        for (int i = 0; i < notas.Length; i++)
        {
            notas[i].legajo = Verficar_Numero_Positivo($"ingrese el numero de legajo del alumno({i + 1}):");
            Console.WriteLine($"ingrese el nombre del alumno({i + 1})");
            notas[i].nombre = Console.ReadLine()!;
            Console.WriteLine($"ingrese el apellido del alumno({i + 1})");
            notas[i].apellido = Console.ReadLine()!;
            notas[i].nota = Verficar_Numero_Positivo($"ingrese la noa del alumno({i + 1}):");
        }
    }

    static void Ordenar_Por_Apellido(Alumnos_Notas[] notas)
    {
        for (int i = 0; i < notas.Length-1; i++)
        {
            for (int j = 0; j < notas.Length-i-1; j++)
            {
                if (string.Compare(notas[j].apellido, notas[j + 1].apellido) > 0)
                {
                    Alumnos_Notas aux = notas[j];
                    notas[j] = notas[j + 1];
                    notas[j + 1] = aux;
                }
            }
        }
    }

    static void Mostrar_Alumnos(Alumnos_Notas[] notas)
    {
        Ordenar_Por_Apellido(notas);
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"\t legajo Alumno:{notas[i].legajo}");
            Console.WriteLine($"\t Apellido Alumno:{notas[i].apellido}");
            Console.WriteLine($"\t Nombre Alumno:{notas[i].nombre}");
            Console.WriteLine($"\t Nota Alumno:{notas[i].nota}");
            Console.WriteLine();
        }
    }

    static void Menu()
    {
        Console.WriteLine("elija alguna de estas opciones:");
        Console.WriteLine("1- Cargar Alumnos");
        Console.WriteLine("2- Mostrar Alumnos");
}
    static void Main()
    {
        int tamaño = 0;
        string opcion;
        Alumnos_Notas[] a_notas = new Alumnos_Notas[tamaño];
        do
        {
            Menu();
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":Cargar_Alumnos(ref a_notas,ref tamaño); break;
                case "2":Mostrar_Alumnos(a_notas); break;
                case "0":Console.WriteLine("Saliendo.."); break;
            }
        } while (opcion != "0");
    }
}
