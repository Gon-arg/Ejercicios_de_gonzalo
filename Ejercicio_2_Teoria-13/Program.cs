/*Refactorizando el código anterior, crear un programa que permita gestionar los datos de los alumnos. Cada alumno tiene su legajo, apellido, nombre y puede
estar activo/inactivo.
El programa debe mostrar un menú que permita:
● Cargar una cantidad determinada de alumnos
● Mostrar el listado cargado
● Ordenar por numero de legajo (ascendente)
● Ordenar por apellido (ascendente)
● Mostrar cuantos alumnos están activos
● Editar los datos de un alumno (identificado por su numero de legajo)*/ 
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

    static void Ordenar_Por_Apellido(Tipo_Alumno[] a_alumnos)
    {
        for (int i = 0; i < a_alumnos.Length-1; i++)
        {
            for (int j = 0; j < a_alumnos.Length - i - 1; j++)
            {
                if (string.Compare(a_alumnos[j].apellido,a_alumnos[j+1].apellido)>0)
                {
                    Tipo_Alumno aux = a_alumnos[j];
                    a_alumnos[j] = a_alumnos[j + 1];
                    a_alumnos[j + 1] = aux;
                }
            }
        }
    }

    static void Editar_Datos_De_Alumno(Tipo_Alumno[] a_Alumnos)
    {
        int numero;
        bool Es_Valido;
        do
        {
            Console.WriteLine("ingrese el numero de legajo");
            Es_Valido = int.TryParse(Console.ReadLine(), out numero);
        } while (!(Es_Valido && numero > 0));
        int posicion = Busqueda_Binaria(a_Alumnos, numero);
        if (posicion != -1)
        {
            Console.WriteLine("ingrese el nombre del alumno:");
            string nombre = Console.ReadLine()!;
            a_Alumnos[posicion].nombre = nombre;
            Console.WriteLine("ingrese el apellido del alumno:");
            string apellido = Console.ReadLine()!;
            a_Alumnos[posicion].apellido = apellido;
            int num;
            bool num_valido;
            do
            {
                Console.WriteLine("ingrese el legajo del alumno:");
                num_valido = int.TryParse(Console.ReadLine(), out num);
            } while (!(num_valido && num > 0));
            a_Alumnos[posicion].legajo = num;
            a_Alumnos[posicion].Esta_Activo=Esta_Activo("ingrese actividad del estudiante[V o F]:");
        }
        else
        {
            Console.WriteLine($"el numero de legajo {numero} no se encuentra");
        }
    }

    static int Busqueda_Binaria(Tipo_Alumno[] a_Alumnos, int legajo_a_buscar)
    {
        int inicio = 0;
        int final = a_Alumnos.Length;
        int medio = -1;
        legajo_a_buscar = -1;
        while (inicio <= final && legajo_a_buscar == -1)
        {
            medio = (inicio + final) / 2;
            if (a_Alumnos[medio].legajo == legajo_a_buscar)
            {
                legajo_a_buscar = medio;
            }
            else if (a_Alumnos[medio].legajo < legajo_a_buscar)
            {
                inicio = medio + 1;
            }
            else
            {
                final = medio - 1;
            }
        }
        return legajo_a_buscar;
        
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
            Nuevo_Alumno.legajo = Pedir_Numero("ingrese el legajo a buscar:");
            Console.WriteLine("ingrese nombre:");
            Nuevo_Alumno.nombre = Console.ReadLine()!;
            Console.WriteLine("ingrese apellido:");
            Nuevo_Alumno.apellido = Console.ReadLine()!;
            Nuevo_Alumno.Esta_Activo = Esta_Activo("ingrese actividad del estudiante[V o F]:");
            a_alumnos[i] = Nuevo_Alumno;
            Console.Clear();
        }
        Ordenar_Arreglo(a_alumnos);
        Ordenar_Por_Apellido(a_alumnos);
    }

    static void Main()
    {
        int tamaño = Pedir_Numero("ingrese la cantidad de alumnos:");
        Tipo_Alumno[] a_alumnos = new Tipo_Alumno[tamaño];
        Cargar_Arreglo(a_alumnos);
        Mostrar_Alumnos(a_alumnos);
        
    }
}

