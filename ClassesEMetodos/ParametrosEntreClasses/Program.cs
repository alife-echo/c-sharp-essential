// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Parâmetros entre classes!");

Aluno aluno1 = new Aluno();
aluno1.Consultar();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        var aluno = new Aluno();

        Console.WriteLine("Nome:");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Idade:");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo:");
        aluno.Sexo = Console.ReadLine();
        Console.WriteLine("Aprovado (S)im (N)ão : ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new();
        curso.Resultado(aluno);
    }
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\n O aluno:{aluno.Nome} sexo:{aluno.Sexo}  com {aluno.Idade} anos");
        if(aluno.Aprovado?.ToUpper() == "S")
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}

