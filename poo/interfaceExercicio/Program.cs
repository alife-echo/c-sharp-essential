
using interfaceExercicio;

SalvarXml s1 = new SalvarXml();
s1.NomeArquivo = "index";
s1.Salvar();
(s1 as ISalvar)?.Compactar(s1.NomeArquivo, "xml");
s1.Nome();



SalvarJson s2 = new SalvarJson();
s2.NomeArquivo = "package";
s2.Salvar();
s2.Nome();
(s2 as ISalvar)?.Compactar(s2.NomeArquivo, "json");

Console.ReadKey();


public class SalvarXml : ArquivoBase,ISalvar
{
    private string? nome_arquivo;
    public string NomeArquivo { get { return String.IsNullOrEmpty(nome_arquivo)? String.Empty:nome_arquivo; } set => nome_arquivo = value; }

    public override void Nome()
    {
        Console.WriteLine($"Nome Arquivo:{NomeArquivo}.xml");
    }

    public void Salvar ()
    {
        Console.WriteLine($"Salvando Arquivo:{NomeArquivo}.xml");
    }


}

public class SalvarJson : ArquivoBase,ISalvar
{
    private string? nome_arquivo;
    public string NomeArquivo { get { return String.IsNullOrEmpty(nome_arquivo) ? String.Empty : nome_arquivo; } set => nome_arquivo = value; }

    public override void Nome()
    {
        Console.WriteLine($"Nome Arquivo:{NomeArquivo}.json");
    }
    public void Salvar()
    {
        Console.WriteLine($"Salvando Arquivo:{NomeArquivo}.json");
    }


}