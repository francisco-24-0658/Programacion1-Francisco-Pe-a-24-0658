public class Resta
{
    public double valor1 { get; set;}
    public double valor2 {get; set;}

    public double valor3 {get; set;}


    public Resta(double valor1, double valor2, double valor3)
    {
        this.valor1 = valor1;
        this.valor2 = valor2;
        this.valor3 = valor3;
    }
    public double Sumar(double valor4)
    {
        return valor1 - valor2  - valor3  - valor4 ;
    }   

}