// See https://aka.ms/new-console-template for more information
Console.WriteLine("Passagem de argumentos por referencia (ref)");


int x = 20;
Console.WriteLine("\n Valor do argumento x antes de passar por valor : " + x);
Console.WriteLine("\n--------------------------------------");

Calculadoraulo Calculadora = new();
Calculadora.Dobrar(ref x); // passagem da cópia da referência da memória do argumento x para o parâmetro y

Console.WriteLine("\n Valor do argumento x depois de passar por valor : " + x);
Console.WriteLine("\n--------------------------------------");
public class Calculadoraulo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}