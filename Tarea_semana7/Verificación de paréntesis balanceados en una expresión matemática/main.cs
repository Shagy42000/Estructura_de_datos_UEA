using System;
using System.Collections.Generic;

class Program
{
    /// <summary>
    /// Punto de entrada del programa.
    /// Solicita al usuario una expresión matemática y verifica si está balanceada.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Ingrese una expresión matemática:");
        string expresion = Console.ReadLine();

        if (EstaBalanceada(expresion))
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula no balanceada.");
        }
    }

    /// <summary>
    /// Verifica si todos los paréntesis, llaves y corchetes están correctamente balanceados en una cadena.
    /// </summary>
    /// <param name="expresion">La expresión matemática a evaluar.</param>
    /// <returns>True si está balanceada, False si no lo está.</returns>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>(); // Pila para rastrear los caracteres de apertura

        foreach (char c in expresion)
        {
            // Si es un carácter de apertura, lo agregamos a la pila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es un carácter de cierre, verificamos que coincida con el último abierto
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si no hay nada que cerrar
                if (pila.Count == 0)
                    return false;

                char tope = pila.Pop();

                // Verificamos si los caracteres coinciden
                if (!EsPar(tope, c))
                    return false;
            }
        }

        // Al final, si la pila está vacía, todo está balanceado
        return pila.Count == 0;
    }

    /// <summary>
    /// Determina si dos caracteres forman un par de apertura y cierre válido.
    /// </summary>
    /// <param name="apertura">Carácter de apertura.</param>
    /// <param name="cierre">Carácter de cierre.</param>
    /// <returns>True si forman un par válido, False en caso contrario.</returns>
    static bool EsPar(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}