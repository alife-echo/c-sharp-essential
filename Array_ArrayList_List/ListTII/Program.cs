// See https://aka.ms/new-console-template for more information
Console.WriteLine("List<T> II");


List<string> list = new List<string>() { "Álife","Cassia","Bob","Richard" };

list.Add("Bob");

list.Insert(0, "Cassia");

List<string> list2 = new List<string>() { "RR", "Gustavo", "Morandi" };

list.AddRange(list2);

List<string> list3 = new List<string>() {"Jax","Fiora","Zac"};

list.InsertRange(0,list3);

Console.WriteLine($"{(list.Contains("Álife") ? "Tem Álife" : "Não tem Álife")}");

Exibir(list);


list.Remove("Bob");
Exibir(list);
list.RemoveAt(1);
Exibir(list);
list.RemoveRange(2,4);

Exibir(list);

list.Sort();

Exibir(list);

list.Clear();

Exibir(list);


static void Exibir(List<string> list)
{
    foreach (string item in list)
    {
        Console.WriteLine(item);

    }
    Console.WriteLine("\n");
}

