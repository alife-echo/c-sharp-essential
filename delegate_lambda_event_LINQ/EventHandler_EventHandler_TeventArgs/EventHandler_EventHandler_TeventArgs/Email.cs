namespace EventHandler_EventHandler_TeventArgs;

public class Email
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviado email para {e.Email}");
    }
}