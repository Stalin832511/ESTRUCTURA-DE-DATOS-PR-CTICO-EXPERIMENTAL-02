using System;
using System.Collections.Generic;

public class Reporteria
{
    public void MostrarColaActual(Queue<string> cola)
    {
        Console.WriteLine("\n📋 Reporte de la Cola de Espera:");
        if (cola.Count == 0)
        {
            Console.WriteLine("La cola está vacía.");
        }
        else
        {
            int i = 1;
            foreach (var nombre in cola)
            {
                Console.WriteLine($"{i}. {nombre}");
                i++;
            }
        }
    }

    public void MostrarEstado(Atraccion atraccion)
    {
        Console.WriteLine("\n📊 Estado actual de la atracción:");
        Console.WriteLine($"- Asientos totales: {atraccion.AsientosTotales}");
        Console.WriteLine($"- Asientos ocupados: {atraccion.AsientosTotales - atraccion.AsientosDisponibles}");
        Console.WriteLine($"- Asientos disponibles: {atraccion.AsientosDisponibles}");
    }
}
