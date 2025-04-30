using System.Diagnostics.CodeAnalysis;

namespace new_resources_III;

/*
public class Pessoa
{
    // esses campos obrigatoriamente precisam ser inicializados
    public required string Nome { get; set; }
    public required int Idade { get; set; }
    
    public Pessoa(){}

    // este parametro emite um erro caso o construtor recebe apenas um parametro ou nenhum
    // força o construtor a passar todos os parametros requeridos
    [SetsRequiredMembers] 
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}*/

/*
public class Pessoa
{
    private string? nome;
    public string Nome
    {
        get => nome; 
        set => nome = value ?? throw new ArgumentNullException(nameof(value), $"{(nameof(Nome))} não pode ser null");
    }

    public int GetIdentidade()
    {
        var identidade = new PessoaIdentidade();
        return identidade.GetCpf;
    }

    [MeuAtributo(nameof(meuParametro))]
    public void MeuMetodoComParametro(string meuParametro)
    {
       
    }
}


file class PessoaIdentidade
{
    public int GetCpf => 1234567;
}*/



// antees do c# 12 o codigo abaixo produziria um erro, pois ao criar um construtor personalizado
// eu não podia inicializalo vaziamente
public struct Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa(string nome)
    {
        Nome = nome; 
        Idade = 0;
    }

    [AtributoGenerico<string>()]
    public string MeuOutroMetodo() => default;
    
    [MeuAtributo2(typeof(string))]
    public string MeuOutroMetodo2() => default;
}


