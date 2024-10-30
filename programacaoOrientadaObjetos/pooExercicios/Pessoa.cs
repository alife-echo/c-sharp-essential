
namespace pooExercicios;

public class Pessoa
{
    private string? nome;
    public string Nome
    {
        get
        {
            return !String.IsNullOrEmpty(nome) ? nome : "Campo Vazio";

        }
        set { nome = value; }
    }

    public Pessoa(string Nome)
    {
        this.Nome = Nome;
    }

    public override string ToString()
    {
        return $"Olá meu nome é : {Nome}";
    }

}

