namespace EventHandler_EventHandler_TeventArgs;

internal class Pedido
{
    public event EventHandler<PedidoEventArgs>? OnCriarPedido; 
    
    public void CriarPedido(string? email, string? fone)
    {
        Console.WriteLine("Pedido criado ! ! !");
        
        if (OnCriarPedido != null) 
        {
            
            OnCriarPedido(this, new PedidoEventArgs {Email = email,Telefone = fone}); 
        }
    }
}
