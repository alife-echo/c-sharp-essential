
using System.Collections;

namespace PessoaExercicioArrays;
public class Pessoa
{

    private string? nome;
    private int idade;

    public string Nome { get { return String.IsNullOrEmpty(nome) ? "" : nome; } set { nome = value; } }
    public int Idade { get { return idade; } set { if (!(idade < 0)) { idade = value; } } }

    
    public Pessoa(string nome, int idade)    
    {
        this.Nome = nome;
        this.Idade = idade;
    }
    public override string ToString()
    {
        return Nome + "," +  this.Idade;
    }
 
}
