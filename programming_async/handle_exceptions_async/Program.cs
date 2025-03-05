/*
TesteAsync t = new();

// apenas chame o método
t.ChamaTarefaAsync();



Console.ReadKey();
class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
       return Task.Run(() =>
        {
            Task.Delay(2000);
            throw new Exception("Minha Exception");
        });

    }
    public async void ChamaTarefaAsync()
    {
        // mova o tratamento para o codigo assíncrono
        try
        {
            await MinhaTarefaAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bloco catch foi executado");
            Console.WriteLine(ex.Message);
        }
    }
}*/

await LancarExceptionAsync();

Console.ReadKey();

static async Task LancarExceptionAsync()
{
    try
    {
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente");

        });
        await primeiraTask;
    }catch(Exception ex)
    {
        Console.WriteLine("Bloco catch executado");
        Console.WriteLine(ex.Message);
    }
}