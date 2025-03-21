using set_operationsII;

var fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
var fonte2 = new List<int>() {1,3,5,8,9,10};

var resultado = fonte1.Intersect(fonte2).ToList();
Exibir(resultado);

string[] font1Country = { "Brasil", "USA", "UK", "Argentina", "China" };
string[] font2Country = { "Brasil", "uk", "Argentina", "França", "Japão" };
var resultadoCidades = font1Country.Intersect(font2Country,StringComparer.OrdinalIgnoreCase).ToList();
Exibir(resultadoCidades);

var fontTurmaA = FonteDeDados.GetTurmaA();
var fontTurmaB = FonteDeDados.GetTurmaB();

IEnumerable<Aluno> alunosComMesmoAnoNascimento = fontTurmaA.IntersectBy(fontTurmaB.Select(b => b.Nascimento.Year), a => a.Nascimento.Year).ToList();
Console.WriteLine("Aluno com mesmo ano de nascimento");

foreach (var alunoMesmaData in alunosComMesmoAnoNascimento)
{
    Console.WriteLine($"{alunoMesmaData.Nome} : {alunoMesmaData.Idade} : {alunoMesmaData.Nascimento}");
}


// uso normal da operação Union
var resultadoUnion = fonte1.Union(fonte2);
Exibir(resultadoUnion);

// union com equality comparer para ignorar o case sensitive
var unionSemCaseSensitive = font1Country.Union(font2Country, StringComparer.OrdinalIgnoreCase);
Exibir(unionSemCaseSensitive);

// no primeiro argumento eu apenas passo a segunda fonte de dados e no terceiro argumento
var todosAlunosSemRepeticao = fontTurmaA.UnionBy(fontTurmaB, p => p.Nome);

foreach (var alunoNomeUnico in todosAlunosSemRepeticao)
{
    Console.WriteLine($"{alunoNomeUnico.Nome} : {alunoNomeUnico.Idade} : {alunoNomeUnico.Nascimento}");
}

static void Exibir<T>(IEnumerable<T> collection)
{
    foreach (var value in collection)
    {
        Console.Write($"{value} ");
    }
    Console.WriteLine();
}

