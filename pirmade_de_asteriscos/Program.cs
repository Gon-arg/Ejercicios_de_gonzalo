// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("ingrese altura de la piramide:");
int altura=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("*");
for(int i=1;i<=altura;i++)
{
    string asterisco="**";
    suma="*"
    string suma="*"+asterisco;
    Console.WriteLine(suma);
}*/
int altura;
Console.Write("ingrese altura:");
altura=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= altura; i++)
        {
            for (int j = i; j <= altura - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i) - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();}