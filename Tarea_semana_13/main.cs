using System;

namespace CatalogoRevistas
{
    class Program
    {
        static void Main(string[] args)
        {
            RevistaCatalogo catalogo = new RevistaCatalogo();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n===== Catálogo de Revistas =====");
                Console.WriteLine("1. Buscar título");
                Console.WriteLine("2. Mostrar todos los títulos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el título a buscar: ");
                        string titulo = Console.ReadLine();
                        bool encontrado = catalogo.BuscarRevistaRecursiva(titulo);
                        Console.WriteLine(encontrado ? "Encontrado" : "No encontrado");
                        break;
                    case "2":
                        catalogo.MostrarCatalogo();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
        }
    }
}