namespace EventHandler_EventHandler_TeventArgs;

public class Sms
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviado sms para {e.Telefone}");
    }
}