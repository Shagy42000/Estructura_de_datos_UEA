using System;
using System.Collections.Generic;

// Clase que contiene los métodos para manejar empleados y sus aportes
public class ServicioAportes
{
    // Lista donde se almacenan todos los empleados registrados
    private List<Empleado> empleados = new List<Empleado>();

    // Método para registrar un nuevo empleado con nombre e ID
    public void RegistrarEmpleado(string nombre, string id)
    {
        empleados.Add(new Empleado { Nombre = nombre, ID = id });
        Console.WriteLine("Empleado registrado.");
    }

    // Método para agregar un aporte a un empleado ya registrado
    public void AgregarAporte(string id, string mes, float monto)
    {
        // Buscar el empleado según el ID
        Empleado emp = empleados.Find(e => e.ID == id);
        if (emp != null)
        {
            // Agregar un nuevo aporte si se encuentra el empleado
            emp.Aportes.Add(new Aporte { Mes = mes, Monto = monto });
            Console.WriteLine("Aporte agregado.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    // Método para mostrar los aportes registrados por cada empleado
    public void VerAportes()
    {
        foreach (var emp in empleados)
        {
            Console.WriteLine($"\nEmpleado: {emp.Nombre} (ID: {emp.ID})");
            foreach (var ap in emp.Aportes)
            {
                Console.WriteLine($" - {ap.Mes}: ${ap.Monto}");
            }
            Console.WriteLine($"Total aportado: ${emp.TotalAportes()}");
        }
    }
}