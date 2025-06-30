using System;

class Program
{
    static void Main()
    {
        // Bucle principal que muestra el menú de opciones hasta que el usuario elija salir
        while (true)
        {
            Console.WriteLine("\n--- MENÚ DE EJERCICIOS ---");
            Console.WriteLine("1. Mostrar asignaturas");
            Console.WriteLine("2. Estudiar asignaturas");
            Console.WriteLine("3. Notas de asignaturas");
            Console.WriteLine("4. Números de lotería ordenados");
            Console.WriteLine("5. Números del 1 al 10 en orden inverso");
            Console.WriteLine("0. Salir");

            Console.Write("Elige un ejercicio (0-5): ");
            string opcion = Console.ReadLine(); // Leer opción ingresada por el usuario

            // Ejecutar la opción correspondiente
            switch (opcion)
            {
                case "1":
                    Ejercicio1.Ejecutar();
                    break;
                case "2":
                    Ejercicio2.Ejecutar();
                    break;
                case "3":
                    Ejercicio3.Ejecutar();
                    break;
                case "4":
                    Ejercicio4.Ejecutar();
                    break;
                case "5":
                    Ejercicio5.Ejecutar();
                    break;
                case "0":
                    return; // Salir del programa
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}