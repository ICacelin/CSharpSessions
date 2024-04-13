public class Human
{
    private string? name;
    public string? Name
    {
        // get => name is null ? "no name" : name;
        get => name ?? "no name" ; // Si la expresion a la izquierda de  ?? evalua algo que sea null entonces devuelve "no name", si no devuelve "name"
        set { if (!string.IsNullOrWhiteSpace(value)) //value es una variable especial que guarda el valor de entrada de la propiedad
        {
            name = value.Trim(); //Trim es un metodo que viene de instancias tipo string que sirve para quitar espacios al principio y al final
        }}
    }
    public DateTime DateOfBirth { get; init; } //Solo durante la inicializacion del objeto se 
                                               //puede escribir en esta propiedad
    public int Age => (DateTime.Today - DateOfBirth).Days / 365; //operaciones entre fechas regresan un tupo Timespany es inmutable
    public required Nationalities Nationality { get; init; }  //null! advierte que se declara como nulo cuando la clase no acepta los nulos
    public List<string> Nationalities { get; } = new ();
}
