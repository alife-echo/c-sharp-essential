
var caminhoDiretorio = @"/home/alife-echo/Desktop/teste_files/MeuDiretorio/textos";

var diretorioPai = @"/home/alife-echo/Desktop/teste_files/textos_zovo";

var poesiasBackup = @"/home/alife-echo/Desktop/poesias2";

var diretorioUsuario = @"/home/alife-echo/";


/*
Console.WriteLine("\n Criando um novo diretório");
//para criar diretorio é bom envolver try-catch para tratar exceções
try
{
    if (!Directory.Exists(caminhoDiretorio))
    {
        Directory.CreateDirectory(caminhoDiretorio);// criar um diretorio, posso passar mais uma argumento para o metodo expecificando a permissão do diretorio
        Console.WriteLine($"Diretorio {caminhoDiretorio} criado com sucesso!");
    }
    
    else
        Console.WriteLine($"O diretorio {caminhoDiretorio} já existe");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}*/









/*
Console.WriteLine("\nExcluindo um diretório");
//para deletar diretorio é bom envolver try-catch para tratar exceções
try
{
    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.Delete(caminhoDiretorio);// posso passar mais um argumento booleano para excluir subdiretorios
        Console.WriteLine($"Diretorio {caminhoDiretorio} - deletado com sucesso!");
    }
    else
        Console.WriteLine($"O diretorio {caminhoDiretorio} não existe!");
    
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/


/*
Console.WriteLine("\nObtendo os subdiretórios de um diretório");

try
{
    if (Directory.Exists(diretorioUsuario))
    {
        //string[] subDiretorios = Directory.GetDirectories(diretorioPai); // obtem todos os subdiretorios de um caminho especificado
        string[] subDiretorios = Directory.GetDirectories(diretorioUsuario,"p*"); // posso especificar um padrão de busca, neste exemplo eu quero os diretorios que começam com "p"
        foreach (var subDir in subDiretorios) 
            Console.WriteLine(subDir);
        
    }
    else
        Console.WriteLine($"O diretorio {diretorioPai} não existe!");
    
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/


/*
Console.WriteLine("\n Obtendo todos os arquivos em um diretório");
try
{
    if (Directory.Exists(diretorioUsuario))
    {
        //string[] arquivos = Directory.GetFiles(diretorioPai); // buscando todos os arquivos em um direotorio
        string[] arquivos = Directory.GetFiles(diretorioUsuario, ".p*"); // posso especificar um padrão de busca tambem
        foreach (var arquivo in arquivos) 
            Console.WriteLine(arquivo);
        
    }
    else
        Console.WriteLine($"O diretorio {diretorioPai} não existe!");
    
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/

Console.WriteLine("\n Renomeado(Mover) um diretorio");
try
{
    if (Directory.Exists(poesiasBackup))
    {
         Directory.Move(poesiasBackup,diretorioPai); // ele não funciona caso eu queira mover para um diretorio existente,
                                                         // ao mover eu preciso especificar uma pasta que não existe para ele criar e a pasta que esta sendo movida perde o nome para a nova existente
         Console.WriteLine("O diretorio renomeado com sucesso");
    }
    else
        Console.WriteLine($"O diretorio {poesiasBackup} não existe!");
    
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();