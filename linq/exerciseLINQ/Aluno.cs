

namespace exerciseLINQ;
public class Aluno
{
    public string Nome { get; set; } = string.Empty;

    public  List<double>? Notas { get; set; }

    public static List<Aluno> GetAlunos()
    {
        var alunos = new List<Aluno>()
        {
            new Aluno { Nome = "Ana", Notas = new List<double> { 8.5, 7.0, 6.5 } },
            new Aluno { Nome = "Bruno", Notas = new List<double> { 9.0, 8.5, 10.0 } },
            new Aluno { Nome = "Carla", Notas = new List<double> { 6.0, 5.5, 7.0 } },
            new Aluno { Nome = "Diego", Notas = new List<double> { 4.0, 6.0, 5.0 } },
            new Aluno { Nome = "Eduarda", Notas = new List<double> { 7.5, 7.0, 8.0 } },
            new Aluno { Nome = "Felipe", Notas = new List<double> { 9.0, 9.5, 8.5 } },
            new Aluno { Nome = "Gabriela", Notas = new List<double> { 6.5, 6.0, 6.8 } },
            new Aluno { Nome = "Henrique", Notas = new List<double> { 5.0, 4.5, 5.5 } },
            new Aluno { Nome = "Isabela", Notas = new List<double> { 8.0, 7.5, 9.0 } },
            new Aluno { Nome = "João", Notas = new List<double> { 10.0, 9.5, 10.0 } }
        };
        return alunos;
    }
}

