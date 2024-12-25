

namespace exercicioHeranca;

class ContaInvestimento : Conta
{
    const decimal TAXA_INVESTIMENTO = 0.009m;

    const decimal IMPOSTO = 0.001m;

    public override void Depositar(decimal valor)
    {
        base.Depositar(valor);
        Saldo_Conta += Saldo_Conta * TAXA_INVESTIMENTO;
    }
    public override void Sacar(decimal valor)
    {
        if (Saldo_Conta >= valor)
        {
            base.Sacar(valor);
            Saldo_Conta -= Saldo_Conta * IMPOSTO;
        }
    }
    public override void ExibirSaldo()
    {
        Console.WriteLine($"--- {Nome_Cliente} - Saldo Investimento Reajustado - {Math.Round(Saldo_Conta)}R$");
    }
    public ContaInvestimento(string Nome, int Numero) : base(Nome, Numero) { }
}