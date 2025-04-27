const string saudacao = "Bem Vindo";
const string titulo = "Srta.";
const string nome = "Amanda";

//antes do c# 10
const string saudacoes = saudacao + titulo + nome;

//depois do c# 10
const string saudacoes2 = $"{saudacao},{titulo}{nome}";

Console.WriteLine(saudacoes);
Console.WriteLine(saudacoes2);



var pr = new Projeto("EJ", 3, new Linguagem("C#"));

//pr.Nome = "Bitjs";

var prod = new Produto("IPHONE", 5);

//prod.Nome = "MULTILASER";


// sintaxe antes do c# 10
static string Juntar(string a, string b)
{
    if(a is null) 
        throw new ArgumentNullException(nameof(a));
    if(b is null)
        throw new ArgumentNullException(nameof(b));
    
    return a + b;
}

// depois do c# 10

static string Juntar2(string a, string b)
{
    // posso lançar uma exceção se o argumento for nulo e ainda pegar o nome real da varivel
    // faz a mesma coisa antes do c# 10, mas de forma mais simplificada
    ArgumentNullException.ThrowIfNull(a); 
    ArgumentNullException.ThrowIfNull(b);
    return a + b;
}



public readonly record struct Projeto(string Nome, int Versao, Linguagem? Linguagem);

public readonly record struct Linguagem(string? Nome);

public record Produto(string? Nome, int Quantidade);