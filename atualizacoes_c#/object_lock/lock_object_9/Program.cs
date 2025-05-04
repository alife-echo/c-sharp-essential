using lock_object_9;

var conta = new ContaBancaria(100);

// 10 usuarios efetuzando 20 reais de saque
// quando não existir mais saldo
// uma mensagem de saldo insuficiente sera mostrada
Parallel.For(0,10, _ =>
{
    conta.Sacar(20);
}) ;

Console.ReadLine();