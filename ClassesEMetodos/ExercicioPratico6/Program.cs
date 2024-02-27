// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercício Prático 6");

Console.ReadKey();

Console.WriteLine($"IPVA:{Carro.ObterValorIPVA()}");
class Carro
{
    public static double ValorIpva;

    public static double ObterValorIPVA()
    {
        ValorIpva = 4;
        return ValorIpva;
        
    }
}