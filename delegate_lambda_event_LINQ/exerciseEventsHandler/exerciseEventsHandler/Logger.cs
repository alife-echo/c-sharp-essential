namespace exerciseEventsHandler;

public class Logger
{
    public static void Registrar(object? sender, ProdutoEventArgs e)
    {
        Console.WriteLine($"Produto {e.Name} registrado no estoque");
    }
}