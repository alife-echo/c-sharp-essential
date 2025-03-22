

namespace order_operations;
class FonteDeDados
{
    public static List<Aluno> GetTurmaA()
    {
        List<Aluno> alunos = new()
    {
        new Aluno() { Nome = "Maria", Idade = 36, Nascimento = new DateTime(2001, 6, 11)},
        new Aluno() { Nome = "Manoel", Idade = 33, Nascimento = new DateTime(2000, 2, 10)},
        new Aluno() { Nome = "Amanda", Idade = 21, Nascimento = new DateTime(1986, 9, 30)},
        new Aluno() { Nome = "Carlos", Idade = 18, Nascimento = new DateTime(1999, 10, 11)},
        new Aluno() { Nome = "Jaime", Idade = 36, Nascimento = new DateTime(1988, 9, 15)}
    };
        return alunos;
    }
}

