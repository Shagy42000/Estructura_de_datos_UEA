using System;

class Ejercicio1
{
    public static void Ejecutar()
    {
        // Definir un arreglo de asignaturas
        string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        Console.WriteLine("\nAsignaturas del curso:");

        // Imprimir cada asignatura en consola
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}