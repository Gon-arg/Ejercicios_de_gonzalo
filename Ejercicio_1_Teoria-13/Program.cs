/*Crear un programa que permita al usuario cargar datos de los alumnos, el
programa le debe pedir:
● legajo
● nombre
● apellido
● estaActivo
Se pide:
Preguntar al usuario cuántos datos desea cargar y realizar la carga en un
arreglo. Una vez finalizada la carga ordenar el arreglo por el numero de legajo.
Mostrar por pantalla cuántos alumnos se encuentran activos.*/
class Program
{
    public struct Tipo_Alumno
    {
        public int legajo;
        public string nombre;
        public string apellido;
        public bool Esta_Activo;
    }

    static int Pedir_Numero(string mensaje)
    {
        int numero;
        bool Es_Valido;
        do
        {
            Console.WriteLine(mensaje);
            Es_Valido = int.TryParse(Console.ReadLine(), out numero);
        } while (!(Es_Valido && numero > 0));
        return numero;
    }

    static bool Esta_Activo(string mensaje)
    {
        string respuesta;
        do
        {
            Console.WriteLine(mensaje);
            respuesta = Console.ReadLine()!.ToLower(); 
        } while (respuesta != "v" && respuesta != "f");
        return respuesta == "v"; 
    }
    static void Ordenar_Arreglo(Tipo_Alumno[] a_alumnos)
    {
        for (int i = 0; i < a_alumnos.Length-1; i++)
        {
            for (int j = 0; j < a_alumnos.Length - i - 1; j++)
            {
                if (a_alumnos[j].legajo > a_alumnos[j + 1].legajo)
                {
                    Tipo_Alumno aux = a_alumnos[j];
                    a_alumnos[j] = a_alumnos[j + 1];
                    a_alumnos[j + 1] = aux;
                }
            }
        }
    }

    static void Mostrar_Alumnos(Tipo_Alumno[] a_alumnos)
    {
        Console.WriteLine("alumnos activos:");
        bool hayAlumnosActivos = false; 

        for (int i = 0; i < a_alumnos.Length; i++)
        {
            if (a_alumnos[i].Esta_Activo)
            {
                Console.WriteLine($"Legajo:   \t{a_alumnos[i].legajo}");
                Console.WriteLine($"nombre:   \t{a_alumnos[i].nombre}");
                Console.WriteLine($"apellido: \t{a_alumnos[i].apellido}");
                Console.WriteLine(); 
                hayAlumnosActivos = true; 
            }
        }

        if (!hayAlumnosActivos)
        {
            Console.WriteLine("No se encontraron alumnos activos.");
        }
    }

    static void Cargar_Arreglo(Tipo_Alumno[] a_alumnos)
    {
        Console.Clear();
        for (int i = 0; i < a_alumnos.Length; i++)
        {
            Console.WriteLine($"ingrese los datos del alumno({i + 1}):");
            Tipo_Alumno Nuevo_Alumno;
            Nuevo_Alumno.legajo = Pedir_Numero("ingrese el legajo:");
            Console.WriteLine("ingrese nombre:");
            Nuevo_Alumno.nombre = Console.ReadLine()!;
            Console.WriteLine("ingrese apellido:");
            Nuevo_Alumno.apellido = Console.ReadLine()!;
            Nuevo_Alumno.Esta_Activo = Esta_Activo("ingrese actividad del estudiante[V o F]:");
            a_alumnos[i] = Nuevo_Alumno;
            Console.Clear();
        }
        Ordenar_Arreglo(a_alumnos);
    }

    static void Main()
    {
        int tamaño = Pedir_Numero("ingrese la cantidad de alumnos:");
        Tipo_Alumno[] a_alumnos = new Tipo_Alumno[tamaño];
        Cargar_Arreglo(a_alumnos);
        Mostrar_Alumnos(a_alumnos);
    }
}
