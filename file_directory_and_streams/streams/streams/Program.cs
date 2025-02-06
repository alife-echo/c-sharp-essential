
var caminhoArquivo = @"/home/alife-echo/Desktop/teste_files/txt/poesia.txt";

FileStream fs = null;
StreamReader read = null;


try
{
    fs = new FileStream(caminhoArquivo, FileMode.Open,
        FileAccess.Read); // cria a vinculação do do caminho do arquivo com o filestream configurando os metodos de acesso e leitura
    read = new StreamReader(fs); // usa o StreamReader para converter os bytes em strings para serem lidas

    string? row;

    while ((row = read.ReadLine()) != null) // enquando houver linhas
    {
        Console.WriteLine(row); //printe as linhas
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
finally // fecha os recursos alocadas, 
{
    if (read != null) read.Close();
    if(fs != null) fs.Close();

}
Console.ReadKey();