List<string> nomes = new List<string>()
{
    "Ana","Maria","Pedro","Lair","Hugo" // fonte de dados 
};

// consulta linq
//podemos usar var para inferir o tipo
// o retorno vai ser do tipo IEnumerable (somente leitura, iterável)
var resultado = from m in nomes   // inicio com a clausula from e a fonte de dados
                                where m.Contains('o') // uso diversos operadores para filtrar(where),agrupar(group by), ordenar e juntar
                                select m; // termino com a clausula SELECT ou GroupBy


//usando metodos de extensão
var resultadoExtensao = nomes.Where(n => n.Contains('a'));
//Where --> Método de extensão
//(n => n.Contains('o')) --> expresão lambda


//Quase todos os retornos de um LINQ é um IEnumerable
//IEnumerable não pode ser modificado, apenas lido é iterado
//Deferred Execution --> as variaveis não guardam o valor da consulta, apenas a expressão, a consulta so sera executada na iteração


Exibir(resultado);
Exibir(resultadoExtensao);


static void Exibir<T>(IEnumerable<T> lista)
{
    Console.WriteLine("");
    foreach (var nome in lista)
        Console.WriteLine(nome);
}

List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.ToList();

int[] array = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.ToArray();