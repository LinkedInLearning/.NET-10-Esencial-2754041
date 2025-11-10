var p = new Persona(18, "Melissa");
Console.WriteLine(p);
p += 5;
Console.WriteLine(p);
p += 25;
Console.WriteLine(p);
class Persona
{
    public int Edad { get; set; }
    public string Nombre { get; set; }
    public Persona(int edad, string nombre)
    {
        Edad = edad;
        Nombre = nombre;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Edad}";
    }

    public void operator +=(int x)
    {
        Edad += x;
    }
}