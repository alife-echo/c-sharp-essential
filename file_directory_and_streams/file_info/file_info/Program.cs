
var caminhoOrigem = @"/home/alife-echo/Desktop/teste_files/poesia.txt";
var caminhoDestino = @"/home/alife-echo/Desktop/teste_files/txt/poesia.txt";
var caminhoCopia = @"/home/alife-echo/Desktop/teste_files/txt/poesia_copia.txt";


var arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine($"\nNome do arquivo: " + arquivoOrigem.Name);


Console.WriteLine("\nCaminho completo do arquivo: " + arquivoOrigem.FullName);

Console.WriteLine("\nO arquivo é somente leitura: " + arquivoOrigem.IsReadOnly);

var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine("\nNome do diretorio: "+ diretorioPai?.Name);

Console.WriteLine("Tamanho do arquivo: " + arquivoOrigem.Length + "bytes");

Console.WriteLine("\n Ultima gravação: " + arquivoOrigem.LastWriteTime);

if (arquivoOrigem.Exists)
{
    Console.WriteLine($"\n O {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo não existe");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para a {caminhoDestino}");
arquivoOrigem.MoveTo(caminhoDestino);

Console.ReadKey();