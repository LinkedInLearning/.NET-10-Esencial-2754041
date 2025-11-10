var p = new Persona();
try
{
    p.Nombre = null;

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Persona
{
    public string Nombre
    {
        get;
        set
        {
            field = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}