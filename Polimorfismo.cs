using System;

// Clase base
public class Ave
{
    public string Nombre { get; set; }
    public string Color { get; set; }
    
    public Ave(string nombre, string color)
    {
        Nombre = nombre;
        Color = color;
    }
    
    public virtual void Volar()
    {
        Console.WriteLine("Esta ave puede volar.");
    }
    
    public virtual void EmitirSonido()
    {
        Console.WriteLine("Esta ave emite un sonido genérico.");
    }
}

// Clase derivada Aguila
public class Aguila : Ave
{
    public Aguila(string nombre, string color) : base(nombre, color) {}
    
    public override void Volar()
    {
        Console.WriteLine("El águila vuela a grandes alturas.");
    }
    
    public override void EmitirSonido()
    {
        Console.WriteLine("El águila emite un sonido agudo.");
    }
}

// Clase derivada Pato
public class Pato : Ave
{
    public Pato(string nombre, string color) : base(nombre, color) {}
    
    public override void Volar()
    {
        Console.WriteLine("El pato vuela a alturas bajas y también nada.");
    }
    
    public override void EmitirSonido()
    {
        Console.WriteLine("El pato hace cuac cuac.");
    }
}

class Program
{
    static void Main()
    {
        Ave aguila = new Aguila("Águila Real", "Marrón");
        Ave pato = new Pato("Pato Silvestre", "Blanco");
        
        aguila.Volar();
        aguila.EmitirSonido();
        
        pato.Volar();
        pato.EmitirSonido();
    }
}
