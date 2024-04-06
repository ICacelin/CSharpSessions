public class Human
{
    //Campos/Variable
    private readonly DateTime dateOfBirth;
    private string? name; //el ? significa que puede ser nullable
    private Nationalities nationality;
    //constructor: metodo especial con mismo nombre de la clase. Sirve para crear instancias de la misma clase
    public Human(DateTime dateOfBirth, Nationalities nationality, string name) : this(dateOfBirth, nationality) //llamando al segundo constructor (sobrecarga de metodos/constructor)
    {
        this.name = name;
    }

    public Human(DateTime dateOfBirth, Nationalities nationality)
    {
        this.dateOfBirth = dateOfBirth; //assigning the constructor parameter to the instance field
        this.nationality = nationality;
    }
    //Propiedades
    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
    } //devolver el valor del campo
    public int Age
    {
        get => (DateTime.Now - dateOfBirth).Days / 365;
    } //diferente sintaxis. Solo devuelve el valor
    public Nationalities Nationality => nationality; //sintaxis para solo devolver un valor

    public string? Name
    {
        get => name;
        //set => name = value; //asignar valor "value" y pasarlo a name
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
        }

    }

    //metodo de instancia
    /*public string Introduce()
    {
        return $"{Hello()}, mi nombre es {Name}, tengo {Age} años y soy {Nationality}";
    }*/
    public string Introduce() => $"{Hello()}, mi nombre es {Name}, tengo {Age} años y soy {Nationality}";
    public string IntroduceTo(Human human)
    {

        string greeting = $"{Hello()} {human.Name}, yo soy {this.name}, y ";
        // if (this.nationality == human.nationality)
        // {
        //     greeting += $"también soy {this.nationality}";
        // }
        // else
        // {
        //     greeting += $"soy {this.nationality}"; //+= para concatenar
        // }
        // return greeting;
        greeting += this.nationality == human.nationality 
        ?  $"también soy {this.nationality}" : $"soy {this.nationality}"; //operador ternario para reemplazar "if"
        return greeting;
    }

    //metodo de clase
    public static string Hello() //static nos dice que es miembro de clase y no de instancia
    {
        return "Hello";
    }
};