using System;
using System.Collections.Generic;

/// <summary>
/// Maneja la lógica de la cola de espera para asignar asientos.
/// Implementa una estructura de datos FIFO (First In, First Out).
/// </summary>
public class ColaEspera
{
    private Queue<Persona> cola; // Cola de personas esperando
    private int totalAsientos;
    private int asientosAsignados;

    public ColaEspera(int totalAsientos)
    {
        this.totalAsientos = totalAsientos;
        cola = new Queue<Persona>();
        asientosAsignados = 0;
    }

    /// <summary>
    /// Agrega una persona a la cola si aún hay asientos disponibles.
    /// </summary>
    public void AgregarPersona(Persona persona)
    {
        if (asientosAsignados < totalAsientos)
        {
            cola.Enqueue(persona); // Se encola al final
            Console.WriteLine($"[+] {persona.Nombre} ha sido añadido a la cola.");
        }
        else
        {
            Console.WriteLine($"[!] No hay asientos disponibles para {persona.Nombre}.");
        }
    }

    /// <summary>
    /// Asigna asientos en orden de llegada a las personas en la cola.
    /// </summary>
    public void AsignarAsientos()
    {
        Console.WriteLine("\n>>> Iniciando asignación de asientos:\n");
        while (cola.Count > 0 && asientosAsignados < totalAsientos)
        {
            Persona persona = cola.Dequeue(); // Se desencola del inicio
            asientosAsignados++;
            Console.WriteLine($"[✔] {persona.Nombre} ha recibido el asiento #{asientosAsignados}");
        }

        if (asientosAsignados == totalAsientos)
        {
            Console.WriteLine("\n[✔] Todos los asientos han sido asignados.");
        }
    }

    /// <summary>
    /// Devuelve cuántos asientos aún están disponibles.
    /// </summary>
    public int AsientosDisponibles()
    {
        return totalAsientos - asientosAsignados;
    }
}
