
namespace pooExercicios;
public class Aluno : Pessoa
{
    public Aluno(string Nome) : base(Nome) { }

    public void Estudar()
    {
        Console.WriteLine($"O aluno {Nome} esta estudando....");
    }
}

