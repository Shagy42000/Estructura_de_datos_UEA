using System;

class Ejercicio5
{
    public static void Ejecutar()
    {
        // Crear arreglo del 1 al 10
        int[] numeros = new int[10];
        for (int i = 0; i < 10; i++)
        {
            numeros[i] = i + 1;
        }

        // Invertir el arreglo
        Array.Reverse(numeros);

        Console.WriteLine("\nNúmeros del 1 al 10 en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}