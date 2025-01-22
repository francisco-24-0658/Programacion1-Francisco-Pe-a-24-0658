int N, A, B, Suma;

Console.WriteLine("Ingrese un número de dos dígitos"); 
N = int.Parse(Console.ReadLine());

A = N % 10;

N = N / 10;

B = N % 10;

N = N / 10;

Suma = A + B;

Console.WriteLine(Suma);


Console.ReadLine();