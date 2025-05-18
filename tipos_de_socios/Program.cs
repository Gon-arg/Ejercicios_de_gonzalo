// una obra social tiene tres clases de socios. Los socios tipo ‘A’ abonan una
//cuota mayor pero tiene un 50% de descuento en todos los tipos de
//tratamientos odontológicos. Los socios tipo ‘B’ abonan una cuota moderada y
//tienen un 35% de descuento para los mismos tratamientos que los socios del
//tipo A. Los socios que menos aportan, los de tipo ‘C’, no reciben descuentos
//sobre dichos tratamientos. Solicite una letra (carácter) que representa la clase
//de un socio, y luego un valor real que represente el costo del tratamiento
//(previo al descuento) y determine el importe en efectivo a pagar por dicho
//socio.
Console.WriteLine("Ingrese clase del socio:");
string clase = Console.ReadLine();
Console.WriteLine("Ingrese costo del tratamiento:");
double tratamiento = Convert.ToDouble(Console.ReadLine());
if (clase == "a" || clase == "A")
{
    double descuento = (50.0 / 100) * tratamiento;
    double precioFinal = tratamiento - descuento;
Console.WriteLine($"Costo original: {tratamiento}\nDescuento: {descuento}\nPrecio con descuento: {precioFinal}");
}
else if (clase == "b" || clase == "B")
{
    double descuento = (25.0 / 100) * tratamiento;
    double precioFinal = tratamiento - descuento;
Console.WriteLine($"Costo original: {tratamiento}\nDescuento: {descuento}\nPrecio con descuento: {precioFinal}");
}
else if (clase == "c" || clase == "C")
{
Console.WriteLine($"Costo original: {tratamiento}");
}
else
{
    Console.WriteLine("algo esta mal en lo que se ingreso");
}