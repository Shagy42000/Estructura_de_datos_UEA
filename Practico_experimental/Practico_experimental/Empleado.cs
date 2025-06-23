using System.Collections.Generic;

// Clase que representa un empleado con su identificación, nombre y lista de aportes
public class Empleado
{
    public string Nombre { get; set; }     // Nombre del empleado
    public string ID { get; set; }         // ID único del empleado
    public List<Aporte> Aportes { get; set; } = new List<Aporte>(); // Lista de aportes realizados

    // Método que suma todos los montos de aportes de un empleado
    public float TotalAportes()
    {
        float total = 0;
        foreach (var aporte in Aportes)
        {
            total += aporte.Monto; // Se suma cada monto individual al total
        }
        return total;
    }
}