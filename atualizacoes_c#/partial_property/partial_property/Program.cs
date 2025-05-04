using partial_property;

Produto produto = new();

produto.Id = 1;
produto.Nome = "Caderno";
produto.Preco = 10.00M;

Console.WriteLine($"O valor do produto {produto.Nome} com imposto é R${produto.ValorComImposto}");