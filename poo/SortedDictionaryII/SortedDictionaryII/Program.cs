Console.WriteLine("### SortedDictionary II");

var brics = new SortedDictionary<int, string>()
{
    {20,"Brasil"},
    {10,"China"},
    {40,"India"},
    {30,"URSS"}
};

Console.WriteLine("- Incluindo o elemento de chave=70 e valor=África do Sul");

if(brics.ContainsKey(70))
    Console.WriteLine("Chave ja existe");
else
    brics.Add(70, "África do Sul");

Console.WriteLine($"- Número de pares de chaves(elementos) no dicionário :{brics.Count}");    

Console.WriteLine("Acessando um elemento pela chave -> brics[20]");
Console.WriteLine($"Chave 20 -> {brics[20]}");

brics[20] = "Argentina";

Console.WriteLine($"Novo valor chave 20 -> {brics[20]}");

Console.WriteLine("Removendo a chave 10 : brics.Remove(10) -> China");
brics.Remove(10);

Console.WriteLine("-Verificando se uma chave existe com ContainsKey");
Console.WriteLine($"Existe a chave 30 -> {brics.ContainsKey(30)}");

Console.WriteLine("Verificando se um valor existe com ContainsValue");
Console.WriteLine($"Exist valor 'URSS' ? -> {brics.ContainsValue("URSS")}");
Console.WriteLine($"Existe valor 'Chile' ? -> {brics.ContainsValue("Chile")}");

if (brics.TryGetValue(30, out string? valor))
{
    Console.WriteLine($"Valor chave 30 -> {valor}");
}
if (!brics.TryGetValue(30, out string? v))
{
    Console.WriteLine("Nenhum valor chave 30");
}

foreach (var pais in brics)
{
    Console.WriteLine($"{pais.Key} - {pais.Value}");
}