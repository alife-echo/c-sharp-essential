// See https://aka.ms/new-console-template for more information
Console.WriteLine("Passando Argumentos por Valor");

int x = 20;
Console.WriteLine("\n Valor do argumento x antes de passar por valor : " + x);
Console.WriteLine("\n--------------------------------------");

Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine("\n Valor do argumento x depois de passar por valor : " + x);
Console.WriteLine("\n--------------------------------------");
public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}