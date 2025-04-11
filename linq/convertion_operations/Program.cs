
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



//ToDictionary
Console.WriteLine();
Console.WriteLine("ToDictionary");
// int especifica o tipo da chave
// Id do aluno é a chave, precisa ser unico senão retornara ArgumentNullException
// o objeto Aluno é o valor
var listaDic = alunos.ToDictionary<Aluno, int>(a => a.Id); // Retorno --> Dictionary<int,Aluno>

// listDic.Keys são as chaves do Dictionary<int,Aluno>
// (listaDic[chave] as Aluno).Nome --> acessamos os valores pela chave depois convertemos para o tipo Aluno e acessamos a propriedade Nome
foreach (var chave in listaDic.Keys)
{
    Console.WriteLine($"Chave:{chave},Valor:{(listaDic[chave] as Aluno).Nome}");
}



//ToLookup

Console.WriteLine();
Console.WriteLine("ToLookup");
var funcionarios = FonteDados.GetFuncionarios();

// agrupa por cidade
var funciPorCidade = funcionarios.ToLookup(f => f.Cidade); //ILookup<string,Funcionario>

Console.WriteLine("Funcionarios agrupados por cidade");

// percorro a coleção
foreach (var kvp in  funciPorCidade)
{
    // posso acessar a chave
    Console.WriteLine(kvp.Key); // a chave é a Cidade
    // acessando os dados dos funcionarios pela chave obtida no foreach anterior
    // so posso acessar os valores pela as chaves
    foreach (var item in funciPorCidade[kvp.Key])
    {
        Console.WriteLine("\t" + item.Nome + "\t" + item.Idade);
    }
}