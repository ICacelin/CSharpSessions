//List<string> lista = new() { "holi", "muchas", "cositas", "lista", "pablito" };
using System.Runtime.CompilerServices;

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

System.Console.WriteLine();

//collection and objects initialyzers 
var humans = new List<Human>() {
    new Human {Name = "Andrew", DateOfBirth = new DateTime (1992,8,23), Nationality = Nationalities.Mexican},
    new Human {Name = "Jorge", DateOfBirth = new DateTime (1962,2,13), Nationality = Nationalities.Colombian},
    new Human {Name = "Cesar", DateOfBirth = new DateTime (2003,11,7), Nationality = Nationalities.Bazilian },
    new Human {Name = "Adriana", DateOfBirth = new DateTime (1945,1,30), Nationality = Nationalities.French},
    new Human {Name = "Luis", DateOfBirth = new DateTime (2010,4,26), Nationality = Nationalities.Canadian},
    new Human {Name = "Andres", DateOfBirth = new DateTime (1985,7,12), Nationality = Nationalities.Japanese},
    new Human {Name = "Pedro", DateOfBirth = new DateTime (2016,7,12), Nationality = Nationalities.Japanese},
    new Human {Name = "                    " , DateOfBirth = new DateTime (1985,7,12), Nationality = Nationalities.Japanese}
};

foreach (Human human in humans)
{
    System.Console.Write(human.Name);
    // if (human.Age < 11)
    // {
    //     System.Console.WriteLine(" Is a boy");
    // }
    // else if (human.Age < 18)
    // {
    //     System.Console.WriteLine(" Is a minor");
    // }
    // else if (human.Age < 60)
    // {
    //     System.Console.WriteLine(" Is an adult");
    // }
    // else
    // {
    //     System.Console.WriteLine(" Is and elder");
    // }

    // switch (human.Age) //SWITCH STATEMENT   
    // {
    //     case < 11:
    //         System.Console.WriteLine(" Is a boy");
    //         break;
    //     case < 18:
    //         System.Console.WriteLine(" Is a minor");
    //         break;
    //     case < 60:
    //         System.Console.WriteLine(" Is an adult");
    //         break;
    //     default:
    //         System.Console.WriteLine(" Is and elder");
    //         break;
    // }

    //Switch expression, works with lambadas
    var message = human.Age switch
    {
        < 11 => " Is a boy",
        < 18 => " Is a minor",
        < 60 => " Is an adult",
        _ => " Is an elder"
    };

    System.Console.WriteLine(message);
}