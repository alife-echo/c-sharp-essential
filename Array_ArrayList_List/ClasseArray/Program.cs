// See https://aka.ms/new-console-template for more information
Console.WriteLine("Classe Array \n \n");

string[] nomes = { "Ana", "Maria", "Dinair", "Paulo", "Carlos", "Beatriz" };

Console.WriteLine("Exibindo o array original\n");

ExibeArray(nomes);

Console.WriteLine("Invertendo ordem do array\n");

Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("Ordenando Array \n");
Array.Sort(nomes); 
ExibeArray(nomes);

Console.WriteLine("Localizando item array");
string? nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if(indice >= 0)
{
    Console.WriteLine($"{nome} foi encontrado com índice = {indice}");
}
else
{
    Console.WriteLine($"{nome} não foi encontrado");
}


static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }
}