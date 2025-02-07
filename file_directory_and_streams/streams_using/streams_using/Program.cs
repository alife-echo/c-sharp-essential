var caminhoArquivo = @"/home/alife-echo/Desktop/teste_files/txt/poesia.txt";

try
{
    /*  1 maneira de ler arquivos com using
    using FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
    using StreamReader read = new StreamReader(fs);
    */
    using StreamReader read = File.OpenText(caminhoArquivo); // 2 maneira  de ler com using
    string? row;

    while ((row = read.ReadLine()) != null)
    {
        Console.WriteLine(row);
    }
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
