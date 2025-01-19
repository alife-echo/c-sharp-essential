using linq_queries_III;

var listaProdutos = Produto.GetProdutos();

//quando uso um select um novo tipo de dados surge respeitando as manipulações anteriores
var produtosPorCategoria = listaProdutos.
     GroupBy(p => p.Categoria). // agrupo por categoria
     OrderBy(c => c.Key) // // ordeno por categoria
    .Select(g => new // faço uma nova manipulação criando um tipo anonimo
{ 
        Categoria = g.Key, //incluo as minhas categorias ja manipuladas
        Produtos = g.OrderBy(p => p.Nome)// Ordeno pelo nome, fazendo uma nova manipulação e selecionando valores especificos
            .Select(p => new
            {
                Nome = p.Nome,
                Preco = p.Preco,
                Estoque= p.Estoque
            })
});

foreach (var grupo in produtosPorCategoria )
{
    Console.WriteLine("--------------------------------");
    Console.WriteLine(grupo.Categoria);

    foreach (var produto in grupo.Produtos)
    {
        Console.WriteLine($" {produto.Nome} \t{produto.Preco:C2} \t{produto.Estoque}");
    }
}

/*
foreach (var grupo in produtosPorCategoria )
{
    Console.WriteLine("--------------------------------");
    Console.WriteLine(grupo.Key + " : " + grupo.Count());

    foreach (var produto in grupo)
    {
        Console.WriteLine($" {produto.Nome} \t{produto.Preco:C2} \t{produto.Estoque}");
    }
}*/