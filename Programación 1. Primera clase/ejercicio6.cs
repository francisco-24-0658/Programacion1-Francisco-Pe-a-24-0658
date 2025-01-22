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
        int centena = Math.Abs(numero) / 100;          
        int decena = (Math.Abs(numero) / 10) % 10;     
        int unidad = Math.Abs(numero) % 10;            

        // Verificar si algún dígito es múltiplo de los otros
        bool centenaEsMultiplo = EsMultiploDe(centena, decena) && EsMultiploDe(centena, unidad);
        bool decenaEsMultiplo = EsMultiploDe(decena, centena) && EsMultiploDe(decena, unidad);
        bool unidadEsMultiplo = EsMultiploDe(unidad, centena) && EsMultiploDe(unidad, decena);

        // Mostrar resultados
        if (centenaEsMultiplo)
        {
            Console.WriteLine($"El dígito de la centena ({centena}) es múltiplo de los otros.");
        }
        else if (decenaEsMultiplo)
        {
            Console.WriteLine($"El dígito de la decena ({decena}) es múltiplo de los otros.");
        }
        else if (unidadEsMultiplo)
        {
            Console.WriteLine($"El dígito de la unidad ({unidad}) es múltiplo de los otros.");
        }
        else
        {
            Console.WriteLine("Ningún dígito es múltiplo de los otros.");
        }
    }

    // Función para determinar si un número es múltiplo de otro
    static bool EsMultiploDe(int numero, int divisor)
    {
        // Evitar división por cero
        if (divisor == 0) return false;
        return numero % divisor == 0;
    }
}

