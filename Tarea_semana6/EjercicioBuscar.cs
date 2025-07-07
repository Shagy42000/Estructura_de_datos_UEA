using System;

public class EjercicioBuscar
{
    public static void Ejecutar()
    {
        Lista lista = new Lista();

        lista.Agregar(5);
        lista.Agregar(10);
        lista.Agregar(5);
        lista.Agregar(15);
        lista.Agregar(5);

        lista.Imprimir();

        Console.Write("Ingresa el valor a buscar: ");
        int valor = int.Parse(Console.ReadLine()!);

        lista.Buscar(valor);
    }
}