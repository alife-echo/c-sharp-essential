
using delegates;

var operacoes = new Dictionary<string, Operacao>
{
    { "+", Calculadora.Somar },
    { "-", Calculadora.Subtrair },
    { "*", Calculadora.Multiplicar },
    { "/", Calculadora.Dividir }
};

Console.WriteLine("Escolha uma operação: +, -, *, /");
string? operacao = Console.ReadLine();

float num1 = 10;
float num2 = 5;

// Verifica se a operação é válida no dicionário
if (operacoes.TryGetValue(operacao, out var metodo))
{
    float resultado = metodo(num1, num2);
    Console.WriteLine($"Resultado: {resultado}");
}
else
{
    Console.WriteLine("Operação inválida.");
}



Console.ReadKey();

public delegate float Operacao(float x, float y);
