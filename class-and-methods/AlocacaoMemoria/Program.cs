// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Classes e Métodos ##\n");


Pessoa p1 = new()
{
    idade = 20,
    nome = "Álife",
    sexo = "Masculino"
};

Pessoa p2 = p1;
Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");


Cachorro bilu = new()
{
    nome = "Bilu",
    cor = "Marrom",
    sexo = "Masculino"
};

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}


public class Cachorro
{
    public string? nome;
    public string? cor;
    public string? sexo;

    public void latir();
    public void comer();
}
