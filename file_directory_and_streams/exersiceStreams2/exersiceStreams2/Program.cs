
using exersiceStreams2;

var pathFile = @"/home/alife-echo/Desktop/teste_files/poesia.txt";
var repoFile = new FileRepository(pathFile);

Console.WriteLine("Manager Files");
Console.WriteLine("1 - Criar Arquivo");
Console.WriteLine("2 - Gravar no Arquivo");
Console.WriteLine("3 - Ler Arquivo");
Console.WriteLine("4 - Procurar no Arquivo");
Console.WriteLine("0 - Sair");

while (true)
{
    Console.WriteLine("\n");
    var option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 0:
            return;
        case 1:
            Console.WriteLine("\n");
            Console.WriteLine(repoFile.CreateFile());
            Console.WriteLine(repoFile.CreateFile() ? "Arquivo criado com sucesso" : "Arquivo não criado");
            Console.WriteLine("\n");
            break;
        case 2:

            Console.WriteLine("\n");
            Console.WriteLine("Digite o texto");
            var text = Console.ReadLine();
            Console.WriteLine(repoFile.WriteInFile(text) ? "Dados gravados com sucesso" : "Dados não gravados");
            Console.WriteLine("\n");
            break;
        case 3:
            Console.WriteLine("\n");

            Console.WriteLine($"Conteudo arquivo:{pathFile}");
            repoFile.ReadFile();
            Console.WriteLine("\n");
            break;
        case 4:
            Console.WriteLine("\n");

            Console.WriteLine("Digite o texto");
            var textSearch = Console.ReadLine();
            repoFile.GetPositionTextInFile(textSearch);
            Console.WriteLine("\n");
            break;
         default:
            Console.WriteLine("\n");
            Console.WriteLine("Opção inválida");
            Console.WriteLine("\n");
            break;
    }
    
    if(option <= 0)
        break;
}

