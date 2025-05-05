using implicit_index;

var inicializaLista = Enumerable.Range(1, 10);

var outraLista = new List<int>(inicializaLista)
{
  [^1] = 15
};

Console.WriteLine(string.Join(", ", outraLista));

// posso modificar um array na sua inicialização utilizando tambem indice implicito
InicializaArray vetor = new()
{
  Inteiros =
  {
    [0] = 500,
    [^4] = 5,
    [^3] = 300,
    [^2] = 200,
    [^1] = 100,
  }
};

Console.WriteLine(vetor.Inteiros[^1]);
Console.WriteLine(vetor.Inteiros[^2]);
Console.WriteLine(vetor.Inteiros[^3]);
Console.WriteLine(string.Join(", ", vetor.Inteiros));