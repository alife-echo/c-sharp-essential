
namespace records_II;
/*
public record Cliente
{
    public string Nome = string.Empty;
    public int Idade;

    public Cliente(string nome,int idade) =>
        (Nome,Idade) = (nome,idade);

    public void Deconstruct(out string nome, out int idade) =>
        (nome, idade) = (Nome,Idade);

}*/

// criando uma record abrevido, todas as propriedades e conceitos acima estão implicitas no record abaixo
public record Cliente (string Nome, int Idade);

