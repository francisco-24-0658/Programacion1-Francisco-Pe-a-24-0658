using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero de cinco dígitos:");
        int numero;

        // Validar que el número ingresado sea un entero de cinco dígitos
        while (!int.TryParse(Console.ReadLine(), out numero) || Math.Abs(numero) < 10000 || Math.Abs(numero) > 99999)
        {
            Console.WriteLine("Por favor, ingrese un número válido de cinco dígitos:");
        }

        // Determinar si es capicúa
        bool esCapicua = EsCapicua(numero);

        // Mostrar resultado
        Console.WriteLine($"El número {numero} {(esCapicua ? "es" : "no es")} un número capicúa.");
    }

    // Función para verificar si un número es capicúa
    static bool EsCapicua(int numero)
    {
        string numeroStr = Math.Abs(numero).ToString(); 
        string reversoStr = ReverseString(numeroStr);   
        return numeroStr == reversoStr;                 
    }

    // Función para invertir una cadena
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}


