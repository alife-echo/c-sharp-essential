// See https://aka.ms/new-console-template for more information

//Criando um dicionario
Dictionary<int,int> dict1 = new Dictionary<int, int>();
//Adicionando valores ao um dicionaiorio
dict1.Add(1, 100);
dict1.Add(2, 200);
dict1.Add(3, 300);



// adicionando valores ao criar dentro da criação de dicionario
var dict3 = new Dictionary<int, int>()
{
    {8,200},
    {2,33},
    {4,444},
};






// inserindo chaves duplicadas no dicionario
Console.WriteLine("\n - Incluir elemento com chave(3) duplicada");
try
{
   //dict3.Add(3,333); //--> error estou criando uma nova chave que ja existe
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ToString());
    throw;
}




// tentando adicionar valores ao dicionario
var resultado = dict3.TryAdd(3,333); // ele tenta adicionar  se conseguir retorna true, se não ele retorne false 
Console.WriteLine(resultado == true ? "Valor adicionado" : "Chave ja existe");





// tentando adicionar valores de uma maneira manual
if (!dict3.ContainsKey(7))
{
    dict3.Add(7,7000);
}

Console.WriteLine("Exibindo valores do dicionario");
foreach (var item in dict3)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}




//acessando um elemento que não existe
Console.WriteLine("Acessando um elemento que não existe");
try
{
    //Console.WriteLine(dict3[5]); // error --> The given key '5' was not present in the dictionary.
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    throw;
}



//tentando acessar um valor que não existe
Console.WriteLine("tentando acessar um elemento que não existe");

if (dict3.TryGetValue(5, out int valor))
{
    Console.WriteLine("Valor para chave 5 = " + valor);
}
else
{
    Console.WriteLine("Chave não encontrado");
}


//Ordenando os elementos do dicionario(SortedDictionary/LINQ)
Console.WriteLine("Ordenando os elementos do dicionario(SortedDictionary/LINQ)");

var dic3Ordenado = new SortedDictionary<int, int>(dict3);

//ordenado pela chave com LINK
var dict3OrdenadoLink = new SortedDictionary<int, int>(dict3).OrderBy(x => x.Key);


Console.WriteLine("Exibindo ordenados valores do dicionario");
foreach (var item in dict3OrdenadoLink)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}