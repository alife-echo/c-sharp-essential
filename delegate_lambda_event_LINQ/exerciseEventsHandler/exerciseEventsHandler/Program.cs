

using exerciseEventsHandler;

var estoque = new Estoque();

estoque.OnProdutoAdicionado += Logger.Registrar;
estoque.OnProdutoAdicionado += Notifier.Notificar;

try
{
    estoque.AdicionarProduto("Iphone", 1);
    estoque.AdicionarProduto("MackBook", 1);
    estoque.AdicionarProduto("Camisa", 3);
    estoque.AdicionarProduto("Calça", 2);
    estoque.AdicionarProduto("", 0);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
