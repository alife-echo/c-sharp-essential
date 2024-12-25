
namespace pooExercicios;
public class SqlServer : Database
{
    public int Port { get; set; }
    public string? Url { get; set; }

    public SqlServer()
    {
        Port = 3000;
        Url = "http://localhost";
        Conectar();
        Configurar();
    }
    public override void Conectar()
    {
        Console.WriteLine("Conectando ao banco SQL Server ...");
    }
    public override void Configurar()
    {
        Console.WriteLine($"SQL rodando em {Url + ":" + Port}/");
    }
}
