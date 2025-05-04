
/*// passando varios argumentos pois serão tratados como um array
ContadorDeNumeros(1,2,3,4,5);


Console.ReadLine();


// posso receber um numero variavel de argumentos 
static void ContadorDeNumeros(params int[] numeros)
{
    // conta o numero de elementos no array
    Console.WriteLine($"O numero de elementos é {numeros.Length}");
}

*/



// params collection no c# 13

// Exemplos de coleções aceitas
ContadorNumeros(new List<int>(){1,2,3}); // List
ContadorNumeros(Enumerable.Range(6,3)); // Geradores 
ContadorNumeros(new HashSet<int>(){4,5}); // conjuntos 
ContadorNumeros(new int[] {1,2,3,4,5}); // ate mesmo arrays

Console.ReadLine();
// espera coleções ou lista de inteiros
// internamente o compilador cria um array de ienumerable da int
static void ContadorNumeros(params IEnumerable<int> collection)
{
    Console.WriteLine($"Numero de elementos {collection.Count()}");
}