// See https://aka.ms/new-console-template for more information
Console.WriteLine("Passagem de argumentos por referência (out)");
/*
Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());
Circulo c1 = new Circulo(); 
Console.WriteLine($"Área:{c1.CalculaArea(raio).ToString("0.###")} - Perimetro:{c1.CalculaPerimetro(raio).ToString("0.###")}");
public class Circulo
{
    public double CalculaArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio,2);
        return area;
    }
    public double CalculaPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;   
    }
}*/

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());
Circulo c1 = new Circulo();
double circ = c1.CalculaAreaPerimetro(raio, out double area);
Console.WriteLine($"Área:{area.ToString("0.###")} - Perimetro:{circ.ToString("0.###")}");

public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio,2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
