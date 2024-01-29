// See https://aka.ms/new-console-template for more information
Console.WriteLine("Estrutura Controle ");
/*
//goto
int i = 1;

repetir:

Console.WriteLine($"i = {i}\n");

i++;

if (i <= 10)
    goto repetir; 

Console.WriteLine("Fim do processamento....");
Console.ReadKey();*/

// while
/*
int i = 1;
while (i <= 10)
{
    Console.WriteLine($"{i}");
    i++;
}
*/
/*
int i = 10;
Console.WriteLine("\n");
while (i>0)
{
    Console.WriteLine($"{i}");
    i--;
}
*/

Console.WriteLine("Digite um numero");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int expressions = 10;
if(number > 0)
{
    while (i <= expressions)
    {
        Console.WriteLine($"{number}X{i}={number * i}");
        i++;
    }
}
else
{
    Console.WriteLine("O número deve ser maior que zero");
}


Console.WriteLine("Fim do processamento");