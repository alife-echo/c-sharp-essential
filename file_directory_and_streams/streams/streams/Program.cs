
var caminhoArquivo = @"/home/alife-echo/Desktop/teste_files/txt/poesia.txt";

//FileStream fs = null;
StreamReader read = null;


try
{
    // 1 mandeira de criar um filestream
    
  /*  fs = new FileStream(caminhoArquivo, FileMode.Open,
        FileAccess.Read); // cria a vinculação do do caminho do arquivo com o filestream configurando os metodos de acesso e leitura*/
   // read = new StreamReader(fs); // usa o StreamReader para converter os bytes em strings para serem lidas


   read = File.OpenText(caminhoArquivo); // outra maneira de abrir um arquivo sem filestream
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
finally // se os recursos estiverem sendo usados , fecha os recursos alocados, 
{
    if (read != null)
    {
        Console.WriteLine("Recurso de leitura Fechado");
        read.Close();
    }

    /*
    if (fs != null)
    {
        Console.WriteLine("Recurso de FS fechado");
        fs.Close();
    }*/

}
Console.ReadKey();