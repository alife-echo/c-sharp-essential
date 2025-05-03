/*using Transacao = (decimal Valor, System.DateTime Data,  TipoTransacao Tipo);
using Ponto3D = (int,int,int);
// todos os parametros precisam estar preenchidos 
// caso falta ou tenha demais um parametro = Tuple component should be removed to match the expected type
Ponto3D ponto3d = (1,2,3);

List<Transacao> transacoes = new List<Transacao>
{
    (100.00M,DateTime.Now,TipoTransacao.Deposito),
    (50.00M,DateTime.Now.AddDays(-1),TipoTransacao.Transferencia),
    (25.00M,DateTime.Now.AddDays(-3),TipoTransacao.Saque)
};

Console.WriteLine("Lista de transacoes");

foreach (var transacao in transacoes)
{
    Console.WriteLine($"Valor: {transacao.Valor:C}" +
                      $" Data:{transacao.Data}" +
                      $" Tipo:{transacao.Tipo}");
}

public enum TipoTransacao
{
    Deposito,Saque,Transferencia
}*/


/*
int[] numeros = [1,2,3,4,5];

Span<string> regiaoSul = ["PR","SC","RS"];

ReadOnlySpan<string> regiaoSudeste = ["ES","MG","RJ","SP"];

List<string> frutas = ["Amora","Banana","Caju","Damasco"];

int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];
int[] single = [.. row0, .. row1, .. row2];
foreach (var element in single)
{
    Console.Write($"{element}, ");
}*/


var incrementarValor = (int origem, int incremento = 2) => origem + incremento;

Console.WriteLine(incrementarValor(5));
Console.WriteLine(incrementarValor(5,3));


var listaProdutos = new List<Produto>()
{
    new Produto("Produto A",10.99M),
    new Produto("Produto B",15.99M),
    new Produto("Produto C",5.99M),
    new Produto("Produto D",20.99M),
    new Produto("Produto E",1.99M),
};

var filtrarPorPrecoMinimo = (decimal precoMinimo = 0.0M) =>
{
    return listaProdutos.FindAll(p => p.Preco >= precoMinimo);
};

foreach (var produto in filtrarPorPrecoMinimo(8.0M))
{
    Console.WriteLine($"{produto.Nome} {produto.Preco}");
}

Console.WriteLine("-----------------");
foreach (var produto in filtrarPorPrecoMinimo(0))
{
    Console.WriteLine($"{produto.Nome} {produto.Preco}");
}
public class Produto
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}