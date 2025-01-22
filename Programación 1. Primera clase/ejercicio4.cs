using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número entero de dos dígitos:");
        int numero1 = LeerNumeroDeDosDigitos();

        Console.WriteLine("Ingrese el segundo número entero de dos dígitos:");
        int numero2 = LeerNumeroDeDosDigitos();

        // Calcular la suma de los dos números
        int suma = numero1 + numero2;

        // Determinar si la suma es un número par
        bool esPar = suma % 2 == 0;

        // Mostrar resultados
        Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}, que es un número {(esPar ? "par" : "impar")}.");
    }

    // Método para leer un número de dos dígitos
    static int LeerNumeroDeDosDigitos()
    {
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || Math.Abs(numero) < 10 || Math.Abs(numero) > 99)
        {
            Console.WriteLine("Por favor, ingrese un número válido de dos dígitos:");
        }
        return numero;
    }
}

