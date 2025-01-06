List<string> nomes = new List<string>();


nomes.Add("John");
nomes.Add("Doe");
nomes.Add("Mary");
nomes.Add("Paulo");
nomes.Add("Fred");
nomes.Add("James");


string? resultado = nomes.Find(delegate (string nome) { return nome.Equals("Paulo"); });

Console.WriteLine(resultado);

Console.ReadKey();
