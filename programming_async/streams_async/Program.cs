
await foreach (var month in GetMonths())
{
    Console.WriteLine(month);
}

Console.ReadKey();

static async IAsyncEnumerable<string> GetMonths()
{
    yield return "Janeiro";
    yield return "Fevereiro";
    await Task.Delay(2000);
    yield return "Março";
    yield return "Abril";
}