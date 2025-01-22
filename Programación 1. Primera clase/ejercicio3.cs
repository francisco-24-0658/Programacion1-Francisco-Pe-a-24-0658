using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero de dos dígitos:");
        int numero;

        // Validar que el número ingresado sea un entero de dos dígitos
        while (!int.TryParse(Console.ReadLine(), out numero) || Math.Abs(numero) < 10 || Math.Abs(numero) > 99)
        {
            Console.WriteLine("Por favor, ingrese un número válido de dos dígitos:");
        }

        // Determinar si es negativo
        bool esNegativo = numero < 0;

        // Determinar si es primo (solo si no es negativo)
        bool esPrimo = EsPrimo(Math.Abs(numero));

        // Mostrar resultados
        Console.WriteLine($"El número ingresado es {(esNegativo ? "negativo" : "positivo")}.");
        if (esNegativo)
        {
            Console.WriteLine("No se evalúa si es primo porque es negativo.");
        }
        else
        {
            Console.WriteLine($"El número {(esPrimo ? "es primo" : "no es primo")}.");
        }
    }

    // Función para determinar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}
