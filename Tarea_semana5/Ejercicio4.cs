using System;
using System.Linq; // Necesario para Join()

class Ejercicio4
{
    public static void Ejecutar()
    {
        // Arreglo para guardar los números
        int[] numeros = new int[6];

        Console.WriteLine("\nIntroduce los números ganadores de la lotería primitiva:");

        // Pedir 6 números al usuario
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar los números de menor a mayor
        Array.Sort(numeros);

        Console.WriteLine("\nNúmeros ganadores ordenados:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}