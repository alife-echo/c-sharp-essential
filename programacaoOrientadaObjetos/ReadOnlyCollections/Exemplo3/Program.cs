
using System.Collections.ObjectModel;

class ManagerExoPlanetas
{
    // guarda a List de exoplanetas em uma variavel privata
    private List<ExoPlaneta>? exoPlanetas = ExoPlaneta.GetExoPlanetas();

    //Quando acessar a propriedade, retornar a List invólucra com a ReadOnlyCollection 
    public ReadOnlyCollection<ExoPlaneta> ExoPlanetas
    {
        get{ return exoPlanetas.AsReadOnly(); }
    }
    
    // Adiciona os valores apenas na List exoPlanetas da classe
    public void AddExoPlaneta(ExoPlaneta exoPlaneta)
    {
        exoPlanetas.Add(exoPlaneta);
    }
}





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