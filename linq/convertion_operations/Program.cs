
using convertion_operations;

// ToList
Console.WriteLine("ToList");
Console.WriteLine();
string[] paises = { "US", "UK", "India", "Russia", "China", "Brasil", "Peru" };

var resultado = paises.ToList(); // Converte Array<string> em List<string>

foreach (string pais in resultado)
{
    Console.WriteLine(pais);
}


Console.WriteLine();
var alunos = FonteDados.GetAlunos(); //retorna um IEnumerable<Aluno>?

// convertendo IEnumerable<Aluno>? para List<Aluno>?
var listM = alunos.Where(a => a.Nome != null && a.Nome.Contains('M')).ToList();

foreach (var aluno in listM)
    Console.WriteLine(aluno.Nome);


Console.WriteLine();

//ToArray
Console.WriteLine("ToArray");
Console.WriteLine();
var arrayAlunos = alunos.Where(a => a.Nome != null && a.Nome.Contains('a')).ToArray();

foreach (var aluno in arrayAlunos)
    Console.WriteLine(aluno.Nome);


IEnumerable<Pacote> pacotes = new List<Pacote>
{
    new Pacote {Empresa = "Google",Peso = 5.2},
    new Pacote {Empresa = "JcmSoft",Peso = 8.7},
    new Pacote {Empresa = "Twitter",Peso = 3.8}
}.AsEnumerable();

string?[] empresas = pacotes.Select(e => e.Empresa).ToArray();

Console.WriteLine();
foreach (var empresa in empresas)
{
    Console.WriteLine(empresa);
}

