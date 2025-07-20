using System;
using System.Collections.Generic;

class Program
{
    const int MaxAsientos = 30;
    static Queue<string> cola = new Queue<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("🎢 Bienvenido al sistema de asignación de asientos 🎟️");
        Console.WriteLine($"Hay {MaxAsientos} asientos disponibles.");
        Console.WriteLine("Ingresa entre 1 y 10 nombres separados por comas (ej: Ana, Luis, Pedro).");
        Console.WriteLine("Escribe 'fin' para terminar la entrada.\n");

        while (cola.Count < MaxAsientos)
        {
            Console.Write("Nombres: ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
                break;

            string[] nombres = entrada.Split(',');

            if (nombres.Length < 1 || nombres.Length > 10)
            {
                Console.WriteLine("⚠️ Debes ingresar entre 3 y 10 nombres separados por comas.");
                continue;
            }

            foreach (string nombreCrudo in nombres)
            {
                string nombre = nombreCrudo.Trim();

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    if (cola.Count >= MaxAsientos)
                    {
                        Console.WriteLine("🚫 Ya no hay más asientos disponibles.");
                        break;
                    }

                    cola.Enqueue(nombre);
                    Console.WriteLine($"✅ {nombre} ha sido registrado en la cola.");
                }
            }
        }

        Console.WriteLine("\n🚨 Todos los asientos han sido asignados o se ha terminado el ingreso.\n");
        Console.WriteLine("📋 Lista de personas y sus asientos:");

        int asiento = 1;
        foreach (var persona in cola)
        {
            Console.WriteLine($"Asiento #{asiento}: {persona}");
            asiento++;
        }

        Console.WriteLine("\nGracias por usar el sistema. 🎠");
    }
}