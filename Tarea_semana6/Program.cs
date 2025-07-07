using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSeleccione un ejercicio:");
            Console.WriteLine("1. Invertir lista enlazada");
            Console.WriteLine("2. Buscar valor en lista enlazada");
            Console.WriteLine("3. Salir");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    EjercicioInvertir.Ejecutar();
                    break;
                case "2":
                    EjercicioBuscar.Ejecutar();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}