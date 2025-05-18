//El mismo local tiene sólo 3 colores de remeras (rojas, verdes y azules), y
//observa que prácticamente no está vendiendo remeras verdes, así que
//pensó en implementar otra oferta: “si compra 3 remeras verdes, cada una queda a $5.000”. Y agrega: “si compra más de 3 remeras, pero incluye 3
//remeras verdes todas quedan a $5.000”.
Console.WriteLine("ingese cantidad de remeras de color azul");
int azul= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingese cantidad de remeras de color verde ");
int verde= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingese cantidad de remeras de color rojo");
int rojo= Convert.ToInt32(Console.ReadLine());
int total_remeras=azul+rojo+verde;
if (verde>=3)
{
    Console.WriteLine("precio total:"+total_remeras*5000);
}
else if(total_remeras<3)
{
    Console.WriteLine("precio total:"+(azul+rojo+verde)*9000);
}
else
{
    Console.WriteLine("precio total:"+total_remeras*7500);
}