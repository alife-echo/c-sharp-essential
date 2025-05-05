List<Task<int>> listaTarefas  =
[
    SimulaOperacaoAsync(2000),
    SimulaOperacaoAsync(5000),
    SimulaOperacaoAsync(3000),
    SimulaOperacaoAsync(1000)
];
var s = Task.WhenEach(listaTarefas);
// aguarda todas as tarefas serem concluidas para exibir o resultado
//var tarefas = await Task.WhenAll(listaTarefas);

// devo colocar um await pois ao iterar cada tarefa eu tenho um Task<int> e para capturar seu valor eu preciso do await
await foreach (var tarefa in Task.WhenEach(listaTarefas))
{
    Console.WriteLine(await tarefa); // iterar o inice eu tenho um Task<int> então eu preciso de um await para capturar e exibir seu resultado
}



static async Task<int> SimulaOperacaoAsync(int delay)
{
    await Task.Delay(delay); // simula um trabalho assíncrono
    return delay;
}