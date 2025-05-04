using System.Threading;
namespace lock_object_9;

public class ContaBancaria
{
    // um objeto Lock privado é criado para proteger o acesso ao saldo da conta
    private readonly Lock _lock = new();
    public decimal Saldo {get;private set;}

    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

  
    public void Sacar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("Valor de saque deve ser positivo");
        
        // O método EnterScope e chamado para garantir o bloqueio quando o metodo Sacar for chamado
        // cria um escopo de execução exclusivo e garante a liberação automatica do bloqueio
        // crio um escopo onde na quando a thread executar o codigo na seção critica, os recursos sejam liberados quando terminar
        using (_lock.EnterScope())
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso. Novo saldo:{Saldo}");
            }
            else
                Console.WriteLine("Saldo insuficiente");

        }
    }
    
    // sem lock
/*
    public void Sacar(decimal valor)
    {
        if(valor <= 0)
            throw new ArgumentException("Valor de saque deve ser positivo");

        if (Saldo >= valor)
        {
            Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} Verificando Saldo : {Saldo}");
            Thread.Sleep(80);
            Saldo -= valor;
            Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} realizou o saque de {valor} novo saldo :{Saldo}");
        }
        else
            Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} --TENTOU-- saque de {valor} mas saldo é : {Saldo}");
    }*/
}