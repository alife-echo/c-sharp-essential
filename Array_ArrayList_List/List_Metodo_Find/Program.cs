// See https://aka.ms/new-console-template for more information
Console.WriteLine("Métodos Find");


List<string> frutas = new() {"Uva","Banana","Maça","Abacate","Laranja","Morango"};

var fruta1 = frutas.Find(Procura);
Console.WriteLine($"Predição => {fruta1}");

var fruta2 = frutas.Find(f => f.Contains('n'));
Console.WriteLine($"Lambda => {fruta2}");
Console.ReadKey();


static bool Procura(string item)
{
    return item.Contains('n');
}