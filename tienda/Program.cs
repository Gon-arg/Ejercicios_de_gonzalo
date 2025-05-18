// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrrese el importe a pagar: ");
double importe=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("selecciones metodo de pago:");
int numero= Convert.ToInt32(Console.ReadLine());
switch(numero)
{
    case 1:
    Console.WriteLine("uno");
    break;
    case 2:
    Console.WriteLine("dos");
    break;
    case 3:
    Console.WriteLine("3");
    break;
}


