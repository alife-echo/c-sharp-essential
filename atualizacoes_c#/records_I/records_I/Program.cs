// Tipo por valor
using records_I;

var client1 = new Cliente("Álife", 30);

Console.WriteLine(client1.Nome);
Console.WriteLine(client1.Idade);


var cliente2 = client1 with { Nome = "Regis" };

var cliente3 = new Cliente("Regis", 30);


Console.WriteLine(cliente2.Nome);
Console.WriteLine(cliente2.Idade);


Console.WriteLine(client1.Equals(cliente2));

Console.WriteLine(cliente2.Equals(cliente3));

public record Cliente
{
    public string Nome = string.Empty;
    public int Idade;

    public Cliente(string nome,int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}