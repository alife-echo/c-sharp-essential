namespace Events;


delegate void PedidoEventHandler(); // Cria um delegate PedidoEventHandler para o tipo de evento

internal class Pedido
{
    public event PedidoEventHandler? OnCriarPedido; // Declara o evento OnCriarPedido associado ao delegate definido
    
    // os manipuladores de evento(subscriber) devem ter a assinatura correspondente ao delegate definido

    public void CriarPedido()
    {
        Console.WriteLine("Pedido criado ! ! !");
        
        if (OnCriarPedido != null) // antes de gerar um evento verificar se ele não é null
        {
            OnCriarPedido(); // a sintaxe para chamar um evento e a mesma para chamar um metodo
        }
    }
}