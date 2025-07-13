/*Crear un programa en C# para cargar una lista de alumnos junto con las notas del
parcial. Puede utilizar el struct declarado en el punto anterior. 
Preguntar al usuario
cuántos alumnos va a cargar y declarar un arreglo con la dimensión requerida.
Mantener
el arreglo ordenado en todo momento, a medida que el usuario va cargando los datos.*/ 
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
        int cantidad = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            Alumnos_Notas nuevo;
            nuevo.legajo = Verficar_Numero_Positivo($"ingrese el numero de legajo del alumno({i + 1}):");
            Console.WriteLine($"ingrese el nombre del alumno({i + 1})");
            nuevo.nombre = Console.ReadLine()!;
            Console.WriteLine($"ingrese el apellido del alumno({i + 1})");
            nuevo.apellido = Console.ReadLine()!;
            nuevo.nota = Verficar_Numero_Positivo($"ingrese la noa del alumno({i + 1}):");

            int j = cantidad - 1;
            while (j >= 0 && string.Compare(notas[j].apellido, nuevo.apellido) > 0)
        {
            notas[j + 1] = notas[j];
            j--;
        }
        notas[j + 1] = nuevo;
        cantidad++;
        }
        
        
    }
    static void Mostrar_Alumnos(Alumnos_Notas[] notas)
    {
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

