var p = new Persona(1, "Rodrigo");
//p.Id = 1;
//p.Nombre = "Rodrigo";
Console.WriteLine(p);

public partial class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public partial Persona(int id, string nombre);
}

public partial class Persona
{
    public partial Persona(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
    public override string ToString()
    {
        return $"{Id} {Nombre}";
    }
}