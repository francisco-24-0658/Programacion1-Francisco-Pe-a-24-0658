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

        // Obtener los dígitos del número
        int digito1 = Math.Abs(numero) / 10; // Primer dígito
        int digito2 = Math.Abs(numero) % 10; // Segundo dígito

        // Verificar si los dígitos son primos
        bool digito1EsPrimo = EsPrimo(digito1);
        bool digito2EsPrimo = EsPrimo(digito2);

        // Mostrar resultados
        Console.WriteLine($"Primer dígito ({digito1}): {(digito1EsPrimo ? "Es primo" : "No es primo")}");
        Console.WriteLine($"Segundo dígito ({digito2}): {(digito2EsPrimo ? "Es primo" : "No es primo")}");

        if (digito1EsPrimo && digito2EsPrimo)
        {
            Console.WriteLine("Ambos dígitos son primos.");
        }
        else
        {
            Console.WriteLine("No ambos dígitos son primos.");
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
