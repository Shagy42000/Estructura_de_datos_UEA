using System;
using System.Collections.Generic;

class Program
{
    /// <summary>
    /// Punto de entrada del programa. Solicita al usuario el número de discos y resuelve el problema de las Torres de Hanoi.
    /// </summary>
    static void Main()
    {
        Console.Write("Ingrese el número de discos: ");
        int n = int.Parse(Console.ReadLine());

        // Crear las tres torres como pilas
        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Inicializar la torre origen con los discos en orden descendente
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("\nMovimientos:");
        MoverTorres(n, origen, destino, auxiliar, 'A', 'C', 'B');
    }

    /// <summary>
    /// Método recursivo que resuelve el problema de las Torres de Hanoi.
    /// </summary>
    /// <param name="n">Número de discos a mover.</param>
    /// <param name="origen">Torre de origen.</param>
    /// <param name="destino">Torre de destino.</param>
    /// <param name="auxiliar">Torre auxiliar.</param>
    /// <param name="nombreOrigen">Etiqueta de la torre de origen.</param>
    /// <param name="nombreDestino">Etiqueta de la torre de destino.</param>
    /// <param name="nombreAuxiliar">Etiqueta de la torre auxiliar.</param>
    static void MoverTorres(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                            char nombreOrigen, char nombreDestino, char nombreAuxiliar)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
            return;
        }

        // Mover n-1 discos a la torre auxiliar
        MoverTorres(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

        // Mover el disco restante a la torre destino
        MoverDisco(origen, destino, nombreOrigen, nombreDestino);

        // Mover los n-1 discos desde auxiliar a destino
        MoverTorres(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
    }

    /// <summary>
    /// Mueve un disco de una torre a otra y muestra el movimiento.
    /// </summary>
    /// <param name="desde">Torre de origen.</param>
    /// <param name="hacia">Torre de destino.</param>
    /// <param name="nombreDesde">Etiqueta de la torre de origen.</param>
    /// <param name="nombreHacia">Etiqueta de la torre de destino.</param>
    static void MoverDisco(Stack<int> desde, Stack<int> hacia, char nombreDesde, char nombreHacia)
    {
        int disco = desde.Pop();
        hacia.Push(disco);
        Console.WriteLine($"Mover disco {disco} de torre {nombreDesde} a torre {nombreHacia}");
    }
}