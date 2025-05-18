// Para confeccionar la factura, el vendedor debe ingresar la forma de pago y monto de
//la compra. Si corresponde, se aplica un descuento según el siguiente criterio:
//Si el pago es en efectivo, se descuenta un 20%.
//Si el pago es con tarjeta, se realiza un descuento del 10% sólo si el monto supera los
//$25.000.
//En cualquier otro caso no se realiza descuento.
Console.WriteLine("ingrese la forma de pago E:efectivo T:tarjeta O:otros:");
string pago=Console.ReadLine()!.ToLower();
Console.WriteLine("ingrese monto a pagar:");
double monto=Convert.ToDouble(Console.ReadLine());
if (pago=="e")
{
    Console.WriteLine("{0,-20}{1,7:F2}","forma de pago E:efectivo T:tarjeta O:otros:",$"{pago}");
    Console.WriteLine("{0,-30}{1,21:f2}","monto de la compra:",$"{monto}");
    Console.WriteLine("{0,-30}{1,23}","descuento:",$"{(20.0/100)*monto,15:f2}");
    Console.WriteLine("{0,-30}{1,23}","Monto total a pagar:",$"{monto-((20.0/100)*monto)}");
}
else if(pago=="t"&& monto>25000)
{
    Console.WriteLine($"forma de pago E:efectivo T:tarjeta O:otros:{pago}");
    Console.WriteLine($"monto de la compra:{monto}");
    Console.WriteLine($"descuento{(10.0/100)*monto}");
    Console.WriteLine($"Monto total a pagar:{monto-((10.0/100)*monto)}");
}
else
{
    Console.WriteLine($"forma de pago E:efectivo T:tarjeta O:otros:{pago}");
    Console.WriteLine($"monto de la compra:{monto}");
    Console.WriteLine($"descuento:0");
    Console.WriteLine($"Monto total a pagar:{monto}");
}