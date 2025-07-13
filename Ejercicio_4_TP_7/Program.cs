/*4. Crea un programa que permita gestionar los empleados de una empresa. 
Para ello crea
un struct que tenga los siguientes 
campos: int legajo, string nombre, string sector, double
salario. El menú del programa debe ofrecer las siguientes opciones:
a. Cargar empleados en un arreglo (preguntar cuántos empleados cargará).
b. Mostrar la lista completa de empleados.
c. Informar cuál es el empleado con mayor salario.
d. Buscar empleados de un determinado sector.*/
using System;

class Program
{
    public struct Empleado_Empresa
    {
        public int legajo;
        public string nombre;
        public string sector;
        public double salario;
    }

    static void Menu()
    {
        Console.WriteLine("elija alguna de estas opciones:");
        Console.WriteLine("1- Cargar empleados");
        Console.WriteLine("2- Mostrar la lista completa de empleados");
        Console.WriteLine("3- cuál es el empleado con mayor salario");
        Console.WriteLine("4- Buscar empleados de un determinado sector");
        Console.WriteLine("0- Salir");
    }

    static int Pedir_Entero_Positivo(string mensaje)
    {
        int resultado;
        do
        {
            Console.Write(mensaje);
        } while (!int.TryParse(Console.ReadLine(), out resultado) || resultado < 1);
        return resultado;
    }

    static double Pedir_Double_Positivo(string mensaje)
    {
        double resultado;
do
{
    Console.Write(mensaje);
} while (!double.TryParse(Console.ReadLine(), out resultado) || resultado < 1);
return resultado;
}

    static void Cargar_Empleados(ref Empleado_Empresa[] empleados,ref int tamaño_Arreglo)
    {
        empleados = new Empleado_Empresa[tamaño_Arreglo];
        for (int i = 0; i<empleados.Length; i++)
        {
            empleados[i].legajo = Pedir_Entero_Positivo($"ingrese el numero de legajo del empleado({i+1}):");
            Console.WriteLine($"ingrese el nombre del empleado({i+1}):");
            empleados[i].nombre = Console.ReadLine()!;
            Console.WriteLine($"ingrese el sector del empleado({i+1}):");
            empleados[i].sector = Console.ReadLine()!;
            empleados[i].salario = Pedir_Double_Positivo($"ingrese el salario del empleado({i+1}):");
        }
    }

    static void Mostar_Empleados(Empleado_Empresa[] empleados)
    {
        for (int i = 0; i < empleados.Length; i++)
        {
            Console.WriteLine($"\t Legajo Empleado({i + 1}):{empleados[i].legajo}");
            Console.WriteLine($"\t Nombre Empleado({i + 1}):{empleados[i].nombre}");
            Console.WriteLine($"\t Sector Empleado({i + 1}):{empleados[i].sector}");
            Console.WriteLine($"\t Salario Empleado({i + 1}):{empleados[i].salario}");
            Console.WriteLine();
        }
    }

    static void Ordenar_Empleado_Por_Salario(Empleado_Empresa[] empleados)
    {
        for (int i = 0; i < empleados.Length-1; i++)
        {
            for (int j = 0; j < empleados.Length-i-1; j++)
            {
                if (empleados[j].salario > empleados[j + 1].salario)
                {
                    Empleado_Empresa aux = empleados[j];
                    empleados[j] = empleados[j + 1];
                    empleados[j + 1] = aux;
                }
            }
        }
    }

    static void Ordenar_Empleado_Por_Sector(Empleado_Empresa[] empleados)
    {
        for (int i = 0; i < empleados.Length-1; i++)
        {
            for (int j = 0; j < empleados.Length-i-1; j++)
            {
                if (string.Compare(empleados[j].sector,empleados[j+1].sector)>0)
                {
                    Empleado_Empresa aux = empleados[j];
                    empleados[j] = empleados[j + 1];
                    empleados[j + 1] = aux;
                }
            }
        }
    }
    static void Empleado_Con_Mayor_Sueldo(Empleado_Empresa[] empleados)
    {
    Ordenar_Empleado_Por_Salario(empleados); 

    Empleado_Empresa mayor = empleados[empleados.Length - 1]; 

    Console.WriteLine("El empleado con mayor salario es:");
    Console.WriteLine($"\tLegajo: {mayor.legajo}");
    Console.WriteLine($"\tNombre: {mayor.nombre}");
    Console.WriteLine($"\tSector: {mayor.sector}");
    Console.WriteLine($"\tSalario: {mayor.salario}");
    }

    static void Buscar_Empleado_Por_Sector(Empleado_Empresa[] empleados, string sector_a_buscar)
    {
        bool encontrado = false;
        for (int i = 0; i < empleados.Length; i++)
        {
            if (empleados[i].sector == sector_a_buscar)
            {
                Console.WriteLine($"\t Legajo Empleado:{empleados[i].legajo}");
                Console.WriteLine($"\t Nombre Empleado:{empleados[i].nombre}");
                Console.WriteLine($"\t Sector Empleado:{empleados[i].sector}");
                Console.WriteLine($"\t Salario Empleado:{empleados[i].salario}");
                encontrado = true;
            }
        }
        if(!encontrado)
            {
                Console.WriteLine("no se encontro ningun empleado en este sector");
                encontrado = false;
            }
}
    static void Main()
    {
        string opcion;
        int tamaño_Arreglo = 0;
        Empleado_Empresa[] a_empleados = new Empleado_Empresa[tamaño_Arreglo];
        do
        {
            Menu();
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":
                    int tamaño = Pedir_Entero_Positivo("ingrese tamaño del arreglo:");
                    Cargar_Empleados(ref a_empleados,ref tamaño);
                    break;
                case "2":Mostar_Empleados(a_empleados); break;
                case "3":Empleado_Con_Mayor_Sueldo(a_empleados); break;
                case "4":
                    Console.WriteLine("ingese el sector a buscar");
                    string sector_a_buscar = Console.ReadLine()!.ToLower();
                    Buscar_Empleado_Por_Sector(a_empleados,sector_a_buscar);
                    break;
                case "0":Console.WriteLine("saliendo..."); break;

            }
        } while (opcion != "0");
    }
}