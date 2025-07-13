/*Una concesionaria de autos necesita un programa para administrar los vehículos que
tiene a la venta, y nos encargaron desarrollar un programa en C# para administrar los
vehículos. Cada vehículo tiene una patente, marca, modelo, año, y una cantidad de
kilómetros.
Crea un struct tipo_Vehiculo para agrupar los campos de cada vehículo. Creá un arreglo
con 10 posiciones inicialmente y gestioná el acceso a los datos de forma de no acceder
posiciones sin datos. Cuando se requiera más espacio deberás redimensionar el arreglo
añadiendo 10 lugares más.
El menú del programa debe ofrecer opciones para:
a. Cargar vehículos
b. Mostrar todos los vehículos.
c. Indicar cuál tiene más kilómetros recorridos.
d. Contar cuántos vehículos son del año 2020 en adelante.
e. Calcular el promedio de kilometraje de los vehículos con más de 5 años*/
using System;

class Program
{
    public struct tipo_Vehiculo
    {
        public string patente;
        public string marca;
        public string modelo;
        public int año;
        public int kilometraje;
    }

    static void Menu()
    {
        Console.WriteLine("elja alguna de estas opciones:");
        Console.WriteLine("1- Cargar vehiculos");
        Console.WriteLine("2- Mostrar todos los vehículos");
        Console.WriteLine("3- Indicar cuál vehiculo tiene más kilómetros recorridos");
        Console.WriteLine("4- Contar cuántos vehículos son del año 2020 en adelante");
        Console.WriteLine("5- Calcular el promedio de kilometraje de los vehículos con más de 5 años");
        Console.WriteLine("0- Salir");
    }
    static void Cargar_Vehiculo(ref tipo_Vehiculo[] vehiculo, ref int Ultima_posicion)
    {
        if (Ultima_posicion == vehiculo.Length - 1)
        {
            Redimensionar_Arreglo(ref vehiculo);
        }
        tipo_Vehiculo Nuevo = new tipo_Vehiculo();
        Console.WriteLine("ingrese la patente del vehiculo:");
        Nuevo.patente = Console.ReadLine()!;
        Console.WriteLine("ingrese la marca del auto:");
        Nuevo.marca = Console.ReadLine()!;
        Console.WriteLine("ingrese modelo del auto:");
        Nuevo.modelo = Console.ReadLine()!;
        Nuevo.año = verificar_numero_positivo("ingrese el año del auto:");
        Nuevo.kilometraje = verificar_numero_positivo("ingrese el kilometraje del auto:");
    }
    static int verificar_numero_positivo(string mensaje)
    {
        int resultado;
        do
        {
            Console.Write(mensaje);
        } while (!(int.TryParse(Console.ReadLine(), out resultado) && resultado >= 0));
        return resultado;
    }
    static void Redimensionar_Arreglo(ref tipo_Vehiculo[] vehiculo)
    {
        tipo_Vehiculo[] aux = new tipo_Vehiculo[vehiculo.Length + 10];
        for (int i = 0; i < vehiculo.Length; i++)
        {
            aux[i] = vehiculo[i];
        }
        vehiculo = aux;
    }

    static void Mostrar_Autos(tipo_Vehiculo[] vehiculo, int Ultima_posicion)
    {
        for (int i = 0; i < Ultima_posicion; i++)
        {
            Console.WriteLine($"\t Patente del auto:{vehiculo[i].patente}");
            Console.WriteLine($"\t Marca del auto:{vehiculo[i].marca}");
            Console.WriteLine($"\t Modelo del auto:{vehiculo[i].modelo}");
            Console.WriteLine($"\t Año del auto:{vehiculo[i].año}");
            Console.WriteLine($"\t Kilometraje del auto:{vehiculo[i].kilometraje}");
            Console.ReadLine();
        }
    }

    static void Buscar_Auto_Mayor_Kilometraje(tipo_Vehiculo[] autos, int ultima_posicion)
    {
        if (ultima_posicion < 0)
        {
            Console.WriteLine("No hay autos cargados.");
            return;
        }

        int mayor_km = autos[0].kilometraje;
        int pos_mayor = 0;

        for (int i = 1; i <= ultima_posicion; i++)
        {
            if (autos[i].kilometraje > mayor_km)
            {
                mayor_km = autos[i].kilometraje;
                pos_mayor = i;
            }
        }

        Console.WriteLine("Auto con mayor kilometraje:");
        Console.WriteLine($"Patente: {autos[pos_mayor].patente}");
        Console.WriteLine($"Kilometraje: {autos[pos_mayor].kilometraje}");
    }
    static void Contar_Autos_Son_Del_Año_2020_en_adelante(tipo_Vehiculo[] vehiculos, int ultima_posicion)
    {
        int contador = 0;
        for (int i = 0; i <= ultima_posicion; i++)
        {
            if (vehiculos[i].año >= 2020)
            {
                contador++;
            }
        }
        Console.WriteLine($"hay {contador} autos que son del 2020 en adelante");
    }

    static void Promedio_Autos(tipo_Vehiculo[] vehiculos, int ultima_posicion)
    {
        int suma = 0;
        int contador = 0;
        for (int i = 0; i <= ultima_posicion; i++)
        {
            if (2025 - vehiculos[i].año > 5)
            {
                suma += vehiculos[i].kilometraje;
                contador++;
            }
        }
        int promedio = suma / contador;
        Console.WriteLine($"el promedio de kilometraje de los vehículos con más de 5 años es:{promedio}");
    }

    static void Main()
    {
        tipo_Vehiculo[] vehiculos = new tipo_Vehiculo[10];
        int ultima_posicion = -1;
        string opcion;

        do
        {
            Menu();
            opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    Cargar_Vehiculo(ref vehiculos, ref ultima_posicion);
                    ultima_posicion++;
                    break;
                case "2":
                    Mostrar_Autos(vehiculos, ultima_posicion);
                    break;
                case "3":
                    Buscar_Auto_Mayor_Kilometraje(vehiculos, ultima_posicion);
                    break;
                case "4":
                    Contar_Autos_Son_Del_Año_2020_en_adelante(vehiculos, ultima_posicion);
                    break;
                case "5":
                    Promedio_Autos(vehiculos, ultima_posicion);
                    break;
                case "0":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != "0");
    }
}