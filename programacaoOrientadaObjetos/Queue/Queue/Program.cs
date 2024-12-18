
string[] cursos = {"C#", "ASP.NET","PYTHON","SQL Server"};
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine("No. de Elementos na fila 1: " + fila1.Count);
Exibir(fila1);

fila1.Enqueue(".NET MAUI");
Exibir(fila1);

Console.WriteLine("\n Obtem o primeiro item da fila com Peek");
var elemento = fila1.Peek();
Console.WriteLine(elemento);

Console.WriteLine("\n - Método Dequeue - Remove o elemento do início da fila");
fila1.Dequeue();
Exibir(fila1);

if(fila1.Contains("C#"))
    Console.WriteLine("C# esta na fila");
else
    Console.WriteLine("C# não esta na fila");

Console.WriteLine("\n - Limpa todos os elementos da fila");
fila1.Clear();
Console.WriteLine("Numero de elementos na fila 1 : " + fila1.Count);


static void Exibir<T>(IEnumerable<T> collection)
{
    Console.WriteLine();
    foreach (var value in collection)
    {
        Console.WriteLine($"{value}");
    }    
}
