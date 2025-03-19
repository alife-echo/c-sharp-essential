
using operadoresProjecao;

Console.WriteLine("Selecionando todos os dados");
// seleciona todos os dados originais
IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList(); // cria a consulta e retorna os dados imediatamente

foreach (var aluno in alunos)
    Console.WriteLine($"{aluno.Nome} : {aluno.Idade}");




Console.WriteLine("Selecionando apenas o nome");
// seleciona apenas o nome ou apenas uma unica propriedade
// cria a consulta mas não retorna os dados
IEnumerable<string> nomesAlunos = FonteDados.GetAlunos().Select(n => n.Nome);

foreach (var nomeAluno in nomesAlunos)
    Console.WriteLine($"{nomeAluno}");





Console.WriteLine("Seleção porem criando um novo formato do mesmo tipo");
// Selecioa uma novo formato do mesmo tipo da fonte de dados obtendo o Nome e Idade
IEnumerable<Aluno> lista = FonteDados.GetAlunos().Select(a => new Aluno()
                                                        {
                                                            Nome = a.Nome,
                                                            Idade = a.Idade
                                                        }).ToList();
foreach (var novoAluno in lista)
    Console.WriteLine($"{novoAluno.Nome} : {novoAluno.Idade}");







// criando uma projeção para o tipo anonimo
// podemos ter um novo formato de dados sem especificar o tipo de dado usando tipos anonimos
Console.WriteLine("Selecionando com um novo formato de dados com tipos anonimos");
var alunosTipoAnonimo = FonteDados.GetAlunos().Select(a => new
{
    NomeAluno = a.Nome,
    IdadeAluno = a.Idade,
    NotaAluno = a.Nota
}).ToList();

foreach(var alunoTipoAnonimo in alunosTipoAnonimo)
{
    Console.WriteLine($"{alunoTipoAnonimo.NomeAluno} : {alunoTipoAnonimo.IdadeAluno}");
}





Console.WriteLine("Selecionando e criando um novo formato com realização de calculos");
// podemos tambem criar um novo formato com realização de calculos
var funcionarios = FonteDados.GetFuncionarios().Select(p => new
{
    NomeFuncionario = p.Nome,
    IdadeFuncionario = p.Idade,
    SalarioAnual = p.Salario * 12
}).ToList();

foreach (var funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.NomeFuncionario} : {funcionario.IdadeFuncionario} : {funcionario.SalarioAnual:c}");
}




//transformando lista de lista para uma lista com SelectMany
Console.WriteLine("Trabalhando com selectMany");
List<List<int>> listas = new List<List<int>>
{
    new List<int> {1,2,3},
    new List<int> {12},
    new List<int> {5,6,5,7},
    new List<int> {10,12,12,13}
};
// transformando a lista de lista em uma unica lista
// Distinct() --> elimina valores repetidos
IEnumerable<int> resultado = listas.SelectMany(lista => lista.Distinct());

foreach(var i in resultado)
    Console.Write($"{i} ");







// abordagem select
Console.WriteLine();
Console.WriteLine("Exibição com Select");
IEnumerable<List<string>> cursos = FonteDados.GetAlunos().Select(c => c.Cursos);

foreach(List<string> listaCurso in cursos)
{
    foreach(string curso in listaCurso)
    {
        Console.WriteLine($"{curso}");
    }
    Console.WriteLine();
}

Console.WriteLine("Exibição com SelectMany");
// abordagem select many
IEnumerable<string> cursosMany = FonteDados.GetAlunos().SelectMany(c => c.Cursos);

foreach (string curso in cursosMany)
{
    Console.WriteLine($"{curso}");
}


// usaremos o select many quando tiver estruturas de dados complexas e numerosas, reduzindo suas estruturas para uma unica
// não precisando de encadeamento de varios foreach para acessar os valores
// projeta os elementos de uma sequencia para um IEnumerable<T>