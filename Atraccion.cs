using System.Collections.Generic;

public class Atraccion
{
    private Queue<Persona> cola = new Queue<Persona>();
    private Persona?[] asientos;
    private int indiceAsiento = 0;

    public Atraccion(int capacidad)
    {
        asientos = new Persona?[capacidad];
    }

    // Propiedad para obtener el total de asientos
    public int AsientosTotales => asientos.Length;

    // Propiedad para obtener los asientos disponibles
    public int AsientosDisponibles => asientos.Length - indiceAsiento;

    // Agrega persona a la cola si hay espacio
    public bool AgregarPersona(string nombre)
    {
        if (indiceAsiento + cola.Count < asientos.Length)
        {
            cola.Enqueue(new Persona(nombre));
            return true;
        }
        return false;
    }

    // Asigna asiento a la siguiente persona
    public string? AsignarAsiento()
    {
        if (cola.Count > 0 && indiceAsiento < asientos.Length)
        {
            Persona persona = cola.Dequeue();
            asientos[indiceAsiento++] = persona;
            return persona.Nombre;
        }
        return null;
    }

    // Devuelve la cola de personas (convertida a Queue<string>)
    public Queue<string> ObtenerCola()
    {
        Queue<string> colaNombres = new Queue<string>();
        foreach (var persona in cola)
        {
            colaNombres.Enqueue(persona.Nombre);
        }
        return colaNombres;
    }

    // Devuelve los asientos ocupados (array de Persona?)
    public Persona?[] ObtenerAsientos()
    {
        return asientos;
    }
}
