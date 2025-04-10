
using elements_operators_I;

List<int> numbers = new List<int> {10,20,30,40,50,60,70,80,90,100};

int result = numbers.ElementAt(5);

Console.WriteLine(result);


// tipos complexos
var aluno = FonteDados.GetAlunos().ElementAt(5); // retorna um objeto

Console.WriteLine($"{aluno.Id},{aluno.Nome},{aluno.CursoId}");


// retornando um propriedade em especifico
var nome = FonteDados.GetAlunos().Select(a => a.Nome).ElementAt(5);

Console.WriteLine(nome);

// usando ElementAtOrDefault
int resultadoElementAtOrDefault = numbers.ElementAtOrDefault(5);
Console.WriteLine(resultadoElementAtOrDefault);


//  usando DefaultIfEmpty

Console.WriteLine("Usando DefaultIfEmpty");

List<int> numeros = new List<int>() { 10, 20, 30 };

List<int> semNumeros = new List<int>() { };

IEnumerable<int> resultadoNumeros = numeros.DefaultIfEmpty(); // retornado 10,20,30 pois existem valores na lista

Exibir(resultadoNumeros);

IEnumerable<int> resultadoSemNumeros = semNumeros.DefaultIfEmpty(); // retorna o valor padrão do tipo, nesse caso é int então o retorno é 0

Exibir(resultadoSemNumeros);

IEnumerable<int> resultadoComValorPadrao = semNumeros.DefaultIfEmpty(5); // retorna 5 como padrão caso a lista esteja vazia

Exibir(resultadoComValorPadrao);

static void Exibir<T>(IEnumerable<T> collection)
{
   
    Console.Write(string.Join(",",collection));
    Console.WriteLine();
}