

IControle d = new Demo();
d.Nome = "Teste";
d.Exibir();
d.Desenhar();

Console.ReadKey();


interface IControle
{
    void Desenhar();
    //public IControle(); interfaces não podem conter campos de instancia
    //int status; interfaces não podem conter campos de intancia
    public string Nome { get; set; }
    public void Exibir()
    {

    }
}

interface IGrafico
{
    void Pintar();
}
public class Demo : IControle,IGrafico
{
    public string Nome { get { return Nome; } set { Nome = value; } } // a classe precisa implementar a propriedade definida na interface
    public void Desenhar()
    {
        Console.WriteLine("Desenhando....");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando");
    }
}

