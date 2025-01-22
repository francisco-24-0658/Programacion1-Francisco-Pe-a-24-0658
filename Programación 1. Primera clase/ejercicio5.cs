using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero de tres dígitos:");
        int numero;

        // Validar que el número ingresado sea un entero de tres dígitos
        while (!int.TryParse(Console.ReadLine(), out numero) || Math.Abs(numero) < 100 || Math.Abs(numero) > 999)
        {
            Console.WriteLine("Por favor, ingrese un número válido de tres dígitos:");
        }

        // Obtener los dígitos del número
        int centena = Math.Abs(numero) / 100;          // Dígito de la centena
        int decena = (Math.Abs(numero) / 10) % 10;     // Dígito de la decena
        int unidad = Math.Abs(numero) % 10;            // Dígito de la unidad

        // Determinar el mayor dígito y su posición
        int mayor = Math.Max(centena, Math.Max(decena, unidad));
        string posicion;

        if (mayor == centena)
        {
            posicion = "centena";
        }
        else if (mayor == decena)
        {
            posicion = "decena";
        }
        else
        {
            posicion = "unidad";
        }

        // Mostrar el resultado
        Console.WriteLine($"El mayor dígito es {mayor} y está en la posición de la {posicion}.");
    }
}
