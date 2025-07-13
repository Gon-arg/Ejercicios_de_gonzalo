/*Crea una función llamada PedirNumeroEntero que se encargue de solicitar un
numero entero validando el ingreso, y luego lo devuelva como retorno de la
función.*/

class Program
{
    static void Main()
    {
        int numero = PedirNumeroEntero();
        Console.WriteLine("El número ingresado es: " + numero);
    }

    static int PedirNumeroEntero()
    {
        int numero;
        bool esValido;

        do
        {
            Console.Write("Por favor, ingresá un número entero: ");
            string entrada = Console.ReadLine()!;
            esValido = int.TryParse(entrada, out numero);

            if (!esValido)
            {
                Console.WriteLine("Entrada inválida. Intentá de nuevo.");
            }

        } while (!esValido);

        return numero;
    }
}
