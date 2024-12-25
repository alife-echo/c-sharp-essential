using PessoaExercicioArrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArrayListArrayList;

public class Produto
{
    private string? nome;

    private  double  preco;

    public string Nome
    {
        get
        {
            return String.IsNullOrEmpty(nome) ? "" : nome;
        }
        set
        {
            if (nome != "")
            {
                nome = value;
            }
        }
    }

    public double Preco
    {
        get
        {
            return preco;
        }
        set
        {
            if (!(preco < 0))
            {
                preco = value;
            }
        }
    }

    public Produto(string Nome,double Preco)
    {
        this.Nome = Nome;
        this.Preco = Preco;
    }
    public static void ExibirDadosProduto(List<Produto> produtos)
    {
        double somaTotal = 0;
        Console.WriteLine("-------------- Produtos --------------");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"{produto.Nome},{produto.Preco}$,{produto.GetType()}");
            somaTotal+= produto.Preco;
            
        }
        Console.WriteLine($"Soma Total:{somaTotal}");
        Console.WriteLine($"Media:{somaTotal / produtos.Count}");
        Console.WriteLine($"Quatidade Produtos:{produtos.Count}");
    }


}
