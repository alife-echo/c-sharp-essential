
// 1 Maneira
Stack<string> diasSemana = new Stack<string>();

diasSemana.Push("Segunda");
diasSemana.Push("Terça");
diasSemana.Push("Quarta");

Console.WriteLine($"A pilha original tem {diasSemana.Count}");
Exibir(diasSemana);

// retorna sem remover
Console.WriteLine($"\n Item obtido do topo da pilha (Peek) : {diasSemana.Peek()}");

// remove e retorna
Console.WriteLine($"\n Item obtido e removido do topo da pilha pilha (Pop) : {diasSemana.Pop()}");

Exibir(diasSemana);

//copiando valores dias semana
Console.WriteLine("Copia pilha usando ToArray");
var copiaDias = new Stack<string>(diasSemana.ToArray());
Exibir(copiaDias);

//limpando pilha
Console.WriteLine("Removendo todos os valores da pilha dias semana");
diasSemana.Clear();
Console.WriteLine($"O tamanho de dias semana esta {diasSemana.Count}");


if (diasSemana.Contains("Terça"))
    Console.WriteLine("O dia 'Terça' esta na pilha");
else
    Console.WriteLine("O dia 'Terça' não! esta na pilha");

// 2 maneira
int[] array = new int[] {2,4,6,8};
Stack<int> pares = new Stack<int>(array);

Exibir(pares);
// 3 maneira
var lista = new List<string>(){"Uva","Pera"};
var frutas = new Stack<string>(lista);

Exibir(frutas);

// 4 maneira
var impares = new Stack<int>(3);
impares.Push(1);
impares.Push(3);
impares.Push(5);

Exibir(impares);




Console.ReadLine();
static void Exibir<T>(IEnumerable<T> colecao)
{
    foreach (var valor in colecao)
    {
        Console.WriteLine($"{valor}");
    }
}