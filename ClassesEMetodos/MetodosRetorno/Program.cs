// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora calc = new();

Console.WriteLine($"{calc.Somar(10,10)}");
Console.WriteLine($"{calc.Subtrair(20,10)}");
Console.WriteLine($"{calc.Multiplicar(2,10)}");
Console.WriteLine($"{calc.Dividir(50,10)}");

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
