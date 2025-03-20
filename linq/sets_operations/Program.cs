
using sets_operations;

var idades = new[] {30,33,35,36,40,30,33,36,30,40};


//execução imediata
var idadesDistintasImediata = idades.Distinct().ToArray();
var idadesDistintasImediata2 = idades.Distinct().ToList();


// execução adiada
var idadesDistintas = idades.Distinct();

foreach(var i in idadesDistintas)
{
    Console.WriteLine(i);
}


string[] nomes = {"Paulo","MARIA","paulo","Amanda","maria","Amanda"};

// ao executar esse codigo, podemos perceber a lista não elimina as duplicadas,devido o Distinct ser case sensitive
var namesDistincWithCaseSensitive = nomes.Distinct();

// no codigo abaixo sobrecarregado o metodo podemos remover seu case sensitive e eliminar as duplicadas
var namesDistinc = nomes.Distinct(StringComparer.OrdinalIgnoreCase); // versão sobrecarregada que usa IEqualityComparer como argumento
foreach(var nome in namesDistinc)
{
    Console.Write($"{nome} ");
}

IEnumerable<Aluno> alunos = FonteDados.GetAlunos().DistinctBy(a => a.Idade);
foreach (var aluno in alunos)
{
    Console.WriteLine($"{aluno.Nome} : {aluno.Idade} ");
}









// Except / ExceptBy
List<int> font1 = new List<int>() {1,2,3,4,5,6};
List<int> font2 = new List<int>() {1,3,5,8,9,10};

// retorna os valores que estão presentes na primeira fonte de dados mas que não estão na segunda fonte
var resultado = font1.Except(font2).ToList();
foreach(var numero in resultado)
{
    Console.Write($"{numero} ");
}

Console.WriteLine();


string[] font1Country = { "Brasil", "USA", "UK", "Argentina", "China" };
string[] font2Country = { "Brasil", "uk", "Argentina", "França", "Japão" };

// retornando valores que estão presentes no pais 1 mas não no pais 2 e ignorando o case sensitive
var resultadoCountry = font1Country.Except(font2Country, StringComparer.OrdinalIgnoreCase).ToList();

foreach(var country in resultadoCountry)
{
    Console.Write($"{country} ");
}

Console.WriteLine();

Console.WriteLine("Alunos aprovados");
var alunosSituacao = FonteDados.GetAlunos();

string[] alunosReprovados = { "Bob", "Nargas", "Jurandi" };
// retornando os alunos aprovados fazendo um ExceptBy, passando a segunda fonte e depois a expressão lambda especificando a propriedade que sera analisada
var alunosAprovaodos = alunosSituacao.ExceptBy(alunosReprovados, a => a.Nome);

foreach(var aprovados in alunosAprovaodos)
{
    Console.WriteLine($"{aprovados.Nome} : {aprovados.Idade} ");
}
