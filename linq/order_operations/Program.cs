using order_operations;

List<string> nomes = new List<string>() {"Paulo", "Tarcisio","Amaral","Pedro","Debora","Helena","Percival","Manoel","Rute","Jose"};

// ordenação crescente
var listaCrescente = nomes.OrderBy(nome => nome).ToList();
Exibir(listaCrescente);

//ordenação decrescente
var listaDecrescente = nomes.OrderByDescending(nome => nome).ToList();
Exibir(listaDecrescente);

var fonteAlunos = FonteDeDados.GetTurmaA();

// ordenando crescentemente por um propriedade em especifico
var lista1 = fonteAlunos.OrderBy(a => a.Nome);

// ordenando decrescentemente por uma propriedade em especifico
var lista2 = fonteAlunos.OrderByDescending(a => a.Nome);

// ordenando mais propriedades crescentemente
var lista4 = fonteAlunos.OrderBy(a => a.Nome).ThenBy(i => i.Idade);

// ordenando mais propriedades decrescetemente
var lista5 = fonteAlunos.OrderByDescending(a => a.Nome).ThenByDescending(i => i.Idade);

// posso aplicar um filtro e depois fazer uma ordenação crescente
var lista6 = fonteAlunos.Where(a => a.Nome.Contains('r')).OrderBy(n => n.Nome);

// da mesma maneira aplicada ordenação decrescente
var lista7 = fonteAlunos.Where(a => a.Nome.Contains('r')).OrderByDescending(n => n.Nome);

// asssm como posso filtrar ordenar e aplicar novamente uma ordenação crescente ou descrencente
var lista8 = fonteAlunos.Where(a => a.Nome.Contains('r')).OrderBy(n => n.Nome).ThenBy(i => i.Idade);


// reverse
int[] numeros = {10,30,50,40,60,20,70,100};

// invertendo a lista
var lista = numeros.Reverse();
Exibir(lista);

// se eu tentar usar em strings e armazenar a manipulação em uma variavel sera retornado um erro
// pois o compilador vai inferir que estou usando o Reverse que retorna void e não um IEnumerable
//var listaInvertida = nomes.Reverse(); --> não posso atribuir void

//correção, apenas use sem armazenar em uma variavel
nomes.Reverse(); // --> correto
Exibir(nomes);

// mas como conseguir armazenar a lista invertida em uma variavel ?
// converta a lista para IEnumerable ou IQueryable

//convertendo para IEnumerable
var listaInvertidaIEnumerable = nomes.AsEnumerable().Reverse(); // agora podemos armazenar a lista invertida
Exibir(listaInvertidaIEnumerable);
// ou

//convertendo para IQueryable
var listaInvertidaIQueryable = nomes.AsQueryable().Reverse();


static void Exibir<T>(IEnumerable<T> collection)
{
    foreach(var value in collection)
    {
        Console.WriteLine(value + " ");
    }
    Console.WriteLine();
}
