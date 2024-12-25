
namespace exercicioHeranca;

class ContaPoupanca : Conta
{

    const decimal JUROS = 0.005m;
    public override void Depositar(decimal valor)
    {
        base.Depositar(valor);
        Saldo_Conta += Saldo_Conta * JUROS;
    }
    public override void ExibirSaldo()
    {
        Console.WriteLine($"--- {Nome_Cliente} - Saldo Reajustado:{Saldo_Conta}R$");
    }
    public ContaPoupanca(string Nome, int Numero) : base(Nome, Numero) { }
}