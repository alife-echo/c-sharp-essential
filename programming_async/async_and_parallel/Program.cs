Console.WriteLine("Programação síncrona");

int await_time = 4000;

Console.WriteLine("tecle algo para iniciar");

Console.ReadLine();

RealizarTarefa(await_time);

Console.WriteLine($"A duração foi: {await_time / 1000} segundos");
Console.WriteLine("Fim do processamento");

static void RealizarTarefa(int time)
{
    Console.WriteLine("Iniciando tarefa");

    Thread.Sleep(time);
    Console.WriteLine("Tarefa Concluída");
}