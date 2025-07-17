using System;

/// <summary>
/// Clase principal que simula la interacción del usuario con el sistema.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la cola con 30 asientos
        ColaEspera colaEspera = new ColaEspera(30);
        string? opcion;

        Console.WriteLine("====== PARQUE DE DIVERSIONES: SISTEMA DE ASIGNACIÓN DE ASIENTOS ======\n");

        do
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Añadir persona a la cola");
            Console.WriteLine("2. Asignar asientos");
            Console.WriteLine("3. Mostrar asientos disponibles");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el nombre de la persona: ");
                    string? nombre = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("[!] El nombre no puede estar vacío. Intente de nuevo.");
                    }
                    else
                    {
                        colaEspera.AgregarPersona(new Persona(nombre));
                        Console.WriteLine($"[+] {nombre} ha sido añadido a la cola.");
                    }
                    break;

                case "2":
                    colaEspera.AsignarAsientos();
                    break;

                case "3":
                    Console.WriteLine($"\n[ℹ] Asientos disponibles: {colaEspera.AsientosDisponibles()}");
                    break;

                case "4":
                    Console.WriteLine("\n[✔] Gracias por usar el sistema.");
                    break;

                default:
                    Console.WriteLine("\n[!] Opción no válida.");
                    break;
            }

        } while (opcion != "4");
    }
}


