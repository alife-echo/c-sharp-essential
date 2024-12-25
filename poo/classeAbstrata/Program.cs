
using classeAbstrata;

Quadrado q  = new();
Console.WriteLine(q.Description());

Console.WriteLine("\n Informe a cor da figura");
q.Color = Console.ReadLine();

Console.WriteLine("\n Informe o valor do lado do quadrado");
q.Side = Convert.ToInt32(Console.ReadLine());

q.CalculateField();
q.CalculatePerimeter();

Console.WriteLine($"\n Área do quadrado : {q.Field} m2");
Console.WriteLine($"\n Perímetro do quadrado : {q.Perimeter}m");

Console.WriteLine($"\n O quadrado tem a cor : {q.Color}");

Console.ReadKey();