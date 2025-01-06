

List<string> nomes = new List<string>();


nomes.Add("John");
nomes.Add("Doe");
nomes.Add("Mary");
nomes.Add("Paulo");
nomes.Add("Fred");
nomes.Add("James");


// tranformado em lambda
string? resultado = nomes.Find(nome => nome.Equals("Paulo"));

Console.WriteLine(resultado);

Console.ReadKey();