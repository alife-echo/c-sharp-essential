

using group_operation;
using System.Text.RegularExpressions;

List<Aluno> alunos = new()
{
    new Aluno() {AlunoId = 1, Curso = "Fisica", Nome = "Vitor", Sexo = 'M',Idade = 18},
    new Aluno() {AlunoId = 2, Curso = "Quimica", Nome = "Jorge", Sexo = 'M',Idade = 21},
    new Aluno() {AlunoId = 3, Curso = "Moda", Nome = "Bianca", Sexo = 'F',Idade = 18},
    new Aluno() {AlunoId = 4, Curso = "Moda", Nome = "Amanda", Sexo = 'F',Idade = 21},
};


// no caso abaixo estou agrupamanto os dados pela idade
// ou seja sera criado um grupo com os dados das pessoas com 18 anos
// e depois outro grupo com os dados das pessoas com 21 anos
// depois ordeno pela idade
//var grupos = alunos.GroupBy(a => a.Idade).OrderBy(c => c.Key);

/*
 * 
 * foreach (var grupo in grupos)
{
    // a chave são as idades e o numeros de vezes que ela esta na lista
    Console.WriteLine($"Idade:{grupo.Key}  alunos:{grupo.Count()}");

    // mostro os dados agrupados pelas chaves, que nesse caso são as idades
    foreach(var aluno in grupo)
    {
        Console.WriteLine($"\t{aluno.Nome},{aluno.Curso},{aluno.Idade},{aluno.Sexo}");
    }
}*/








// agrupando por sexo, ou seja, meninos com seus dados e meninas com seus dados ambos em grupos diferentes
var grupoSexo = alunos.GroupBy(a => a.Sexo);

// minha solução
//var grupos = alunos.GroupBy(a => a.Curso).SelectMany(a => a).OrderBy(a => a.Nome);



//solução aula
// agrupo por curso, ordeno pelo curso, crio um novo formato de dados em que terei a chave que são os cursos e os alunos sendo os alunos ordenados por nome
var grupos = alunos.GroupBy(a => a.Curso).OrderBy(c => c.Key).Select(std => new
{
    Key = std.Key,
    Alunos = std.OrderBy(a => a.Nome)
});
foreach(var grupo in grupos)
{

    Console.WriteLine($"Cursos:{grupo.Key}  alunos:{grupo.Alunos.Count()}");

    foreach (var aluno in grupo.Alunos)
    {
        Console.WriteLine($"\t{aluno.Nome},{aluno.Curso},{aluno.Idade},{aluno.Sexo}");
    }
}


// multiplas chaves
/*
utilizo um tipo anônimo para especificar as chaves , utilizo os métodos OrderByDescending e ThenBy para ordenação das chaves, e   
depois crio um novo formato com tipo anônimo com os campos como : Curso,Sexo e Alunos ordenados por nome 
 */
Console.WriteLine();
Console.WriteLine();
var alunosPorSexoeCurso = alunos.GroupBy(x => new { x.Curso, x.Sexo })
                          .OrderByDescending(g => g.Key.Curso)
                          .ThenBy(g => g.Key.Sexo)
                          .Select(g => new
                          {
                              Curso = g.Key.Curso,
                              Sexo = g.Key.Sexo,
                              Alunos = g.OrderBy(a => a.Nome)
                          });

foreach (var grupo in alunosPorSexoeCurso)
{

    Console.WriteLine($"{grupo.Curso} {grupo.Sexo}  alunos:{grupo.Alunos.Count()}");

    foreach (var aluno in grupo.Alunos)
    {
        Console.WriteLine($"\t{aluno.Nome},{aluno.Idade}");
    }
}


Console.WriteLine();
Console.WriteLine();
// ToLookUp
var gruposLookUp = alunos.ToLookup(a => a.Curso);

foreach (var grupo in gruposLookUp)
{

    Console.WriteLine($"{grupo.Key} ({grupo.Count()})");

    foreach (var aluno in grupo)
    {
        Console.WriteLine($"\t{aluno.Nome},{aluno.Idade} {aluno.Sexo}");
    }
}
