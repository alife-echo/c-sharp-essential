Console.WriteLine("Informe o primeiro numero inteiro");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o segundo numero inteiro");
var num2 = Convert.ToInt32(Console.ReadLine());

var soma =  CalcularSomaAsync(num1, num2).Result;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\n {num1} + {num2} = {num1 + num2}");

Console.ReadKey();
static async ValueTask<int> CalcularSomaAsync(int num1, int num2)
{
    if (num1 == 0 && num2 == 0)
        return 0;

    return await Task.Run(() => num1 + num2);
}