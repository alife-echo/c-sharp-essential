using linq_query;

Console.WriteLine("## LINQ - Filtrar Dados ##\n");

var numeros = FonteDados.GetNumeros();

Console.WriteLine("numeros menor que 10");
var resultado1 = numeros.Where(n => n <10);
Console.WriteLine(String.Join(" ",resultado1));

Console.WriteLine("numeros maior que 1 diferente de 4 e menor que 20");
var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);
Console.WriteLine(String.Join(" ", resultado2));

var listaNegro = FonteDados.GetListaNegra();

Console.WriteLine("Numeros que não estão na lista negro");

// posso usar outro metodo na expressão lambda, desde que o retorno seja booleano
var resultado3 = numeros.Where(n => !listaNegro.Contains(n));
Console.WriteLine(String.Join(" ", resultado3));


// o compilador vai otimizar a consulta, pois a consulta ainda não foi percebida, apenas sendo percebida quando iteramos ela usando o Join
// posso refazer o resultado 2 porem usando um encadeamento de where
Console.WriteLine("numeros maior que 1 diferente de 4 e menor que 20");
Console.WriteLine("Usando o encadeamento de where");
var resultado4 = numeros.Where(n => n > 1).Where(n => n != 4).Where(n => n < 20);
Console.WriteLine(String.Join(" ", resultado4));


//trabalhar com objetos complexos
var alunos = FonteDados.GetAlunos();

var resultado5 = alunos.Where(a => a.Nome.StartsWith('A') && a.Idade < 18);

// objetos complexos com sintaxe de consulta
// essa consulta sempre gera um novo conjunto de dados
var resultado6 = from a in alunos
                 where a.Nome.StartsWith('A') && a.Idade < 18
                 select a;

foreach (var aluno in resultado6)
{
    Console.WriteLine(aluno.Nome + " : " + aluno.Idade);
}

Console.ReadKey();