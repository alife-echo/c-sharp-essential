
namespace pooExercicios;
public class Conta
{
    public int NumeroConta { get; set; }
    public string? NomeTitular { get; set; }    
    public float Saldo { get; set; }
    public string? Agencia { get; set; }
    public string? TipoConta { get; set; }


    public void Comprovante()
    {
        Console.WriteLine($"Numero Conta:{NumeroConta}\nNome Titular:{NomeTitular}\nSaldo:{Saldo}\nAgencia:{Agencia}\nTipo conta:{TipoConta}");
    }

    public virtual void ExibirSaldo()
    {
        Console.WriteLine($"Seu Saldo:${Saldo}");
    }
}

