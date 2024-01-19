// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Número de parcelas");
/*
Console.WriteLine("Valor da compra R$ 600,00\n");
Console.WriteLine("Informe o numero de parcelas (1 a 3)");
int NumeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (NumeroParcelas)
{
    case 1:
        Console.WriteLine($"\n Prestação R$ {600/NumeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\n Prestação R$ {600 / NumeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\n Prestação R$ {600 / NumeroParcelas}");
        break;
    default:
        Console.WriteLine($"\n Valor invalido informe o valor de 1 a 3");
        break;
}
Console.WriteLine("\nFim do processamento");
Console.ReadKey();
*/
/*
Console.WriteLine("Digite um numero inteiro");
int n = Convert.ToInt32(Console.ReadLine());

switch (n % 2)
{
    case 0:
        Console.WriteLine("\nO número é par");
        break;
    case 1:
        Console.WriteLine("\n O número é impar");
        break;
}
Console.WriteLine("\nFim do Processamento");
Console.ReadKey();
*/
/*
Console.WriteLine("Informe o nome do mês\t");
string mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}
*/

Console.WriteLine("Digite seu cargo  1-Gerente , 2 - Programador");
int cargo = Convert.ToInt32(Console.ReadLine());
switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem-vindo Gerente");
    break;

    case 2:
        Console.WriteLine("\nBem-Vindo Programador.");
        Console.WriteLine("Função Junior(1) ou Senior(2)");
        int funcao = Convert.ToInt32(Console.ReadLine());
        switch(funcao)
            {
            case 1:
                Console.WriteLine("\nVocê é Junior");
                break;
            case 2:
                Console.WriteLine("\nVocê é Senior");
                break;
            default:
                Console.WriteLine("\nFunção Desconhecida");
                break;
        }       
        break;
    default:
        Console.WriteLine("\n Não cosigo te identificar");
        break;
}

Console.WriteLine("\nFim do processamento");
Console.ReadKey();