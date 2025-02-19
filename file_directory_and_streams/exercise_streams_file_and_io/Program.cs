

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
    byte[] imgBytes = File.ReadAllBytes(img);
    var imgBase64File = Convert.ToBase64String(imgBytes);

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
*/


    Console.ReadKey();