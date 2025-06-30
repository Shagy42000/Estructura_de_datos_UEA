using System;

class Ejercicio3
{
    public static void Ejecutar()
    {
        // Arreglo de asignaturas y notas correspondientes
        string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        string[] notas = new string[asignaturas.Length];

        // Preguntar al usuario la nota de cada asignatura
        for (int i = 0; i < asignaturas.Length; i++)
        {
            Console.Write($"¿Qué nota has sacado en {asignaturas[i]}?: ");
            notas[i] = Console.ReadLine();
        }

        // Mostrar las notas introducidas
        Console.WriteLine("\nNotas obtenidas:");
        for (int i = 0; i < asignaturas.Length; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }
    }
}