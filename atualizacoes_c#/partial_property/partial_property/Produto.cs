namespace partial_property;

public partial class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    
    //Propriedade parcial para calculo de imposto
    public partial decimal ValorComImposto { get; }
}