// See https://aka.ms/new-console-template for more information
Console.WriteLine("List e IEnumerable");


Console.WriteLine(Guid.NewGuid());
Console.WriteLine(Guid.NewGuid().GetHashCode());
Console.WriteLine(new Random().Next(1,4));

var limiteCredito = new List<Limite>();

for (int i = 1; i < 15; i++)
{
     limiteCredito.Add(new Limite() { Numero = i});
}

var limitesComRestricao = limiteCredito.Where(x => x.AnalisaLimite()).ToList();

var primeiroLimiteComRestrição = limitesComRestricao.FirstOrDefault();

Console.WriteLine($"\n##{primeiroLimiteComRestrição?.Numero}");



Console.WriteLine("\nFim do processamento");
public class Limite
{
    public int Numero { get; set; }
    public bool isRestricao;

    public Limite() 
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;

    }
    public bool AnalisaLimite()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para o limite {Numero} : {isRestricao}");
        return isRestricao;
    }
}