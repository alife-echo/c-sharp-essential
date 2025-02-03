
using System.Threading.Channels;

var caminhoDiretorio = @"/home/alife-echo/Desktop/teste_files";

var novoDiretorio = @"/home/alife-echo/Desktop/teste_files/novodiretorio";


var dirOrigem = new DirectoryInfo(caminhoDiretorio);

Console.WriteLine("Nome do diretório : "+ dirOrigem.Name);
Console.WriteLine("Caminho completo do diretório: " + dirOrigem.FullName);
Console.WriteLine("Data de criação: " + dirOrigem.CreationTime);
Console.WriteLine("Último acesso: " + dirOrigem.LastAccessTime);
Console.WriteLine("Última modificação " + dirOrigem.LastWriteTime);
Console.WriteLine("Atributos " + dirOrigem.Attributes);

Console.WriteLine("\n Criando um novo diretorio");

var newDirectory = new DirectoryInfo(novoDiretorio);

try
{
    if (!newDirectory.Exists)
    {
        newDirectory.Create();
        Console.WriteLine($"O diretorio {newDirectory} foi criado com sucesso");
    }
    else
        Console.WriteLine($"O diretorio {newDirectory.FullName} ja existe");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


try
{
    if (newDirectory.Exists)
    {
        newDirectory.Delete();
        Console.WriteLine($"O diretorio {newDirectory} foi deletado sucesso");
    }
    else
        Console.WriteLine($"O diretorio {newDirectory.FullName} não ja existe");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"\n Exibindo subdiretorios de {caminhoDiretorio}");

try
{
    Console.WriteLine("----------------------------------------");
    foreach (var subdir in dirOrigem.GetDirectories())
    {
        Console.WriteLine(subdir.Name);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


Console.WriteLine($"\nExibindo os arquivos  de {dirOrigem.FullName}");

try
{
    Console.WriteLine("----------------------------------------");
    foreach (var arquivo in dirOrigem.GetFiles())
    {
        Console.WriteLine(arquivo.Name);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


try
{
    if (dirOrigem.Exists)
    {
        dirOrigem.CreateSubdirectory("novoSubDiretorio");
        Console.WriteLine("SubDiretorio criado com sucesso");    
    }
    else
        Console.WriteLine($"O diretorio {dirOrigem.FullName}  não existe");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    
}



Console.ReadKey();

