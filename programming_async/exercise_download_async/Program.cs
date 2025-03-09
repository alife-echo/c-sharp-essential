





var downloadFile = HttpHelper.CancelDownloadWithTimeOut("https://pm1.aminoapps.com/6525/124188607d353af57a218ec5033ece65729c65b5_00.jpg", @"C:\Users\alife\dados\edwardNet.jpg");



Console.ReadKey();


public static class HttpHelper
{
    // instacia o http cliente para requisições http
    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task CancelDownloadWithTimeOut(string uri, string outputPath)
    {
        using(var cts_time = new CancellationTokenSource(300))
        {

            try
            {
                await DownloadFileAsync(uri, outputPath, cts_time.Token);
              

            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tarefa Cancelada");
            }


        }
    
    }
   
    public static async Task DownloadFileAsync(string uri, string outputPath, CancellationToken cancel = default)
    {
        // verifica se a url é um caminho absoluto
        // "https://example.com/files/document.pdf" --> correto(absoluto)
        // "/files/document.pdf" --> errado (relativo)
        if (!Uri.TryCreate(uri, UriKind.Absolute, out Uri? uriResult))
            throw new InvalidOperationException("URL é invalida");


        if (!string.IsNullOrEmpty(outputPath))
        {
            //Busca o diretorio do arquivo  de saida      
            string? directory = Path.GetDirectoryName(outputPath);
            //cria um diretorio caso o diretorio do arquivo de saida não existir
            if (!Directory.Exists(directory) && !string.IsNullOrEmpty(directory))
                Directory.CreateDirectory(directory);
        }


        try
        {
            if (cancel.IsCancellationRequested)
            {
                cancel.ThrowIfCancellationRequested();
            }
            // baixa os dados da url é armazena em um array de bytes
            byte[] fileBytes = await _httpClient.GetByteArrayAsync(uri);
            // escreve os bytes no arquivo
            File.WriteAllBytes(outputPath, fileBytes);

            Console.WriteLine("Arquivo Baixado com sucesso");
        }
        catch(TaskCanceledException ex)
        {
            Console.WriteLine("O download for cancelado ou demorar muito tempo");
            Console.WriteLine(ex.Message);
        }
        catch(UnauthorizedAccessException ex)
        {
            Console.WriteLine("não há permissão para gravar no diretório de destino");
            Console.WriteLine(ex.Message);
        }
        catch(HttpRequestException ex)
        {
            Console.WriteLine("há um problema na solicitação HTTP");
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            throw;
        }
     
     
    }
}




