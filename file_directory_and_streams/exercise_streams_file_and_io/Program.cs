

/*
 
 Questão 1 
 
try
{
    Console.WriteLine("Informe o caminho para seu arquivo:");
    var pathFileUser = Console.ReadLine();
    
   Console.WriteLine(File.Exists(@pathFileUser) ? 
       $"Data criação:{new FileInfo(pathFileUser).CreationTimeUtc} " : 
       "O arquivo não foi encontrado");
    
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}




 Questão 2

try
   {
       Console.WriteLine("Informe o caminho de origem");
       var pathFileOrigin = Console.ReadLine();
   
       Console.WriteLine("O informe o caminho de destino");
       var pathFileDestiny = Console.ReadLine();
   
       if (Path.Exists(@pathFileOrigin) && Path.Exists(@pathFileDestiny))
       {
           File.Copy(pathFileOrigin,pathFileDestiny);
           Console.WriteLine("Copia realizada com sucesso");
       }
       
   }
   catch (IOException e)
   {
       Console.WriteLine(e.Message);
   }
   catch(Exception e)
   {
       Console.WriteLine(e.Message);
   }
   





Questão 3)

using exercise_streams_file_and_io;
   
   var input = Console.ReadLine();
   
   var filerepo = new FileRepository(input);
   
   filerepo.CreateFile();
   
   filerepo.WriteInFile("Olá eu sou goku");
   
   filerepo.WriteInFile("É hoje vamos recapitular o episodio 1");
   
   filerepo.ReadFile();
   
   
   
*/

//C:\Users\alife\OneDrive\Desktop\dados

/*
 * 
 * Questão 4
using System.Security.Cryptography;
using exercise_streams_file_and_io;

Console.WriteLine("Digite o caminho do arquivo");
var input = Console.ReadLine();

if(!File.Exists(@input))
    Console.WriteLine("O arquivo não existe");

if(!string.IsNullOrEmpty(input) && File.Exists(input))
{
    Console.WriteLine("--- Lendo arquivo---");
    var file = File.ReadAllText(input);
    Console.WriteLine(file);
    Console.WriteLine("\n");

    Console.WriteLine("-- Arquivo criptografado ---");


    // gerar a chave e iv com numeros aleatorios
    byte[] key = new byte[32];
    byte[] iv = new byte[16];

    using (var rng = RandomNumberGenerator.Create()) // server para gerar numeros aleatorios
    {

        rng.GetBytes(key); 
        rng.GetBytes(iv);

    }

    //critografar
    byte[] cipherText = AesEncryption.Encrypt(file, key, iv); //encripta o arquivo
    string encryptedText = Convert.ToBase64String(cipherText); // converte para base64

    FileHelper.ExecuteWithHandling(() =>
    {
        var fileForWriter = new FileRepository(input);
        Console.WriteLine(fileForWriter.WriteInFile(encryptedText,false) ? "Arquivo sobreescrito" : "Arquivo não sobreescrito");
        
    });

    Console.WriteLine("Digite o caminho de origem:");
    var origin = Console.ReadLine();

    Console.WriteLine("Digite o caminho destino:");
    var destiny = Console.ReadLine();

    if (File.Exists(origin))
    {
        File.Copy(origin, destiny);
        Console.WriteLine($"arquivo : {destiny} criptografado " + File.ReadAllText(destiny));
    }
    

  
}
*/

