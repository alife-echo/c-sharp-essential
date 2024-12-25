// See https://aka.ms/new-console-template for more information
Console.WriteLine("Classes E Metodos");
Console.ReadKey();


Pessoa p1 = new();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";
Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");
Pessoa p2 = new()
{
    nome = "Alife",
    idade = 23,
    sexo = "masculino"
};
Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");
class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
