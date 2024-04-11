// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio Propriedades");
Produto p1 = new Produto();
p1.Nome = "Caderno Espiral";
p1.Preco = 10.00;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();

public class Produto
{
    private string? nome;
    public string? Nome 
    { 
        get {return nome?.ToUpper();}
        set {nome = value;}
    }
    private double preco;
    public double Preco 
    { 
        get { return preco; }
        set 
        {
            if (value < 5.00)
            {
                preco = 5.00;
            }
            else
            {
                preco = value;
            }
        }
    }
    private double desconto = 0.25;
    public double Desconto { get { return desconto; } }

    public double PrecoFinal {
        get { return preco - preco * desconto;}
    }
    private int estoqueminimo;
    public int EstoqueMinimo {
            set { estoqueminimo = value; } 
    }

    public void Exibir()
    {
        Console.WriteLine(
            $"{Nome}\n{Preco.ToString("c")}\n{Desconto * 100}%" +
            $"\n{PrecoFinal.ToString("c")}\n{estoqueminimo}"
            );
    }

}
