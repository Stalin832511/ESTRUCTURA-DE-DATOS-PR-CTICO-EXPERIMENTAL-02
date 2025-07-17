public class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public override string ToString()
    {
        return Nombre;
    }
}
