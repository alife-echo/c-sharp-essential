using linq_queries2;
//FONTE DE DADOS    
var listaProdutos = Produto.GetProdutos();


// se a fonte de dados for nula o Fist vai retornar null ou vazio
//Podendo retornar um ArgumentoNullException e se for vazia teremos InvalidOperationException
Console.WriteLine("\n-Fisrt - Localiza o primeiro elemento");
var primeiroProduto = listaProdutos.First(); // retorna o primeiro elemento da fonte de dados
Console.WriteLine($"{primeiroProduto.Nome} \t {primeiroProduto.Preco:C2}");


//tome cuidado pesquisar com Fist pois pode ser lançado uma exceção
// sempre envolva ele com um try catch
try
{
    Console.WriteLine("\n-First - Localizar o primeiro elemento usando um criterio de Nome");
    var primeiraOcorrencia1 = listaProdutos.First(p => p.Nome == "Cadeira");
    Console.WriteLine($"{primeiraOcorrencia1.Nome} \t {primeiraOcorrencia1.Preco:C2}");

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
// usando FirstOrDefault
// caso não seja encontrado um elemento o valor padrão é retornado
// o valor padrão de um objeto é null
Console.WriteLine("\n-FirstOrDefault - Localizar o primeiro elemento usando um criterio de Nome");
var primeiraOcorrencia2 = listaProdutos.FirstOrDefault(p => p.Nome == "Cadeira");

if (primeiraOcorrencia2 != null)
    Console.WriteLine($"{primeiraOcorrencia2.Nome} \t {primeiraOcorrencia2.Preco:C2}");
else
    Console.WriteLine("### Nenhum elemento foi encontrado segundo o criterio");


//Last
Console.WriteLine("\n-Last - Localiza o último elemento");
var ultimoProduto = listaProdutos.Last();
Console.WriteLine($"{ultimoProduto.Nome} \t{ultimoProduto.Preco:C2}");

//Last com criterio
try
{
    Console.WriteLine("\n-Last - Localiza o último elemento usado um critério de Nome");
    var ultimaOcorrencia1 = listaProdutos.Last(p => p.Nome == "Cadeira");
    Console.WriteLine($"{ultimaOcorrencia1.Nome} \t{ultimaOcorrencia1.Preco:C2}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\n-LastOrDefault - Localiza o último elemento usado um critério de Nome");
var ultimaOcorrencia2 = listaProdutos.LastOrDefault(p => p.Nome == "Cadeira");
if(ultimaOcorrencia2 != null)
    Console.WriteLine($"{ultimaOcorrencia2.Nome} \t{ultimaOcorrencia2.Preco:C2}");
else
    Console.WriteLine("### Nenhum elemento foi encontrado segundo o criterio");
    


//single
try
{
    Console.WriteLine("\n-Single - Localiza um unico elemento da sequencia usando um critério de Nome");
    var ultimaOcorrencia1 = listaProdutos.Single(p => p.Nome == "Mochila ");
    Console.WriteLine($"{ultimaOcorrencia1.Nome} \t{ultimaOcorrencia1.Preco:C2}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

// o null é suficiente caso não exista um elemento, porem se houver elementos duplicados é melhor envolver em um trycatch
try
{
    Console.WriteLine("\n-SingleOrDefault - Localiza um unico elemento da sequencia usando um critério de Nome");
    var ultimaOcorrencia3 = listaProdutos.SingleOrDefault(p => p.Nome == "Cadeira ");
    if(ultimaOcorrencia3 != null)
        Console.WriteLine($"{ultimaOcorrencia3.Nome} \t{ultimaOcorrencia3.Preco:C2}");
    else
        Console.WriteLine("### Nenhum elemento foi encontrado segundo o criterio");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}



Console.ReadKey();

static void Exibir(IEnumerable<Produto> collection)
{
    foreach (var value in collection)
    {
        Console.WriteLine($"{value.Nome} /t Estoque:{value.Estoque}");
    }
}