
Human pablito = new Human(new DateTime(1992, 2, 13), Nationalities.Aleman, "Pablo");
Human Dani = new Human(new DateTime(1994, 5, 25), Nationalities.Argentino, "Daniel");
Human Irving = new Human(new DateTime(1996, 8, 3), Nationalities.Brazileño, "Carlos");
Human Andrew = new Human(new DateTime(1996, 5, 15), Nationalities.Brazileño, "Andrew");
Human Edwin = new Human(new DateTime(1986, 5, 15), Nationalities.Aleman, "Edwin");

Irving.Name = "Irving";

//List<Human> humans = new List<Human>(); //Crear lista "de" Human. 
//humans.Add(pablito);
//humans.Add(Dani);
//humans.Add(Irving);
//humans.Add(Andrew);
//humans.Add(Edwin);

//collection initializer list
List<Human> humans2 = new List<Human>() {pablito, Dani, Irving, Andrew, Edwin};//definiendo tipo de dato en todo momento
var humans = new List<Human>() {pablito, Dani, Irving, Andrew, Edwin}; //var es una manera de que c# infiera el tipo de dato que este despues del igual


humans.RemoveAt(4); //removemos el elemento de la posición 4
foreach (Human human in humans) //iterar en la lista Humans por medio de la variable human
{
    Console.WriteLine(human.Introduce());
}

Console.WriteLine(Human.Hello());
Console.WriteLine(pablito.IntroduceTo(Irving));
Console.WriteLine(Andrew.IntroduceTo(Irving));
//humans.Remove(Edwin); //removemos un elemento de la lista conocido

System.Console.WriteLine(humans.Count); //propiedad count para saber cuantos elementos hay en la colección

//Arreglos
var array = new Human []{pablito, Dani};
Human [] array2 = {Irving, Andrew};
var array3 = new Human [1]; //indicamos la capacidad del array
array3[0] = Edwin;

Console.WriteLine(array[1].Introduce());
Andrew = null; // borra solo la referencia de la variable Andrew, no el objeto ni el array
//array2[1] = null; //borra la referencia del arreglo
System.Console.WriteLine(array2[1].Introduce());
System.Console.WriteLine(array2.Length);