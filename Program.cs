using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un año:");
        int bisiesto = Convert.ToInt32(Console.ReadLine());

        Esbisiesto(bisiesto);
        
    }

    static void Esbisiesto(int anoingresado)
    {
        if ((anoingresado % 4 == 0 && anoingresado % 100 != 0) || (anoingresado % 400 == 0))
        {
            Console.WriteLine("Es bisiesto.");
        }
        else
        {
            Console.WriteLine("No es bisiesto.");
        }
    }
}








    








