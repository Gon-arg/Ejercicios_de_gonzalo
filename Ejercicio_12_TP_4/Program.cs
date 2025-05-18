/*Escriba un programa que, dada una oración ingresada calcule y muestre por
pantalla:
a. El número total de caracteres en la oración
b. La cantidad total de letras (sólo consonantes y vocales, sin espacios, puntos
ni signos de puntuación)
c. La cantidad de palabras separadas por uno o más espacios
En este ejercicio, para simplificar, asumiremos que los posibles caracteres de
entrada sólo son letras, espacios, dígitos, signos de puntuación, signos de
interrogación y de exclamación.
*/
string texto;
int letras=0;
int palabras=0;
Console.WriteLine("");
texto=Console.ReadLine()!;
int caracteres=texto.Length;
for(int i=0;i<texto.Length;i++)
{
    if(texto[i]!=' ')
    {
        letras++;
    }
    
}
for(int i=0;i<texto.Length;i++)
{
    if(texto[i]==' ')
    {
        palabras++;
    }
    
}
Console.WriteLine($" número total de caracteres en la oración:{caracteres}");
Console.WriteLine($"cantidad de letras:{letras}");
Console.WriteLine($"cantidad de palabras:{palabras+1}");