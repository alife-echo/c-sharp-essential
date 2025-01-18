
using linq_queries1;

// FONTE DADOS
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("Produtos Eletrônicos");
var produtoEletronicos = listaProdutos.Where(p => p.Categoria == "Eletrônicos");

Exibir(produtoEletronicos);

Console.WriteLine();
Console.WriteLine("Produtos mais caros com estoque superior a 5");
var produtosCarosComEstoque = listaProdutos.
    Where(p => p.Preco >= 2000 && p.Estoque > 5);

Exibir(produtosCarosComEstoque);

Console.WriteLine();
Console.WriteLine("\n Lista de produtos com estoque minimo(<10) ordenados po nome");
var minimoOrdeanado = listaProdutos.Where(p => p.Estoque < 10).OrderBy(p => p.Nome);
Exibir(minimoOrdeanado);

Console.WriteLine();
Console.WriteLine("\n Produtos ordenados por categoria e nome:");
var produtosOrdenadosCategoriaeNome = listaProdutos.OrderBy(p => p.Categoria).ThenBy(p => p.Nome); 
Exibir(produtosOrdenadosCategoriaeNome);


// sempre que usamos uma ordenação o tipo muda de IEnumerable para IOrderedEnumerable
// Select -> faz uma transformação com base em nossa expressão o tipo muda com base em qual dados iremos selecionar,
// se selecionarmos uma string o tipo muda para string, se seleciornamos int a expressão muda para int.
Console.WriteLine();
Console.WriteLine("\n Lista dos nomes dos produtos ordenados");
var nomesProdutosOrdenados = listaProdutos.Select(p => p.Nome).OrderBy(n => n);
ExibirIOredered(nomesProdutosOrdenados);

//Com Select eu tambem posso criar um tipo anonimo, podendo criar um novo tipo com valores filtrados e tambem modificados como abaixo
// Partindo de uma coleção, manipulando e obtendo outra coleção com valores filtrados e modificados
// A tranformação ocorre por meio do tempo de compilação
Console.WriteLine();
Console.WriteLine("Produtos com valor menor que R$ 500 com aumento de 10% ordenados por nome");
var resultado = listaProdutos.Where(p => p.Preco < 500)
    .OrderBy(p => p.Nome).Select(p => new
    {
        NomeProduto = p.Nome.ToUpper(),
        PrecoComAumento = p.Preco * 1.1
    });

foreach (var value in resultado)
{
    Console.WriteLine($"{value.NomeProduto}, \t Preço com aumento: {value.PrecoComAumento:C2}");
}


//exemplo com desconto
Console.WriteLine();
Console.WriteLine("Produtos com valor maior que R$2000 com desconto de 20% ordenados por nome");
var resultado1 = listaProdutos.Where(p => p.Preco > 2000)
    .OrderBy(p => p.Nome).Select(p => new
    {
        NomeProduto = p.Nome.ToUpper(),
        PrecoComDesconto = p.Preco * 0.8
    });

foreach (var value in resultado1)
{
    Console.WriteLine($"{value.NomeProduto}, \t Preço com aumento: {value.PrecoComDesconto:C2}");
}

Console.WriteLine();
//Calculos de somatória, média e contagem
//media
Console.WriteLine("Valor medio de produtos eletrônicos");
double mediaPrecoEletronicos = listaProdutos.Where(p => p.Categoria == "Eletrônicos").
    Average(p => p.Preco);
Console.WriteLine($"Média dos Preços{mediaPrecoEletronicos:C2}");

Console.WriteLine();

//Calculos de somatória, média e contagem
//somatoria
Console.WriteLine("Valor total dos produtos em estoque");
double valorTotalEstoque = listaProdutos.Where(p => p.Estoque > 0).Sum(p => p.Preco * p.Estoque);
Console.WriteLine($"Valor total{valorTotalEstoque:C2}");

Console.WriteLine();


//Contagem
// posso usar where, mas a ide sugere usar direto o COUNT para contar e filtrar
Console.WriteLine("Quantidade de produtos com estoque minimo (<10)");
int estoqueMinimo = 10;
int produtosEstoqueBaixo = listaProdutos.Count(p => p.Estoque < 10);
Console.WriteLine(produtosEstoqueBaixo);


Console.ReadKey();




// C = especificador de formato para moeda
// 2 = número de casa decimais a serem exibidas

static void Exibir(IEnumerable<Produto> collection)
{
    foreach (var value in collection)
    {
        Console.WriteLine($"{value.Nome} \t {value.Preco:C2} Estoque:{value.Estoque} Categoria:{value.Categoria}");
    }
}

static void ExibirIOredered(IOrderedEnumerable<string?> collection)
{
    foreach (var value in collection)
    {
        Console.WriteLine(value);
    }
}