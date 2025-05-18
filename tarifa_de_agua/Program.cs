// See https://aka.ms/new-console-template for more information
double consumo,tarifa_final=0;
string respuesta;
bool es_valido;
do
{
    do
    {
        Console.WriteLine("ingrese el consumo de agua en litros:");
        es_valido=double.TryParse(Console.ReadLine(),out consumo);
    }while(!es_valido);
    if (consumo>=0 && consumo<=20)
    {
        tarifa_final=3000+consumo*3.20;
    }
    else if (consumo>=21 && consumo<=40)
    {
        tarifa_final=3000+consumo*5.30;
    }
    else if(consumo>=41 && consumo<=60)
    {
        tarifa_final=5000+consumo*6.40;
    }
    else if(consumo>60)
    {
        tarifa_final=6000+consumo*7.50;
    }
    else
    {
        Console.Write("ingrese un numero positivo:");
    }
    Console.WriteLine($"Su tarifa es : {tarifa_final}");
    Console.WriteLine("¿Desea ingresar otro consumo para calcular la tarifa? si/no: ");
    respuesta=Console.ReadLine()!;
}while(respuesta.ToLower()=="si");