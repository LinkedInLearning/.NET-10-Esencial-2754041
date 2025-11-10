var app = new App();
var orden = new Orden();
app.AsignarPersona(orden, null);
Console.WriteLine("Proceso finalizado");
class App
{
    public void AsignarPersona(Orden orden, Persona persona)
    {
        orden?.Persona = persona;
    }
}

class Orden
{
    public Persona Persona { get; set; }
}

class Persona { }