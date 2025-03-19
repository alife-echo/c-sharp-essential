using operadoresProjecao;

class FonteDados
{
    public static List<int> GetNumeros()
    {
        List<int> numeros = new List<int>()
        {
            1,2,4,8,16,32,64,128,256,512
        };
        return numeros;
    }

    public static List<int> GetListaNegra()
    {
        List<int> numeros = new List<int>()
        {
            16, 128, 512
        };

        return numeros;
    }

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno(){Nome = "Maria", Idade=42 , Cursos = new List<string>() {"VB.NET","ASP.NET"} },
            new Aluno(){Nome = "Manoel", Idade=34 , Cursos = new List<string>() {"C#","EF Core"} },
            new Aluno(){Nome = "Amanda", Idade=21, Cursos = new List<string>() {"Java","Node"} },
            new Aluno(){Nome = "Carlos", Idade=18 , Cursos = new List<string>() {"C++","MongoDB","node"} },
            new Aluno(){Nome = "Alicia", Idade=15 , Cursos = new List<string>() {"Typescript","React","Node"} },
        };

        return alunos;
    }

    public static List<Funcionario> GetFuncionarios()
    {
        List<Funcionario> func = new()
        {
            new Funcionario(){Nome = "Maria", Idade=42 , Salario = 3290.55m},
            new Funcionario(){Nome = "Manoel", Idade=34 , Salario = 4125.45m},
            new Funcionario(){Nome = "Amanda", Idade=21 , Salario = 5123.99m},
            new Funcionario(){Nome = "Carlos", Idade=18 , Salario = 6200.50m},
            new Funcionario(){Nome = "Alicia", Idade=15 , Salario = 4099.11m},
        };

        return func;
    }
}
