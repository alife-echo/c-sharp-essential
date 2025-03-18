IList<string> frutas = new List<string> {"Banana","Maça","Pera","Laranja"};
var result = frutas.Where(f => f.Contains('r'));

Console.WriteLine(string.Join(" - ",result));