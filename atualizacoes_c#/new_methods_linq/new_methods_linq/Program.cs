// CountBy

string[] nomes = ["Ana","Bruno","Ana","Carlos","Ana","Bruno"];

var contagem = nomes.CountBy(n => n );

Exibir(contagem);

(string nome, string sobrenome)[] pessoas =
[
    ("Álife","Moraes"),
    ("Janice","Silva"),
    ("Álife","Silveira"),
    ("Maria","Sanches"),
    ("Pedro","Sobrinho"),
    ("Janice","Fernandez"),
    ("Maria","Moreti"),
];

// agora no c# 13
var contagemNomes = pessoas.CountBy(n => n.nome);
Exibir(contagemNomes);

// antes do c# 13
// a chave do dicionario seria a chave do groupby, o o valor seria o quantidade de vezes que a chave é repetida
var contagemNomesAntesC13 = pessoas.GroupBy(n => n.nome).
    ToDictionary(group => group.Key, group => group.Count());

Exibir(contagemNomesAntesC13);



// AggregateBy

int[] numerosA = [1, 2, 3, 4, 5, 6, 7, 8, 9];

var resultado = numerosA.AggregateBy(
    keySelector: n => n % 2 == 0 ? "Par" : "Ímpar", // defino a chave de agrupamento
    seed: 0, // defino o valor inicial da semente
    func: (contagemA,_) => contagemA + 1 // defino a logica para modificar a semente e iterar entre os valores 
);

Exibir(resultado);

// aggregateBy segunda sobrecarga
(string nome, string departamento,int diasFerias)[] funcionarios =
[
    ("João Duda","TI",12),
    ("Jane Soares","Marketing",18),
    ("José Silva","TI",28),
    ("Maria Fernandez","RH",17),
    ("Nivia Maria","Marketing",5),
    ("Maria Moreti","RH",9),
];

//antes .NET 9
// precisava combinar groupby com todictionary
var diasFeriasDepartamentoAntes = funcionarios.GroupBy(n => n.departamento)
    .ToDictionary(group => group.Key, group => group.Sum(d => d.diasFerias));


Exibir(diasFeriasDepartamentoAntes);

//.NET 9
// a sobrecarga esta em omitir a nomeação dos parametros, apenas passar os valores
var diasFeriasDepartamento = funcionarios.AggregateBy
    (funci => funci.departamento, 0, (acc, func) => acc + func.diasFerias);

Exibir(diasFeriasDepartamento);


// Index

var alunos = new[]
{
  "Jose Sanches",
  "Janice Pereira",
  "Carlos Nogueira",
  "João Silveira"
};

// .NET 9
// como retorna uma tupla eu preciso de outra tupla para receber os valores
foreach (var (index,aluno) in alunos.Index())
{
    Console.WriteLine($"Aluno : {index} : {aluno}");
}

Console.WriteLine();
// antes do .NET 9
foreach (var (index, aluno) in alunos.Select((valor, index) => (index, valor)))
{
    Console.WriteLine($"Aluno : {index} : {aluno}");
}

static void Exibir<T>(IEnumerable<KeyValuePair<string, T>> collection)
{
    foreach (var keyValuePar in collection)
    {
        // acessando a chave e valor do KeyValuePair
        // a chave de agrupamento e a quantidade de vezes que ela aparece
        Console.WriteLine(keyValuePar.Key + " " + keyValuePar.Value);
    }
    Console.WriteLine("");
}
