namespace exerciseEventsHandler;

public class Notifier
{
    public static void Notificar(object? sender, ProdutoEventArgs e)
    {
        Console.WriteLine($"Notificação enviada para o gerente: Produto {e.Name}, Quantidade {e.Quantity}");
    }
}