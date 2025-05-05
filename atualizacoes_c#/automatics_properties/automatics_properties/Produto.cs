namespace automatics_properties;

public class Produto
{
    public decimal Preco
    {
        get; 
        set => field  = value < 0 ? 
            throw new ArgumentException("O preço não pode ser negativo") : value;
    }
}