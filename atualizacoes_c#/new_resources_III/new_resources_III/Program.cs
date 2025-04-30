using new_resources_III;

// inválidos

/*
Pessoa maria = new();

Pessoa manoel = new Pessoa()
{
    Nome = "Manoel",
};

// válidos
Pessoa alife = new Pessoa("Álife",25);*/


// forma correta
/*
var p1 = new Pessoa();
Console.WriteLine(p1.GetIdentidade());*/

// Nome = null, Idade = 0
var p = new Pessoa(); 

List<Aluno> alunos = new List<Aluno>
{
    new Aluno { Nome = "Ana", Perfil = "Estudiosa", Nota = 9.5 },
    new Aluno { Nome = "Carlos", Perfil = "Inativo", Nota = 8.7 },
    new Aluno { Nome = "Beatriz", Perfil = "Disciplinada", Nota = 9.0 }
};

Console.WriteLine($"Alunos ativos são : " +
                  $"{string.Join(", ",alunos.Where(a => a.Perfil != "Inativo")
                      .Select(n => n.Nome)
                      .OrderBy(n => n)
                    )}");