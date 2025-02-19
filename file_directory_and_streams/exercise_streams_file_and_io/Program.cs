

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


using exercise_streams_file_and_io;

Console.WriteLine("Digite o caminho do arquivo");
var input = Console.ReadLine();

if(!File.Exists(input))
    Console.WriteLine("O arquivo não existe");

if(!string.IsNullOrEmpty(input))
    FileHelper.ExecuteWithHandling(() =>
    {
        var file = new FileInfo(input);
        file.Enc
    });