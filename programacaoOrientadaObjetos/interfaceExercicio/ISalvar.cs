namespace interfaceExercicio;
interface ISalvar
{
    public string NomeArquivo { get; set; }

    void Compactar(string NameFile, string ex)
    {
        Console.WriteLine($"Compactando Arquivo {NameFile}.{ex}");
    }
    public void Salvar();
}

