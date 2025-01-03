namespace ExceptionsLastExersice;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() {}
    public SaldoInsuficienteException(string message) : base(message) {}
    public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException) {}

    public override string Message
    {
        get => "Exception : O valor de saque é maior que o saldo na conta";
    }
}