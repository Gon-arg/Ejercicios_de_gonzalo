//Un local de ropa vende las remeras a distinto precio según la cantidad
//elegida, si se compran 3 unidades o menos cada remera sale $9.000, en
//cambio, si se compran más de 3 unidades cada remera queda a $7.500.
Console.WriteLine("ingrese cantidad de remeras:");
int remera= Convert.ToInt32(Console.ReadLine());
if (remera>0)   
        {
if (remera<=3)
{
    Console.WriteLine("remera sale: "+remera*9000);
}
else
{
    Console.WriteLine("remera sale"+remera*75000);
}
}else
{
    Console.WriteLine("el numero es negativo");
        }
