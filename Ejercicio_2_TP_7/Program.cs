/*Crea un programa de control para una casa inteligente que permita administrar las
distintas opciones que ofrece:
a. Ajustar la temperatura: el usuario debe poder ajustar la temperatura de la casa en
un rango aceptable (de 20.0°C a 25.5°C).
b. Controlar la iluminación interior: el usuario podrá regular la iluminación interior
desde 0 hasta 100, sólo con valores enteros.
c. Controlar la iluminación exterior: el usuario podrá encender/apagar las luces
externas modificando el estado de las luces externas.
d. Ver configuración actual: el usuario podrá observar el estado actual de la
configuración del sistema.
e. Salir*/
using System;

class Program
{
    public struct Casa_Inteligente
    {
        public float temperatura;
        public int iluminacion;
        public bool iluminacionExterior;
    }

    static void Menu()
    {
        Console.WriteLine("Ingrese alguna de estas opciones:");
        Console.WriteLine("1- Ajustar temperatura de la casa");
        Console.WriteLine("2- Ajustar iluminación interior");
        Console.WriteLine("3- Ajustar iluminación exterior");
        Console.WriteLine("4- Ver configuración actual");
        Console.WriteLine("0- Salir");
    }

    static void AjustarTemperatura(ref Casa_Inteligente casa)
    {
        float num;
        bool numValido;
        do
        {
            Console.WriteLine("Ingrese la temperatura de la casa en un rango aceptable (de 20.0°C a 25.5°C):");
            numValido = float.TryParse(Console.ReadLine(), out num);
        } while (!(numValido && num >= 20.0 && num <= 25.5));
        
        casa.temperatura = num;
    }

    static void AjustarIluminacionInterior(ref Casa_Inteligente casa)
    {
        int num;
        bool numValido;
        do
        {
            Console.WriteLine("Ingrese una iluminación entre (0-100):");
            numValido = int.TryParse(Console.ReadLine(), out num);
        } while (!(numValido && num >= 0 && num <= 100));
        
        casa.iluminacion = num;
    }

    static void AjustarIluminacionExterior(ref Casa_Inteligente casa)
    {
        string interruptor;
        Console.WriteLine("Ingrese si quiere apagar o prender la luz exterior (E: prender, A: apagar):");
        interruptor = Console.ReadLine()!.ToLower();
        
        if (interruptor == "e")
        {
            casa.iluminacionExterior = true;
        }
        else if (interruptor == "a")
        {
            casa.iluminacionExterior = false;
        }
        else
        {
            Console.WriteLine("Opción no válida. Intente de nuevo.");
        }
    }

    static void MostrarConfiguracionActual(Casa_Inteligente casa)
    {
        Console.WriteLine($"\tTemperatura actual: {casa.temperatura}°C");
        Console.WriteLine($"\tIluminación interior actual: {casa.iluminacion}%");
        Console.WriteLine($"\tIluminación exterior actual: {(casa.iluminacionExterior ? "Encendida" : "Apagada")}");
    }

    static void Main()
    {
        Casa_Inteligente casa = new Casa_Inteligente();
        string opcion;
        do
        {
            Menu();
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1": AjustarTemperatura(ref casa); break;
                case "2": AjustarIluminacionInterior(ref casa); break;
                case "3": AjustarIluminacionExterior(ref casa); break;
                case "4": MostrarConfiguracionActual(casa); break;
                case "0": Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción no válida. Intente de nuevo."); break;
            }

        } while (opcion != "0");
    }
}
