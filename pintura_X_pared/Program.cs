/*Escriba un algoritmo y un programa para calcular la cantidad de latas de pintura
necesaria para pintar una habitación. Se sabe que las puertas y ventanas tienen una
medida estándar y son todas iguales. Las puertas son de 0,75 x 2,00 mts (ancho x
alto) y las ventanas son de 1,20 x 1,50 mts.
La pintura se vende en latas de un litro y cada litro rinde 12 m2.
Los datos que pueden variar son: el ancho, largo y alto de la habitación, y la cantidad
de cada tipo de aberturas en la habitación. */
Console.WriteLine("ingrese ancho de la habitacion ");
double ancho=double.Parse(Console.ReadLine()!);
Console.WriteLine("ingrese largo de la habitacion");
double largo=double.Parse(Console.ReadLine()!);
Console.WriteLine("ingrese alto de la habitacion");
double alto=double.Parse(Console.ReadLine()!);
Console.WriteLine("ingrese cantidad de puertas ");
int puertas=int.Parse(Console.ReadLine()!);
Console.WriteLine("ingrese ingrese cantidad de ventanas ");
int ventanas=int.Parse(Console.ReadLine()!);
double superficie_total=2*(largo*alto)+2*(ancho*alto);
double ventana_y_puerta=puertas*(0.75 * 2.00)+ventanas*(1.20*1.50);
double metros_cuadrados=superficie_total-ventana_y_puerta;
double cantidad_pintura=metros_cuadrados/12;
Console.Write($"latas de pintura:{(int)Math.Ceiling(cantidad_pintura)}");
