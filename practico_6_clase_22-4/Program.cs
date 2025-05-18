/*Un taller nos contactó para que lo ayudemos a determinar los envases de aceite que
necesita comprar cada semana. Quieren calcular cuántos tambores de 200 litros, envases
de 4 litros y envases de 1 litro deben encargar para cumplir con los cambios de aceite de
sus clientes en la semana siguiente. El usuario debe ingresar los litros requeridos por cada
trabajo hasta que no quiera cargar más trabajos, el programa debe preguntar "¿Desea
ingresar otra cantidad de litros? si/no: ".
a) Desarrolle el programa suponiendo que el taller desea comprar la cantidad total de
litros requeridos buscando la combinación más económica: del total de litros
calcular cuántos tambores de 200 litros necesita, luego cuántos envases de 4 litros
necesita y finalmente cuantos de 1 litro.
Al finalizar deberá mostrar las cantidades de cada envase que necesitan encargar.
b) Desarrolle otro programa suponiendo que el taller desea comprar la combinación
requerida para cada trabajo de forma independiente, entonces para cada cantidad
de litros ingresados deberán contarse los envases requeridos, y acumularlos para
mostrar al final cuántos envases de cada capacidad necesita encargar.
Al finalizar deberá mostrar las cantidades de cada envase que necesitan encargar.
En ambos casos, el análisis con los litros sería:
● si necesita de 1 a 3 litros: se cuentan envases por litro
● si necesita 4 litros se cuenta un envase de 4lts.
● si necesita más de 4 litros y menos de 200, se cuenta la combinación de
envases de 4 litros (la mayor cantidad posible) y de 1 litro para completar.
● 200 litros: tambor de 200.
● más de 200 litros: combinación de tambor de 200 (mayor cantidad posible),
sobre lo que reste envases de 4 (mayor cantidad posible luego de calcular
los tambores) y finalmente completar con envases de 1 litro*/
//ejercicio b)
/*string seguir;
bool numero_valido;
int litros;
do
{
    do{
Console.WriteLine("ingrese la cantidad de litros:");
numero_valido=int.TryParse(Console.ReadLine(), out  litros);
    }while(!numero_valido||litros<0);
int litros_200=litros/200;
litros=litros-(litros_200*200);
int litros_4=litros/4;
litros=litros-(litros_4*4);
int litros_1=litros;
Console.WriteLine($"cantidad de barriles de 200 litros:{litros_200} ");
Console.WriteLine($"cantidad de botella de 4 litros: {litros_4}");
Console.WriteLine($"cantidad de botella de 1 litro: {litros_1}");
Console.WriteLine("desea seguir? si/no:");
seguir=Console.ReadLine()!;
}while( seguir.ToLower()=="si");*/
//inciso a)
string salir;
int litros;
bool numero_valido;
int trabajos=0;
        do
{
    do {Console.WriteLine("ingrese la cantidad de litros:");
numero_valido=int.TryParse(Console.ReadLine(), out  litros);
    }while(!(numero_valido && litros>0));
trabajos=trabajos+litros;
Console.WriteLine("desea seguir? si/no:");
salir=Console.ReadLine()!;
        }while(salir.ToLower()=="si");

int trabajos_200=trabajos/200;
trabajos=trabajos-(trabajos_200*200);
int trabajos_4=trabajos/4;
trabajos=trabajos-(trabajos_4*4);
int trabajos_1=trabajos;
Console.WriteLine($"cantidad de barriles de 200 trabajos:{trabajos_200} ");
Console.WriteLine($"cantidad de botella de 4 trabajos: {trabajos_4}");
Console.WriteLine($"cantidad de botella de 1 litro: {trabajos_1}");
