using System.Collections.ObjectModel;

var planetas = new List<string>()
{
    "Mercury",
    "Venus",
    "Earth",
    "Mars",
};

var listaPlanetas = new ReadOnlyCollection<string>(planetas);

Console.WriteLine("Planetas não gasosos do sistema solar");
Exibir(listaPlanetas);

Console.WriteLine();
Console.WriteLine($"Numero de planetas na coleção : {listaPlanetas.Count}");


Console.WriteLine("Jupiter esta na coleção ?");
Console.WriteLine(listaPlanetas.Contains("Jupiter") ? "sim" : "não");

Console.WriteLine();
Console.WriteLine($"O planeta de indice 3 : {listaPlanetas[3]}");

Console.WriteLine();
Console.WriteLine($"Indice do planeta Terra : {listaPlanetas.IndexOf("Earth")}");

Console.WriteLine();
Console.WriteLine("Inserindo uma novo elemento na lista original (índice 4)");
planetas.Insert(4, "Plutão");
Exibir(listaPlanetas);

Console.WriteLine();
Console.WriteLine("Copiando os elementos da coleção para uma array unidimensional");
string[] planetaArray = new string[listaPlanetas.Count + 2];
// copia os elementos para o array "planetaArray" apartir do indice 1 do "planetaArray"
listaPlanetas.CopyTo(planetaArray,1);
Exibir(planetaArray);

static void Exibir<T>(IEnumerable<T> collection)
{
    foreach (var value in collection)
    {
        Console.WriteLine(value);
    }
}