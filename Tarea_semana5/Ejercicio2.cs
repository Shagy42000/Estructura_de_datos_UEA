using System;

class Ejercicio2
{
    public static void Ejecutar()
    {
        // Arreglo con asignaturas
        string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        Console.WriteLine("\nAsignaturas que estudias:");

        // Imprimir mensaje para cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}