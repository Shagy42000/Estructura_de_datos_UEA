using System;

public class Lista
{
    private Nodo? cabeza;

    public Lista()
    {
        cabeza = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    public void Imprimir()
    {
        Nodo? actual = cabeza;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public void Invertir()
    {
        Nodo? previo = null;
        Nodo? actual = cabeza;
        Nodo? siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = previo;
            previo = actual;
            actual = siguiente;
        }

        cabeza = previo;
        Console.WriteLine("Lista invertida.");
    }

    public void Buscar(int valor)
    {
        int contador = 0;
        Nodo? actual = cabeza;

        while (actual != null)
        {
            if (actual.Valor == valor)
                contador++;

            actual = actual.Siguiente;
        }

        if (contador > 0)
            Console.WriteLine($"El valor {valor} aparece {contador} vez/veces.");
        else
            Console.WriteLine($"El valor {valor} no fue encontrado en la lista.");
    }
}