using exerciseLINQ;
// Questão 1

var listaQuadrado = Enumerable.Range(1, 10).Where(x => x % 2 == 0).Select(x => x * x);

Exibir("Lista AoQuadrado", collection: listaQuadrado);


// Questão 2

var nomes = new List<string>() {"Álife","Bob","Richard","Aline","Megan Fox","Bob Swagger","Andre","Abo","Ambo","Anado"};

var nomesComecaAterminaO = nomes.Where(n => n.StartsWith('A') && n.EndsWith('o')).OrderByDescending(n => n);

Exibir("Começa com A e termina com zero", collection: nomesComecaAterminaO);

//Questão 3

var lista1 = new List<int>() {1,4,67,7,12,6,8,34,7,2,5,3,9,5,0,56,12};
var lista2 = new List<int>() {5,3,4,8,5,1,8,3,6,7,0,1,12,54,67,8,123};

var intersecao = lista1.Intersect(lista2).ToList();

Exibir("Interseção entre duas listas", collection: intersecao);


// Questão 4

var produtosPorCategoria = Produto.GetProdutos().GroupBy(p => p.Categoria).OrderBy(p => p.Key).Select(p => new
{
    Key = p.Key,
    Produtos = p.Select(n => n.Nome),
    PrecioMedio = p.Average(p => p.Preco)
});


foreach( var produtos in produtosPorCategoria)
{
    Console.WriteLine();
    Console.WriteLine($"Categoria:{produtos.Key}");
    Console.WriteLine($"Produtos:{string.Join(", ",produtos.Produtos)}");
    Console.WriteLine($"Média preços:{produtos.PrecioMedio:F2}");
}

// Questão 5
var alunos = Aluno.GetAlunos().Where(a => (a.Notas?.Sum() / 3) > 7);

Console.WriteLine();
Console.WriteLine("Alunos com a nota maior que 7");
foreach (var aluno in alunos)
{
    Console.WriteLine($"{aluno.Nome} - {(aluno.Notas?.Sum()/3):F1}");
}

//Questão 6
var listaInteiros = new List<int> {2,5,6,7,4,23,34,76,87,12,43,23,54,56,897,12,43,68,12 };
var terceiroMaior = listaInteiros.OrderByDescending(n => n).ElementAt(2);

Console.WriteLine($"Terceiro Numero Maior:{terceiroMaior}");

//Questão 7

var innerJoinPedidoCliente = Cliente.GetClientes().Join
    (
        Pedido.GetPedidos(),
        cliente => cliente.Id,
        pedido => pedido.IdCliente,
        (c, p) => new
        {
            IdCliente = c.Id,
            NomeClientePedido = c.Nome,
            PedidoCliente = p.Nome,
        }
    ).GroupBy(cp => cp.NomeClientePedido);

Console.WriteLine();
Console.WriteLine("Total de Pedidos Por Cliente");
foreach(var pedidoCliente in innerJoinPedidoCliente)
{
    Console.WriteLine(
        $"Id:{pedidoCliente.Select(cp => cp.IdCliente).ElementAt(0)}," +
        $"Cliente:{pedidoCliente.Key}," +
        $"Total Pedidos:{pedidoCliente.Select(cp => cp.PedidoCliente).Count()}");
    
}


//Questão 8 

var listaPalavras = new List<string>() {"Álife","Bob","Richarda","Ana","ANA","RegisTadeu","Marcos","Marcos","Gabriel","GABRIEL"};
var maiorParaMenor = listaPalavras.Distinct(StringComparer.OrdinalIgnoreCase).OrderByDescending(nome => nome.Length).Take(5).ToList();
Console.WriteLine();
Console.WriteLine("5 palavras mais longas");
Console.WriteLine($"{string.Join(", ",maiorParaMenor)}");

//Questão 9
var numerosAleatorio = new List<int>() { 12, 45, 7, 30, -5, 88, 60, 17, 3, -10, 100, 5, 27 };
var positivosEMultiplo10 = numerosAleatorio.Where(n => n > 0 && numerosAleatorio.FirstOrDefault(m => m % 10 == 0) > 0);
Console.WriteLine($"{string.Join(", ",positivosEMultiplo10)}");

// Questão 10

var listaCidades = new List<string>()
{
    "Belém", "São Paulo", "Rio de Janeiro", "Belo Horizonte", "Curitiba",
    "Porto Alegre", "Fortaleza", "Salvador", "Manaus", "Recife"
};

var listaEstados = new List<string>()
{
    "Pará", "São Paulo", "Rio de Janeiro", "Minas Gerais", "Paraná",
    "Rio Grande do Sul", "Ceará", "Bahia", "Amazonas", "Pernambuco"
};
var cidadeEestados = listaCidades.Zip(listaEstados, (c, e) => c + " - " + e);

Console.WriteLine();
foreach (var cidadeEestado in cidadeEestados)
{
    Console.WriteLine(cidadeEestado);
}


// Questão 11

var lista1a100 = Enumerable.Range(1, 100).Where(num => num % 7 == 0);

Exibir("1 a 100 multiplos 7", collection: lista1a100);


// Questão 12

var primeiros5Ignorar3 = lista1a100.Skip(3).Take(5);
Exibir("5 primeiros depois de ignorar os 3 primeiros", collection: primeiros5Ignorar3);

// Questão 13
var funcionariosDepartamentos = Funcionario.GetFuncionarios().GroupBy(d => d.Departamento);

Console.WriteLine("3 maiores salarios");
foreach (var funcionarioDepartamento in funcionariosDepartamentos)
{
    Console.WriteLine(funcionarioDepartamento.Key);
    var tresMaioresSalarios = funcionarioDepartamento.OrderByDescending(f => f.Salario).Take(3);
    foreach (var fd in tresMaioresSalarios)
    {
        Console.WriteLine($"Nome:{fd.Nome},Salario:{fd.Salario},Cargo:{fd.Cargo}");
    }
}


//Questão 14

var indexes = Enumerable.Range(0, lista1a100.ToArray().Length);
var numerosComIndice = lista1a100.Zip(indexes, (value, index) => value + ":" + index);
Console.WriteLine();
Console.WriteLine("Valores e indices");
Console.WriteLine(string.Join(", ",numerosComIndice));


// Questão 15

var listaPalavras1 = new List<string>() {"a","b","c","d","r","o","x"};
var listaPalavras2 = new List<string>() {"x","a","d","q","o","p","ç"};

var juncaoPalavras = listaPalavras2.Concat(listaPalavras1);

Exibir("Lista de palavras", collection: juncaoPalavras);

static void Exibir<T>(string title, IEnumerable<T>? collection = null, IQueryable<T>? collectionQuery = null)
{
    Console.WriteLine();
    Console.WriteLine(title);
    foreach (var value in collection ?? collectionQuery ?? Enumerable.Empty<T>())
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}