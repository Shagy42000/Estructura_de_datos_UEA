using System;
// Clase Circulo encapsula el radio como dato privado
public class Circulo
{
    private double radio; // Almacena el valor del radio

    // Constructor de la clase Circulo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea devuelve el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase Rectangulo encapsula el ancho y el alto
public class Rectangulo
{
    private double ancho; // Almacena el ancho del rectángulo
    private double alto;  // Almacena el alto del rectángulo

    // Constructor de la clase Rectangulo
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }
    
    // CalcularArea devuelve el área del rectángulo
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // CalcularPerimetro devuelve el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}

// Clase Programa contiene el punto de entrada del programa
public class Programa
{
    public static void Main()
    {
        // Crear un objeto Circulo con radio 5
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        // Crear un objeto Rectangulo con ancho 4 y alto 6
        Rectangulo miRectangulo = new Rectangulo(4, 6);
        Console.WriteLine("Área del rectángulo: " + miRectangulo.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.CalcularPerimetro());
    }
}
