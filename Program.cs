using System;

class Program
{
    static void Main(string[] args)
    {
        Atraccion atraccion = new Atraccion(30); // Capacidad de 30 asientos
        Reporteria reporteria = new Reporteria();

        while (true)
        {
            Console.WriteLine("\n🎡 Menú Principal");
            Console.WriteLine("1. Agregar persona a la cola");
            Console.WriteLine("2. Asignar asiento a la siguiente persona");
            Console.WriteLine("3. Ver reporte de cola");
            Console.WriteLine("4. Ver estado de asientos");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el nombre de la persona: ");
                    string? nombre = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("❌ El nombre no puede estar vacío.");
                    }
                    else
                    {
                        if (atraccion.AgregarPersona(nombre))
                            Console.WriteLine($"{nombre} ha sido agregado a la cola.");
                        else
                            Console.WriteLine("❌ No hay más asientos disponibles.");
                    }
                    break;

                case "2":
                    string? siguiente = atraccion.AsignarAsiento();

                    if (!string.IsNullOrWhiteSpace(siguiente))
                        Console.WriteLine($"🎟️ {siguiente} ha subido a la atracción.");
                    else
                        Console.WriteLine("La cola está vacía o no hay más asientos.");
                    break;

                case "3":
                    reporteria.MostrarColaActual(atraccion.ObtenerCola());
                    break;

                case "4":
                    reporteria.MostrarEstado(atraccion);
                    break;

                case "5":
                    Console.WriteLine("Gracias por usar el sistema.");
                    return;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
