using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero de cuatro dígitos:");
        int numero;

        // Validar que el número ingresado sea un entero de cuatro dígitos
        while (!int.TryParse(Console.ReadLine(), out numero) || Math.Abs(numero) < 1000 || Math.Abs(numero) > 9999)
        {
            Console.WriteLine("Por favor, ingrese un número válido de cuatro dígitos:");
        }

        // Obtener los dígitos del número
        int segundoDigito = (Math.Abs(numero) / 100) % 10;   
        int penultimoDigito = (Math.Abs(numero) / 10) % 10; 

        // Comparar los dígitos
        if (segundoDigito == penultimoDigito)
        {
            Console.WriteLine($"El segundo dígito ({segundoDigito}) es igual al penúltimo dígito ({penultimoDigito}).");
        }
        else
        {
            Console.WriteLine($"El segundo dígito ({segundoDigito}) no es igual al penúltimo dígito ({penultimoDigito}).");
        }
    }
}




