using System;
using System.Collections.Generic;

class  Program
{
    // Diccionario principal: inglés -> español
    static Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "año"},
        {"way", "camino"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"part", "parte"},
        {"child", "niño"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"place", "lugar"},
        {"work", "trabajo"},
        {"week", "semana"},
        {"case", "caso"},
        {"point", "punto"},
        {"government", "gobierno"},
        {"company", "empresa"}
    };

    static void Main()
    {
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("⚠️ Opción inválida. Intente de nuevo.");
                opcion = -1;
                continue;
            }

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("👋 Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("⚠️ Opción inválida.");
                    break;
            }
        }
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese una frase: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<string> resultado = new List<string>();

        foreach (string palabra in palabras)
        {
            // Limpieza de puntuación
            string limpia = palabra.Trim(',', '.', ';', ':', '!', '?');
            string traduccion;

            if (diccionario.TryGetValue(limpia.ToLower(), out traduccion))
            {
                // Respetar mayúscula inicial si la palabra original la tiene
                if (char.IsUpper(limpia[0]))
                {
                    traduccion = char.ToUpper(traduccion[0]) + traduccion.Substring(1);
                }

                // Volvemos a agregar la puntuación
                resultado.Add(palabra.Replace(limpia, traduccion));
            }
            else
            {
                resultado.Add(palabra); // palabra no encontrada, se deja igual
            }
        }

        Console.WriteLine("\n🔎 Traducción: " + string.Join(" ", resultado));
    }

    static void AgregarPalabra()
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese la traducción al español: ");
        string espanol = Console.ReadLine().Trim();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine($"✅ Palabra '{ingles}' -> '{espanol}' agregada correctamente.");
        }
        else
        {
            Console.WriteLine($"⚠️ La palabra '{ingles}' ya existe en el diccionario.");
        }
    }
}