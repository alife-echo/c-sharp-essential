// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bloco Try-catch");


Console.WriteLine("\n Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n {x} / {y} = {z}");
}
catch(Exception ex)
{

    Console.WriteLine("\n Não existe divisão por zero, tente outro número....");
    Console.WriteLine($"\n Erro: <<< {ex.Message}");
    Console.WriteLine($"\n Localização: <<< {ex?.StackTrace?.ToString()}");
    Console.WriteLine($"\n Ref: <<<{ex?.InnerException?.ToString()}");
}

finally
{
    Console.WriteLine("\nProcessamento concluido....");
}
Console.ReadKey();