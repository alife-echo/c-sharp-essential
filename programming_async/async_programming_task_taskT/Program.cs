

using async_programming_task_taskT;

Console.WriteLine("## Café da manha Assíncrono");
await CafeDaManhaAsync();

Console.ReadKey();

static async Task CafeDaManhaAsync()
{
    Console.WriteLine("Preparar café");
    var taskCafe = PrepararCafeAsync();

    Console.WriteLine("Preparar Pão");
    var taskPao = PrepararPaoAsync();

    var cafe = await taskCafe;

    var pao = await taskPao;

    await ServirCafeAsync(cafe, pao);
}

static async Task ServirCafeAsync(Cafe cafe, Pao pao)
{
    Console.WriteLine("Servindo café da manha");
    await Task.Delay(2000);
    Console.WriteLine("Café servido");
}

static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("Fervendo Agua");
    await Task.Delay(2000);
    Console.WriteLine("Coando Café");
    await Task.Delay(2500);
    Console.WriteLine("Adoçando Café");
    return new Cafe();
}

static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("Partir o pão");
    await Task.Delay(2000);
    Console.WriteLine("Passar a manteiga no pão");
    await Task.Delay(2000);
    Console.WriteLine("Tostar o pão");
    return new Pao();
}