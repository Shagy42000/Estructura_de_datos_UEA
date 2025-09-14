using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class RevistaCatalogo
    {
        private List<string> revistas;

        public RevistaCatalogo()
        {
            // Inicializamos el catálogo con al menos 10 títulos de revistas
            revistas = new List<string>
            {
                "National Geographic",
                "Time",
                "Forbes",
                "Scientific American",
                "Nature",
                "Vogue",
                "Sports Illustrated",
                "Harvard Business Review",
                "The Economist",
                "Popular Science"
            };
        }

        // Método público que inicia la búsqueda recursiva
        public bool BuscarRevistaRecursiva(string titulo)
        {
            return BuscarRecursivo(titulo, 0);
        }

        // Método recursivo privado
        private bool BuscarRecursivo(string titulo, int indice)
        {
            // Caso base: si llegamos al final de la lista
            if (indice >= revistas.Count)
                return false;

            // Comparamos ignorando mayúsculas/minúsculas
            if (revistas[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;

            // Llamada recursiva avanzando al siguiente índice
            return BuscarRecursivo(titulo, indice + 1);
        }

        // Método para mostrar todos los títulos
        public void MostrarCatalogo()
        {
            Console.WriteLine("\n--- Catálogo de Revistas ---");
            foreach (var revista in revistas)
            {
                Console.WriteLine("- " + revista);
            }
        }
    }
}