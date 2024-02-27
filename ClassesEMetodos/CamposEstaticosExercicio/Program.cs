// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Campos estáticos - Exercício ##\n");
ContaCorrent c1 = new ContaCorrent();
c1.Conta = 101;
c1.Nome = "Maria";
//c1.Juros = 3.99f;

ContaCorrent c2 = new ContaCorrent();
c2.Conta = 101;
c2.Nome = "Marta";
//c2.Juros = 4.99f;
ContaCorrent.Juros = 4.25f;
Console.WriteLine($"Cliente : {c1.Nome} - Juros Anual : {c1.JurosAnul()}");
Console.WriteLine($"Cliente : {c2.Nome} - Juros Anual : {c2.JurosAnul()}");

Console.ReadKey();

public class ContaCorrent
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnul()
    {
        return Juros * 12;
    }
}