// See https://aka.ms/new-console-template for more information
Console.WriteLine("Métodos Find");


List<string> frutas = new() {"Uva","Banana","Maça","Abacate","Laranja","Morango"};

var fruta1 = frutas.Find(Procura);
Console.WriteLine($"\n(Find) Predição => {fruta1}");

var fruta2 = frutas.Find(f => f.Contains('n'));
Console.WriteLine($"\n(Find) Lambda => {fruta2}");

var fruta3 = frutas.FindLast(f => f.Contains('n'));
Console.WriteLine($"\n(FindLast) => ${fruta3}");

var fruta4 = frutas.FindIndex(f => f.Contains('n'));
Console.WriteLine($"\n(FindIndex): indice:{fruta4} item={frutas[fruta4]}");

var fruta5 = frutas.FindLastIndex(f => f.Contains('n'));
Console.WriteLine($"\n(FindLastIndex): indice:{fruta5} item={frutas[fruta5]}");

var fruta6 = frutas.FindAll(f => f.Contains('n'));

Console.WriteLine("\nFind All : ");
foreach (var fruta in fruta6)
{
    Console.Write($" {fruta}");
}


Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n');
}