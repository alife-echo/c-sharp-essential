
using System.Net;

var client = new HttpClient();

try
{
    var response = await client.GetAsync("https://macoratti.net/dados/poesia.txt");
    response.EnsureSuccessStatusCode();
    var responseBody = await response.Content.ReadAsStringAsync();

    Console.WriteLine(responseBody);
}
catch (HttpRequestException e) when (e.StatusCode == HttpStatusCode.BadRequest)
{
    Console.WriteLine("Solicitação é invalida e não pode ser processada");
}
catch (HttpRequestException e) when (e.StatusCode == HttpStatusCode.Unauthorized)
{
    Console.WriteLine("O cliente não esta autorizado a acessar o recurso solicitado");
}
catch (HttpRequestException e) when (e.StatusCode == HttpStatusCode.Forbidden)
{
    Console.WriteLine("O cliente esta proibido de acessar o recurso solicitado");
}
catch (HttpRequestException e) when (e.StatusCode == HttpStatusCode.NotFound)
{
    Console.WriteLine("O recurso solicitado não foi encontrado no servidor");
}
catch (HttpRequestException e) when (e.StatusCode == HttpStatusCode.InternalServerError)
{
    Console.WriteLine("Ocorreu um error no servidor duranto o processsamento da solicitação");
}
catch (HttpRequestException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("\n");
    Console.WriteLine("\n");
    Console.WriteLine("Processamento Concluido ....");
}