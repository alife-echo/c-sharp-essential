// See https://aka.ms/new-console-template for more information
Console.WriteLine("Métodos Estáticos");


Console.WriteLine($"{Calculadora.Somar(10, 10)}");
Console.WriteLine($"{Calculadora.Subtrair(20, 10)}");
Console.WriteLine($"{Calculadora.Multiplicar(2, 10)}");
Console.WriteLine($"{Calculadora.Dividir(50, 10)}");

Console.ReadKey();
public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}

