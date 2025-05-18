// dada una distancia Dm expresada en metros, convertir en su equivalente en
//pies. Se conoce que 1 metro equivale a 39.37 pulgadas y que 12 pulgadas
//equivalen a 1 pie
Console.Write("ingrese la distanciaen metros:");
int metros=Convert.ToInt32(Console.ReadLine());
double pies = (metros*39.37)/12;
Console.Write($"{metros} equivale a {pies} pies");
