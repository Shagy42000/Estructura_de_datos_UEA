using System;

// Clase principal que contiene el menú de opciones del sistema
class Programa
{
    static void Main(string[] args)
    {
        ServicioAportes servicio = new ServicioAportes(); // Se instancia el servicio que gestiona los datos
        bool activo = true; // Bandera para controlar el ciclo del menú

        while (activo)
        {
            // Menú principal
            Console.WriteLine("\n--- Sistema de Aportes de Empleados ---");
            Console.WriteLine("1. Registrar empleado");
            Console.WriteLine("2. Agregar aporte");
            Console.WriteLine("3. Ver aportes");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            // Leer opción del usuario
            switch (Console.ReadLine())
            {
                case "1":
                    // Registro de un nuevo empleado
                    Console.Write("Nombre del empleado: ");
                    string nombre = Console.ReadLine();
                    Console.Write("ID del empleado: ");
                    string id = Console.ReadLine();
                    servicio.RegistrarEmpleado(nombre, id);
                    break;

                case "2":
                    // Agregar un aporte a un empleado
                    Console.Write("ID del empleado: ");
                    string id2 = Console.ReadLine();
                    Console.Write("Mes del aporte: ");
                    string mes = Console.ReadLine();
                    Console.Write("Monto del aporte: ");
                    float monto = float.Parse(Console.ReadLine());
                    servicio.AgregarAporte(id2, mes, monto);
                    break;

                case "3":
                    // Mostrar todos los aportes registrados
                    servicio.VerAportes();
                    break;

                case "4":
                    // Finaliza el programa
                    activo = false;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}