namespace exersice_Delegate_Linq_Event_Lambda;

public class Planetas
{
    public string? Nome { get;set;}
    public double Diametro { get; set; }
    public double Massa { get; set; }

    public Planetas() {}
    public Planetas(string? nome, double diametro, double massa)
    {
        Nome = nome;
        Diametro = diametro;
        Massa = massa;
    }

    public static List<Planetas> GetPlanetas()
    {
        var Planetas = new List<Planetas>()
        {
            new Planetas("Mercúrio", 4879, 3.30e23),
            new Planetas("Vênus", 12104, 4.87e24),
            new Planetas("Terra", 12742, 5.97e24),
            new Planetas("Marte", 6779, 6.42e23),
            new Planetas("Júpiter", 139820, 1.90e27),
            new Planetas("Saturno", 116460, 5.68e26),
            new Planetas("Urano", 50724, 8.68e25),
            new Planetas("Netuno", 49244, 1.02e26)
        };
        return Planetas;
    }
}