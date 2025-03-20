
namespace sets_operations;
class FonteDados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno(){Nome = "Maria", Idade=40 , Cursos = new List<string>() {"VB.NET","ASP.NET"} },
            new Aluno(){Nome = "Manoel", Idade=34 , Cursos = new List<string>() {"C#","EF Core"} },
            new Aluno(){Nome = "Amanda", Idade=20, Cursos = new List<string>() {"Java","Node"} },
            new Aluno(){Nome = "Carlos", Idade=18 , Cursos = new List<string>() {"C++","MongoDB","node"} },
            new Aluno(){Nome = "Bob", Idade=15 , Cursos = new List<string>() {"Typescript","React","Node"} },
            new Aluno(){Nome = "Regis", Idade=15 , Cursos = new List<string>() {"Typescript","React","Node"} },
            new Aluno(){Nome = "Nargas", Idade=18 , Cursos = new List<string>() {"Typescript","React","Node"} },
            new Aluno(){Nome = "Jurandi", Idade=20 , Cursos = new List<string>() {"Typescript","React","Node"} },
        };

        return alunos;
    }
}

