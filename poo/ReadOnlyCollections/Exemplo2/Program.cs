

using System.Collections.ObjectModel;

var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());


//alteraçoes não permitidas
//exoPlanetas[0] = "marabá";
//exoPlanetas[0] = new ExoPlaneta() {Nome = "Marabá"};


exoPlanetas[0].Nome = "Marabá";

Exibir(exoPlanetas);

static void Exibir(IEnumerable<ExoPlaneta> collection)
{
    foreach (var value in collection)
    {
        Console.WriteLine(value.Nome);
    }
}


class ExoPlaneta
{
    public string Nome { get; set; }

    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new ExoPlaneta() {Nome = "Proxima Centauri b"},
            new ExoPlaneta() {Nome = "Kleper 186-f"},
            new ExoPlaneta() {Nome = "Gliesi 1061-c"},
        };
    }
}