/*
 *  Questão 5
using exercise_streams_file_and_io;

Console.WriteLine("Digite o caminho do arquivo:");
var img = Console.ReadLine();

if (File.Exists(img))
{
<<<<<<< HEAD
    byte[] imgBytes = File.ReadAllBytes(img); // transformar a imagem para bytes
    var imgBase64File = Convert.ToBase64String(imgBytes); // transformar os bytes da imagem para base64
=======
    byte[] imgBytes = File.ReadAllBytes(img);
    var imgBase64File = Convert.ToBase64String(imgBytes);
>>>>>>> 005a6a28f70b763ddf5d2eb0e40c5fd2bff63382

    Console.WriteLine("Imagem criptografada: " + imgBase64File);

    Console.WriteLine("Digite o caminho para criar o arquivo de texto:");
    var textBase64 = new FileRepository(Console.ReadLine());

    FileHelper.ExecuteWithHandling(() =>
    {
        textBase64.WriteInFile(imgBase64File,false);
    });

    Console.WriteLine("Digite o caminho de origem:");
    var origin = Console.ReadLine();

    Console.WriteLine("Digite o caminho destino:");
    var destiny = Console.ReadLine();

    if (File.Exists(origin))
    {
        File.Copy(origin, destiny);
    }

}
<<<<<<< HEAD

questão 6

Console.WriteLine("Informe o caminho para o diretorio:");
var path = Console.ReadLine();

if (Directory.Exists(path))
{
    Console.WriteLine($"Nome diretorio:{Path.GetDirectoryName(path)}");

    Console.WriteLine($"Arquivos");
    
    foreach (var file in Directory.GetFiles(path))
    {
        Console.WriteLine(file);
    }

}


questão 7

Console.WriteLine("Informe o caminho para o diretorio:");
var path = Console.ReadLine();

if (Directory.Exists(path))
{
    var directorys = new DirectoryInfo(path);

    Console.WriteLine("Subdiretorios");
    foreach (var subdirectorys in directorys.GetDirectories())
    {
        Console.WriteLine(subdirectorys);
    }
}


questão 8

Console.WriteLine("Informe o caminho para o diretorio:");
var path = Console.ReadLine();

if (!Directory.Exists(path))
{
    try
    {
        if(!Path.Exists(path) && !string.IsNullOrEmpty(path))
        {
            Console.WriteLine("Diretorio Criado com sucesso");
            Directory.CreateDirectory(path);
            Console.WriteLine("SubDiretorio Criado com sucesso");
            Console.WriteLine("Informe o nome para  subdiretorio:");
            var pathSub = Console.ReadLine();
            Console.WriteLine($"Caminho completo: {Path.GetFullPath(path + @"\" + $"{pathSub}")}");
            Directory.CreateDirectory(Path.GetFullPath(Path.GetFullPath(path + @"\" + $"{pathSub}")));
            Console.WriteLine("SubDiretorio criado com sucesso");
        }
           

    }
    catch(IOException e)
    {
        Console.WriteLine(e.Message);
    }

}

questão 9


Console.WriteLine("Informe o caminho para o arquivo:");
var pathFile = Console.ReadLine();
Console.WriteLine("Informe o caminho do diretorio de destino:");
var directoryDestiny = Console.ReadLine();

if (File.Exists(pathFile) && Directory.Exists(directoryDestiny))
{
    File.Copy(pathFile, directoryDestiny + $"/{Path.GetFileName(pathFile)}");
    Console.WriteLine("Copia realizada com sucesso");
}



questão 10

Console.WriteLine("Informe o caminho para o arquivo:");
var pathFile = Console.ReadLine();
Console.WriteLine("Informe o caminho do diretorio de destino:");
var directoryDestiny = Console.ReadLine();

if (File.Exists(pathFile) && Directory.Exists(directoryDestiny))
{
    File.Move(pathFile, directoryDestiny + $"/{Path.GetFileName(pathFile)}");
    Console.WriteLine("Movimentação realizada com sucesso");
}






questão 11

Console.WriteLine("Informe o caminho do diretorio:");
var path = Console.ReadLine();

if (Path.Exists(path))
{
    var dir = new DirectoryInfo(path);

    Console.WriteLine("SubDiretorios:");
    foreach (var subdir in dir.GetDirectories())
    {
        Console.WriteLine($"{subdir}");
    }
    Console.WriteLine("Arquivos:");
    foreach(var file in dir.GetFiles())
    {
        Console.WriteLine($"{file}");
    }
}




questão 12

Console.WriteLine("Selecione as ações do menu abaixo:");
Console.WriteLine("1 - Excluir Arquivo");
Console.WriteLine("2 - Excluir Diretorio");
var option = Console.ReadLine();

Console.WriteLine("Informe o caminho do diretorio:");
var path = Console.ReadLine();


var menu = new Dictionary<string, Operation>
{
    {"1",DeleteFile},
    {"2",DeleteDirectory}
};


if (!string.IsNullOrEmpty(option) && menu.TryGetValue(option, out var method))
{
    method(path);
}
else
{
    Console.WriteLine("Operação invalida");
}

    static void DeleteFile(string? path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("Arquivo Excluido com sucesso");
        }
    }

static void DeleteDirectory(string? path)
{
 
    if (Directory.Exists(path) && !string.IsNullOrEmpty(path))
    {
        var dir = new DirectoryInfo(path);
        setAttributesNormal(dir);
        try
        {
            Directory.Delete(path, true);
            Console.WriteLine("Diretório excluído com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao excluir o diretório: {ex.Message}");
        }
    }
}

static void setAttributesNormal(DirectoryInfo dir)
{
    foreach (var subdir in dir.GetDirectories())
    {
        setAttributesNormal(subdir);
        subdir.Attributes = FileAttributes.Normal;
    }
    foreach(var file in dir.GetFiles())
    {
        file.Attributes = FileAttributes.Normal;
    }
}

Console.ReadKey();
public delegate void Operation(string? path);






questão 13

Console.WriteLine("Informe o caminho do arquivo:");
var path = Console.ReadLine();

if(File.Exists(path) && !string.IsNullOrEmpty(path))
{
    Console.WriteLine("Digite o novo nome para o arquivo");
    var newNameFile = Console.ReadLine();
    
    if (!string.IsNullOrEmpty(newNameFile))
    {
        var directory = Path.GetDirectoryName(path); // retorna o diretorio onde esta o caminho com arquivo
        var newPath = Path.Combine(directory, newNameFile); //combino o caminho do diretorio com o nome do novo arquivo

        try
        {
            File.Move(path, newPath);
            Console.WriteLine("Arquivo renomeado com sucesso");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
}


questão 14

Console.WriteLine("Informe o caminho do arquivo:");
var path = Console.ReadLine();

if (Directory.Exists(path) && !string.IsNullOrEmpty(path))
{
    var info = new DirectoryInfo(path);

    long totalSize = GetDirectorySize(info);

    Console.WriteLine($"Tamanho total do diretório: {FormatSize(totalSize)}");
}

static long GetDirectorySize(DirectoryInfo dir)
{
    long size = dir.EnumerateFiles().Sum(f => f.Length);

    foreach (var subDir in dir.EnumerateDirectories())
    {
        size += GetDirectorySize(subDir); 
    }

    return size;
}

static string FormatSize(long bytes)
{
    string[] sizes = { "B", "KB", "MB", "GB", "TB" };
    double len = bytes;
    int order = 0;

    while (len >= 1024 && order < sizes.Length - 1)
    {
        order++;
        len /= 1024;
    }

    return $"{len:0.##} {sizes[order]}";
}



questão 15

Console.WriteLine("Informe o caminho do arquivo:");
var path = Console.ReadLine();

if (Directory.Exists(path) && !string.IsNullOrEmpty(path))
{
    var dir = new DirectoryInfo(path);
    var fileLastCreation = dir.GetFiles().OrderBy(f => f.LastAccessTime).ToList();
    Console.WriteLine($"Arquivo mais recente:{fileLastCreation[0]}");
}

*/






Console.ReadKey();
=======
*/


    Console.ReadKey();
>>>>>>> 005a6a28f70b763ddf5d2eb0e40c5fd2bff63382
