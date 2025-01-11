namespace exerciseEventsHandler;

public class Estoque
{
    public event EventHandler<ProdutoEventArgs>? OnProdutoAdicionado;

    public void AdicionarProduto(string? nome, int quantidade)
    {
        if(string.IsNullOrEmpty(nome))
            throw new ArgumentException("O nome do produto não pode ser vazio.",nameof(nome));
        if(quantidade <= 0)
            throw new ArgumentException("A quantidade deve ser maior que zero.",nameof(quantidade));
        if (OnProdutoAdicionado != null)
        {
            OnProdutoAdicionado(this,new ProdutoEventArgs{Name = nome,Quantity = quantidade});
        }
    }
}