/*
 
 questão 1 

 programação assíncrona = são recursos de codificação disponibilizados por uma linguagem de programação onde eu posso
 executar varias tarefas simultaneamente sem bloquear a thread principal, aproveitado melhor os recursos do processador.
 Esse modelos de programação é bastante importante para os dias de hoje devido ao fato dos usuarios realizarem diversas operações em uma aplicação ou diversos acessos a um recurso, o programa deve estar preparado para trabalhar simultaneamente
 lidando com varias operações do usuário.
 

 questão 2 e 3
 
 Task:
   realizar alguma operação que requer processamento demorado
    await Processar();

    static async Task Processar()
    {
        Console.WriteLine("Processando recurso...");
        await Task.Delay(2000);
        Console.WriteLine("Recurso processado ... ");

    }
    
    Task<T>:
        realizar um processamento demorado mas que retorne um valor tipo T
        Console.WriteLine(await GetContent("http://google.com.br"));
        static async Task<string> GetContent(string fake_url)
        {
            Console.WriteLine($"Buscando informações em : {fake_url}");
            await Task.Delay(2000);
            Console.WriteLine("Informações encontradas com sucessos");
            return "arquivo.txt";
        }
    


    questão 4:
        Síncrona:
            O modelo de programação síncrona todas as operações em execução estão usando apenas a thread principal
            o tempo de duração da thread será o tempo em que todas as operações executarem, caso uma operação seja executado junto com outra
            a thread principal sera bloqueda, usado quando eu quero uma linha de execução linear
    
        Assíncrona:
            Enquanto o modelo de programação assíncrona todas as operações estão ocorrendo simultaneamente aproveitando os recursos da thread
            sendo o tempo total gasto da thread o tempo da  operação que tiver maior tempo de execução
            
questão 5:
            Task : uso quando preciso realizar uma operação com uma carga de processamento ou espera alto sem bloquear a thread principal, pois a mesma é muito custosa porque é do tipo heap e usa o garbage collector que requer muito processamento
            ValueTask : uso quando não preciso buscar uma informação em algum lugar pois a mesma ja esta pre disponivel, basta um pequeno processamento evitando perda de desempenho pois a mesma é do tipo struct
            
            Cenario : 
                Task : buscar dados em api, valores em banco de dados , buscar dados em partes em api
                ValueTask : processamento de numeros , armazenamento dem buffer, retornar um valor ja disponivel

questão 6 :
       Posso implementar ValueTask em situações como : o valor ja estiver disponivel, quando ocorre varios processamentos com retorno não adequado como verificar se um numero é igual a zero e retornar zero, quando queremos fazer um buffer para não reprocessar um método varias vezes com o mesmo retorno gerando alocações Task descesssarias 
 
questão 7:
    Lidamos com exceções em operações assíncronas tomando cuidado para quando ocorrer uma execução assíncrona envolver-la com um tratamento de exceções.
    
    As melhores praticas são : usar sempre o await para capturar a execeção,envolver a execução assíncrona com um bloco try-catch, acessar a propriedade Exception do await da operação para percorrer as InnerExceptions e tratar todas as exceções daquela opração assíncrona, usar o Task.WhenAll para executar todas as operações assíncronas e capturar todas as suas exceções exceções , não usar void para uma task pois não sera possivel um tratamento
 
 questão 8:
    Cancelamos uma tarefas usando a classe CancellationTokenSource
    os passos são :
    instanciar o cancelation token
    passar o token para o método
    emitir o cancelamento da tarefa (se necessario) com CancellationTokenSource.Cancel()
    criar o parametro CancellationToken dentro do metodo
    verificar se o CancellationToken sera requisitado com cancellationToken.IsCancellationRequested
    se o cancelation token for solicitado lançar a execeção  com cancellationToken.ThrowIfCancellationRequested();

 
  questão 9:

   Evitar Task.Run em métodos que ja são assíncronos, usar CancellationTokenSource junto com CancellationToken para cancelar tarefas, se possivel dentro do usign, verificar periodicamente se a requisição de cancelamento foi feita com IsCancellationRequested e lançar a exceção com ThrowIfCancellationRequested() 
 
 



  questão 10:
   


    aprendizado : quando voce passa o cts(CancellationToken) para o task.run e task.delay, eles aceitam um token de CancellationToken então quando eu deixo apenas cts.ThrowIfCancellationRequested(); eles ficarão cientes do cancelamento caso solicitado




using System.Threading.Tasks;

var cts = new CancellationTokenSource();

await LancarMultiplasExcecoesCancelar(cts.Token);

cts.Cancel();

await LancarMultiplasExcecoesCancelar(cts.Token);

static async Task LancarMultiplasExcecoesCancelar(CancellationToken cts = default)
{
    Task? tasks = null;
    try
    {

        var task1 = Task.Run( async () =>
        {

            cts.ThrowIfCancellationRequested();
            await Task.Delay(2000, cts);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente");

        },cts);

        var task2 = Task.Run( async () =>
        {
            cts.ThrowIfCancellationRequested();
            await Task.Delay(2000,cts);
            throw new InvalidOperationException("InvalidOperationException lançada explicitamente");
        },cts);
        tasks = Task.WhenAll(task1, task2);
        await tasks;
    }
    catch (OperationCanceledException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("As tarefas foram canceladas");
    }
    catch
    {
        Console.WriteLine("Ocorreram as seguintes exceções");
        AggregateException? allExceptions = tasks?.Exception;

        for (int i = 0; allExceptions != null &&  i < allExceptions.InnerExceptions.Count; i++)
        {
            Exception? ex = allExceptions.InnerExceptions[i];
            Console.WriteLine(ex.Message);
        }
    }



}




questão 11

o CancellationToken serve para eu passar os tokens de cancelamento para os métodos com o objetivo dos mesmos estarem cientes quando um cancelamento for solicitado
enquanto OperationCanceledException tem o objetivo de lançar a exceção quando o cancelamento for solicitado pelo CancellationTokenSource
    
 */



