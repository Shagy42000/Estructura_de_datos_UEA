using System;

public class EjercicioInvertir
{
    public static void Ejecutar()
    {
        Lista lista = new Lista();

        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);

        Console.WriteLine("Antes de invertir:");
        lista.Imprimir();

        lista.Invertir();

        Console.WriteLine("Después de invertir:");
        lista.Imprimir();
    }
}