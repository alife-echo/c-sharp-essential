// See https://aka.ms/new-console-template for more information
using exercicioHeranca;
Console.WriteLine("Hello, World!");

Conta c1 = new Conta("Álife",2017);
ContaPoupanca cp1 = new ContaPoupanca("Reginaldo",2018);
ContaInvestimento ci1 = new ContaInvestimento("Marley",2019);

c1.Depositar(1000);
cp1.Depositar(1000);
ci1.Depositar(1000);

c1.Sacar(100);
cp1.Sacar(100);
ci1.Sacar(100);

c1.ExibirSaldo();
cp1.ExibirSaldo();
ci1.ExibirSaldo();


c1.Sacar(2000);
cp1.Sacar(2000);
ci1.Sacar(2000);

c1.ExibirSaldo();
cp1.ExibirSaldo();
ci1.ExibirSaldo();


public class Conta
{
    private string? nome_cliente;

    private int numero_cliente;

    private decimal saldo_conta = 0;

    public virtual decimal  Saldo_Conta
    {
        get => saldo_conta;
       protected set
        {
            if (!(saldo_conta < 0))
            {
                saldo_conta = value;
            }
        }
    }

    public virtual string? Nome_Cliente
    {
       get => nome_cliente;
       private set
        {
            if (!String.IsNullOrEmpty(value))
            {
                nome_cliente = value;
            }
        }
    }
    public virtual int Numero_Cliente
    {
      get => numero_cliente;
    }

  public Conta(){}
  public  Conta (string? Nome, int Numero)
    {
        this.Nome_Cliente = Nome ?? throw new ArgumentNullException(nameof(Nome));
        numero_cliente = Numero > 0 ? Numero : throw new ArgumentException("Número do Cliente inválido");
    }

    public virtual void Depositar(decimal valor)
    {
        Saldo_Conta += valor;
    }
    public virtual void ExibirSaldo()
    {
        Console.WriteLine($"--- {Nome_Cliente} - Saldo:{Saldo_Conta}R$");
    }
    public virtual void Sacar(decimal valor)
    {
        if (Saldo_Conta >= valor)
        {
            Saldo_Conta -= valor;
            Console.WriteLine("Saque Efetuado Com Sucesso");
        }
    }

}


