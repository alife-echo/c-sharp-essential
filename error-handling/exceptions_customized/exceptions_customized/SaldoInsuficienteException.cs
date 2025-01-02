namespace exceptions_customized;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException()
    {
    }

    public SaldoInsuficienteException(string? message) : base(message)
    {
    }

    public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public SaldoInsuficienteException(decimal saque, decimal saldo):base($"\nException: valor de saque {saque}R$ é superior ao saldo {saldo}R$")
    {
        
    }

    public override string Message
    {
        get => "Não existe saldo suficiente para o valor do saque";
    }

    public override string HelpLink
    {
        get => "https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/exceptions/exception-handling";
    }
}