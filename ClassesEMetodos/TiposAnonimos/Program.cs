// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tipos Anonimos");


var aluno = new
{
    Nome = "Maria",
    Idade = 42
};

Console.WriteLine(aluno.GetType().ToString());

Console.WriteLine($"{aluno.Nome} {aluno.Idade}");


var aluno2 = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "jairo@email.com",
    Endereco = new {Id = 1, Cidade = "Santos", Pais = "Brasil"}
};
Console.WriteLine(aluno2.Endereco.Cidade);
var alunos = new[]
{
        new {Id = 1, Cidade = "Maria", Email = "maria@email.com"},
        new {Id = 2, Cidade = "Sonia", Email = "sonia@email.com"},
        new {Id = 3, Cidade = "Bruno", Email = "bruno@email.com"}

};
Console.WriteLine(alunos.GetType().ToString());
Console.WriteLine(alunos[0].Email);