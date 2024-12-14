
var numeros = new SortedSet<int>(){1,2,3,4,5};
var frutas = new SortedSet<string>() {"uva","banana","pera"};

SortedSet<int> pares = new SortedSet<int>();

for (int i = 0; i < 6; i++)
{
    pares.Add(i * 2);
}
Exibicao(pares);

var numerosList = new List<int>(){1,7,3,6,5,4,2};
SortedSet<int> conjunto = new SortedSet<int>(numerosList);
Exibicao(conjunto);


var frutasList = new List<string>() {"Jinx","Vi","Alife","Richard","Carl" };
SortedSet<string> conjuntoFrutas = new SortedSet<string>(frutasList);
Exibicao(conjuntoFrutas);


Console.ReadKey();

static void Exibicao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var valor in colecao)
    {
        Console.WriteLine(valor);
    }
}
