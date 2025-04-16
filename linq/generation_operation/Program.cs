

// Range

// gera 10 numeros começando do 1
using generation_operation;

IEnumerable<int> numeros = Enumerable.Range(1, 10);

Exibir(numeros, "Range");


// Range com filtro

// gera 30 numeros começando do 10 
IEnumerable<int> pares = Enumerable.Range(10, 30).Where(x => x % 2 == 0);

Exibir(pares, "Range com filtro");


// Range com select

IEnumerable<int> quadrados = Enumerable.Range(1, 10).Select(x => x * x);

Exibir(quadrados, "Range com select");



// Repeat

// repetindo uma string 10 vezes
IEnumerable<string> valores = Enumerable.Repeat("Macoratti .NET - LINQ", 10);

Exibir(valores, "Repeat");

IEnumerable<int> anos_repetido = Enumerable.Repeat(2023, 10);

Exibir(anos_repetido, "Repeat com int");



// Empty

var vazio = Enumerable.Empty<string>();

Exibir(vazio, "Empty");


var colecaoVazia1  = Enumerable.Empty<string>();
var colecaoVazia2  = Enumerable.Empty<Aluno>();

Console.WriteLine("\n Coleção de strings \n");
Console.WriteLine("Count : {0}", colecaoVazia1.Count());
Console.WriteLine("Tipo : {0}", colecaoVazia1.GetType().Name);


Console.WriteLine("\n Coleção de objetos Aluno \n");
Console.WriteLine("Count : {0}", colecaoVazia2.Count());
Console.WriteLine("Tipo : {0}", colecaoVazia2.GetType().Name);



IEnumerable<int> resultado = Aluno.GetData() ?? Enumerable.Empty<int>();

foreach(var num in resultado)
{
    Console.WriteLine(num);
}

Console.WriteLine("Concluido");

static void Exibir<T>(IEnumerable<T> collection,string title)
{
    Console.WriteLine(title);
    foreach (var value in collection)
    {
        Console.WriteLine(value);
    }
    Console.WriteLine();
}