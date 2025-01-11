namespace exerciseEventsHandler;

public class ProdutoEventArgs : EventArgs
{
    public string? Name {get; set;}
    public int Quantity {get; set;}
}