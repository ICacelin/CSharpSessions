//List<string> lista = new() { "holi", "muchas", "cositas", "lista", "pablito" };
var lista2 = new List<string>() { "holi", "muchas", "cositas", "lista", "pablito", "fut", "Solera", "swapna", "Bono", "Fondo", "HPEL", "Autosource" };

//looping (Do, While, For, Foreach)
Console.WriteLine("foreach");
foreach (string buffer in lista2)
{
    Console.WriteLine(buffer);
}

Console.WriteLine("for");
for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine(lista2[i]);
}

Console.WriteLine("while");
int j = 0;
while (j < lista2.Count)
{
    Console.WriteLine(lista2[j++]);
    //j++;
}
Console.WriteLine("Do");
int z = 0;
do
{
    Console.WriteLine(lista2[z++]);
} while (z < lista2.Count);

//jumping en bucles

for (int k = 0; k < lista2.Count; k++)
{
    if (k % 2 == 0)
    {
        continue;//salta iteración
    }
    if (k == 5)
    {
        break;//detiene la iteración
    }
    Console.WriteLine("posición {0}: {1}", k, lista2[k]); //formato de texto
}