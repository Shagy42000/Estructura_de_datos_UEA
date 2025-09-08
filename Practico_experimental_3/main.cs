using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Conjunto de categorías
        HashSet<string> categorias = new HashSet<string>() { "Novela", "Ciencia", "Historia", "Tecnología" };

        // Diccionario de libros (Clave: CódigoLibro, Valor: (Título, Autor, Categoría))
        Dictionary<int, (string Titulo, string Autor, string Categoria)> libros = new Dictionary<int, (string, string, string)>();

        // Registro inicial de libros
        libros.Add(1, ("Cien años de soledad", "Gabriel García Márquez", "Novela"));
        libros.Add(2, ("Breve historia del tiempo", "Stephen Hawking", "Ciencia"));
        libros.Add(3, ("Introducción a la Programación", "Bjarne Stroustrup", "Tecnología"));

        // Mostrar libros registrados
        Console.WriteLine("📚 LISTA DE LIBROS REGISTRADOS EN LA BIBLIOTECA:\n");
        foreach (var libro in libros)
        {
            Console.WriteLine($"Código: {libro.Key} | Título: {libro.Value.Titulo} | Autor: {libro.Value.Autor} | Categoría: {libro.Value.Categoria}");
        }

        // Consultar si una categoría existe
        Console.WriteLine("\nIngrese una categoría a consultar: ");
        string consulta = Console.ReadLine();

        if (categorias.Contains(consulta))
        {
            Console.WriteLine($"✅ La categoría '{consulta}' existe en la biblioteca.");
        }
        else
        {
            Console.WriteLine($"❌ La categoría '{consulta}' no existe en la biblioteca.");
        }

        // Buscar libro por código
        Console.WriteLine("\nIngrese un código de libro a buscar: ");
        int codigo = int.Parse(Console.ReadLine());

        if (libros.ContainsKey(codigo))
        {
            var l = libros[codigo];
            Console.WriteLine($"📖 Libro encontrado -> {l.Titulo} de {l.Autor} ({l.Categoria})");
        }
        else
        {
            Console.WriteLine("❌ No existe un libro con ese código.");
        }
    }
}