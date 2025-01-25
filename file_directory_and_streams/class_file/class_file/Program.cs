using System.Net;

string caminhoOrigem = @"/home/alife-echo/Desktop/teste_files/arquivo1.txt";
var caminhoCopia = @"/home/alife-echo/Desktop/teste_files/arquivo1_copia.txt";
var caminhoDestinoMov = @"/home/alife-echo/Desktop/arquivo1.txt";

//criar arquivo
//File.Create(caminhoOrigem); // o arquivo é criado porem fica aberto impedindo atualizações o codigo "Create" precisa ser comentado depois

// \r\n --> equivalente a criar uma nova linha
// Environment.NewLine --> equivalente a criar uma nova linha

if (!File.Exists(caminhoDestinoMov))
{
    try
    {
        File.WriteAllText(caminhoOrigem,
            "Fernando Pessoa \r\n"); // colocando um valor no arquivo se arquivo não existir, ele cria

        string novoTexto = "O poeta é um fingidor " +
                           Environment.NewLine +
                           "Finge tão completamente \r\n" +
                           "Que chega a fingir que é dor \r\n" +
                           "A dor que deveras sente. \r\n";

        File.AppendAllText(caminhoOrigem, novoTexto); // adicionando um novo valor no mesmo arquivo

// lê o conteúdo do arquivo
        Console.WriteLine("\nConteúdo e informações do arquivo : ");
        string conteudo = File.ReadAllText(caminhoOrigem);
        Console.WriteLine(conteudo);

// verificar a ultima modificação feita em um arquivo
        Console.WriteLine($"última modificação feita em : {File.GetLastWriteTime(caminhoOrigem)}");
// Verificar o ultimo acesso feito em um arquivo
        Console.WriteLine($"último acesso feito em : {File.GetLastAccessTime(caminhoOrigem)}");


// Ler todas as linhas que estão em um arquivo
        string[] linhas = File.ReadAllLines(caminhoOrigem);
        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }


//copiando um arquivo
 
        Console.WriteLine($"\n Copiando de:{caminhoOrigem} para {caminhoCopia}");
        File.Copy(caminhoOrigem, caminhoCopia); // ele não sobreescreve pois o arquivo ja existe gerando uma exceção IOexception , para rodar o fluxo normal, precisa excluir os arquivos ou comentar

//movendo arquivos
   
        Console.WriteLine($"\n Movendo de:{caminhoOrigem} para {caminhoDestinoMov}");
        File.Move(caminhoOrigem, caminhoDestinoMov);


//excluir arquivo
        Console.WriteLine($"Exclindo {caminhoOrigem} , {caminhoDestinoMov} , {caminhoCopia}");

        File.Delete(caminhoOrigem);
        //File.Delete(caminhoDestinoMov);
        File.Delete(caminhoCopia);

    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Concluido");




// lê o conteúdo do arquivo csv
/*
Console.WriteLine("\n Contéudo arquivo csv");
string csv = File.ReadAllText(@"/home/alife-echo/Desktop/teste_files/dados_gateway.csv");
Console.WriteLine(csv);
*/

Console.ReadKey();