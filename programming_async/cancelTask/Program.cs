
using System.Diagnostics;



var stopwatch = new Stopwatch();
stopwatch.Start();

try
{
    await CancelTaskWithTimeOut(2000);
}
catch (TaskCanceledException)
{
    Console.WriteLine($"Tarefa cancelada: tempo expirado após {stopwatch.Elapsed}\n");
}
catch (OperationCanceledException)
{
    Console.WriteLine($"Operação cancelada: tempo expirado após {stopwatch.Elapsed}\n");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro inesperado: {ex.Message}");
}
static async Task CancelTaskWithTimeOut(int time)
{
    using (var cts_time = new CancellationTokenSource(time))
    {
     
        try
        {

            var resultado = await OperacaoDeLongaDuracao(10, cts_time.Token);

            Console.WriteLine($"resultado:{resultado}");
        }
        catch (Exception)
        {

            throw;
        }
    }
}
static  Task<int> OperacaoDeLongaDuracao(int valor, CancellationToken cancellationToken = default) // default significa que o argumento é opcional
{
    return Task.Run(() =>
    {

            int resultado = 0;

            for (int i = 0; i < valor; i++)
            {

                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                } 
            Console.WriteLine($"Processo : {i}/{valor}");
            Thread.Sleep(1000);
                
                resultado += i;
            }
            return resultado;
              
   
    }, cancellationToken);
}