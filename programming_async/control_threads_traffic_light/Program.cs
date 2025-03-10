
/*
 * com semaforo
// cria um semaforo é permite no maximo duas threads
var semaphores = new Semaphore(1,2);

Console.WriteLine("Inclui um thread no semaforo");
semaphores.WaitOne();

Console.WriteLine("Executou o método");

semaphores.Release();

Console.WriteLine("Liberou a thread do semáforo");
Console.ReadLine();
*/


/*
 * 
 * sem semaforo
for(int i = 0; i < 10; i++)
{
    Thread threadObject = new Thread(new ThreadStart(ProcessarOperacao));
    threadObject.Name = "Thread : " + i;
    threadObject.Start();
}

Console.ReadLine();


static void ProcessarOperacao()
{
    Console.WriteLine($"Thread {Thread.CurrentThread.Name} entrou na sessão critica");
    Thread.Sleep(1000);
    Console.WriteLine($"Thread {Thread.CurrentThread.Name}  foi liberado");
}*/



using control_threads_traffic_light;

/*
for (int i = 0; i < 10; i++)
{
    Thread threadObject = new Thread(new ThreadStart(ProcessarOperacao));
    threadObject.Name = "Thread : " + i;
    threadObject.Start();
}

static void ProcessarOperacao()
{
    //vamos atender no maximo 5, mas inicialmente 3 threads
    // atender de 3 em 3 threads
    Traffic.threadPool.WaitOne();
    Console.WriteLine($"Thread {Thread.CurrentThread.Name} entrou na sessão critica");
    Thread.Sleep(1000);
    Traffic.threadPool.Release();
    Console.WriteLine($"Thread {Thread.CurrentThread.Name}  foi liberado");
}*/

for(int i = 1; i <= 6; i++)
{
    string threadName = "Thread " + i;
    int espera = 2 + 2 * i;

    var t = new Thread(() => AcessarBancoDeDados(threadName, espera));

    t.Start();
}

Console.ReadLine();

static void AcessarBancoDeDados(string nome, int seconds)
{
    Console.WriteLine($"{nome} aguardando acesso ao banco de dados");
    Traffic.semaforoSlim.Wait();

    Console.WriteLine($"{nome} autorizada a acessar o banco de dados");
    Thread.Sleep(TimeSpan.FromSeconds(seconds));

    Console.WriteLine($"{nome} concluida ... ");
    Traffic.semaforoSlim.Release();
}