
using exceptions_customized;

var conta1 = new Conta(001, "Álife", 4999m);
try
{
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(1);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
    conta1.Sacar(100000);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.HelpLink);
}


Console.ReadKey();

public class Conta
{
    
    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }
    
    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Deposito de {valor}R$");
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        if (Saldo < valor)
            throw new SaldoInsuficienteException(valor,Saldo);
        
        Saldo -= valor;
        return Saldo;
    }

    public override string ToString()
    {
        return $"Conta : {Numero} : Titular : {Titular}, Saldo : {Saldo}R$";
    }
}

