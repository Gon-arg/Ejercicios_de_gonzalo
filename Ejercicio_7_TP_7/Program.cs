/*Define un struct para alumno con legajo, nombre y nota (0 a 10).
Carga una lista de alumnos y luego muestra:
Cuántos alumnos aprobaron (nota >= 6)
Promedio general
Alumno con mejor nota*/
using System;

class Program
{
    public struct Tipo_Alumos
    {
        public int legajo;
        public string nombre;
        public int nota;
    }

    static void Cargar_Alumnos(Tipo_Alumos[] alumnos)
    {
        for (int i = 0; i < alumnos.Length; i++)
        {
            alumnos[i].legajo = Verificar_Num_Positivo($"ingrese el numero de legajo de alumno({i + 1})");
            Console.WriteLine($"ingrese el nombre del alumno({i + 1})");
            alumnos[i].nombre = Console.ReadLine()!;
            alumnos[i].nota = Verificar_Num_Positivo($"ingrese la nota del alumno({i+1})");
        }
    }

    static void Alumnos_Aprobados(Tipo_Alumos[] alumnos)
    {
        int contador = 0;
        for (int i = 0; i < alumnos.Length; i++)
        {
            if (alumnos[i].nota >= 6)
            {
                contador++;
            }
        }
        Console.WriteLine($"hay {contador} alumnos aprobados");
    }

    static void Promedio_General(Tipo_Alumos[] alumnos)
    {
        int suma = 0;
        for (int i = 0; i < alumnos.Length; i++)
        {
            suma += alumnos[i].nota;
        }
        int Promedio = suma / alumnos.Length;
    }

    static void Mejor_Nota(Tipo_Alumos[] alumnos)
    {
        int max = alumnos[0].nota;
        for (int i = 0; i < alumnos.Length; i++)
        {
            if (alumnos[i].nota > max)
            {
                max = alumnos[i].nota;
            }
        }
        Console.WriteLine($"la mejor nota fue {max}");
    }
    static int Verificar_Num_Positivo(string mensaje)
    {
        int resultado;
        do
        {
            Console.WriteLine(mensaje);
        } while (!(int.TryParse(Console.ReadLine(), out resultado) && resultado >= 0));
        return resultado;
    }
    static void Main()
    {
        Tipo_Alumos[] a_alumnos = new Tipo_Alumos[10];
    }
}
