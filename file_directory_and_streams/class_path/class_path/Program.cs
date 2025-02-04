

/*
 
 o codigo abaixo é sobre a classe Path, posso obter informações de separator padrão do meu s.o
 
string caminho =  "//home//alife-echo//Desktop//teste_files";

char dirSeparator = Path.DirectorySeparatorChar;
Console.WriteLine("O separador de  diretorio padrão é: " + dirSeparator);

char volumeSeparator = Path.VolumeSeparatorChar;
Console.WriteLine("O separator de volume padrão é: " + volumeSeparator);

char AltDirectorySeparatorChar = Path.AltDirectorySeparatorChar;
Console.WriteLine("O separator alternativo de diretorios é:" + AltDirectorySeparatorChar);

char separatorMultPath = Path.PathSeparator;
Console.WriteLine("O separator de multiplos caminhos é:" + separatorMultPath);

string[] diretorios = caminho.Split(dirSeparator);
Console.WriteLine("Os diretorios e o arquivo no caminho são:");
foreach (var dir in diretorios)
    Console.WriteLine(dir);
*/

string path1 =  @"/home/alife-echo/Desktop";
string path2 = @"teste_files/txt/poesia.txt";

string pathCombinado = Path.Combine(path1,path2);
Console.WriteLine($"Path combinado: {pathCombinado}");


Console.WriteLine("\nNome do diretório: " + Path.GetDirectoryName(pathCombinado));
Console.WriteLine("\nExtensão: " + Path.GetExtension(pathCombinado));
Console.WriteLine("\nNome do arquivo: " + Path.GetDirectoryName(pathCombinado));
Console.WriteLine("\nNome do arquivo sem extensão: " + Path.GetFileNameWithoutExtension(pathCombinado));
Console.WriteLine("\n Possui extensão " + Path.HasExtension(pathCombinado));
Console.WriteLine("\nContém raiz ?: " + Path.IsPathRooted(pathCombinado));
Console.WriteLine("Nova extensão para arquivo: " + Path.ChangeExtension(pathCombinado,".docx"));
Console.WriteLine("\nRaiz: " + Path.GetPathRoot(pathCombinado));

// os metodos abaixo não precisam de caminho especificado

Console.WriteLine("\nNome de arquivo aleatorio:" + Path.GetRandomFileName());
Console.WriteLine("\nNome de arquivo temporario:" + Path.GetTempFileName());
Console.WriteLine("\nCaminho temporario:" + Path.GetTempPath());

char[] caracteresInvalidosEmArquivo = Path.GetInvalidFileNameChars();

Console.WriteLine("\n Caracteres invalido em nome de arquivo: " + new string(caracteresInvalidosEmArquivo));