// See https://aka.ms/new-console-template for more information
Console.WriteLine("Passagem de argumentos por referência (out)");
/*
Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());
Circulo c1 = new Circulo(); 
Console.WriteLine($"Área:{c1.CalculadoraulaArea(raio).ToString("0.###")} - Perimetro:{c1.CalculadoraulaPerimetro(raio).ToString("0.###")}");
public class Circulo
{
    public double CalculadoraulaArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio,2);
        return area;
    }
    public double CalculadoraulaPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;   
    }
}*/

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());
Circulo c1 = new Circulo();
double circ = c1.CalculadoraulaAreaPerimetro(raio, out double area);
Console.WriteLine($"Área:{area.ToString("0.###")} - Perimetro:{circ.ToString("0.###")}");

public class Circulo
{
    public double CalculadoraulaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio,2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
