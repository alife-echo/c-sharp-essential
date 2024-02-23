// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadorauladora Calculadora = new();

Console.WriteLine($"{Calculadora.Somar(10,10)}");
Console.WriteLine($"{Calculadora.Subtrair(20,10)}");
Console.WriteLine($"{Calculadora.Multiplicar(2,10)}");
Console.WriteLine($"{Calculadora.Dividir(50,10)}");

public class Calculadorauladora
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
