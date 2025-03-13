public class SumarRaiz
{
    public double valor1 { get; set;}
    public double valor2 {get; set;}

    public double valor3 {get; set;}


    public SumarRaiz(double valor1, double valor2, double valor3)
    {
        this.valor1 = valor1;
        this.valor2 = valor2;
        this.valor3 = valor3;
    }
    public double Sumar(double valor4)
    {
        return Math.Sqrt(valor1) + Math.Sqrt(valor2)+ Math.Sqrt(valor3) +Math.Sqrt(valor4);
    }   

}