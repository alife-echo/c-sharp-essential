// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio Estruturas de controle");

int x1 = 0, y1 = 0, z1 = 0;

Console.WriteLine("Digite o primeiro numero");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro numero");
z1 = Convert.ToInt32(Console.ReadLine());

int highestValue = (x1 > y1) && (x1 > z1) ? 1 : (y1 > z1) && (y1 > x1) ? 2 : (z1 > x1) && (z1 > y1) ? 3 : 0;

switch (highestValue)
{
    case 0:
        Console.WriteLine("Error ao encontrar o maior valor");
        break;
    case 1:
        Console.WriteLine($"O valor:{x1} é maior");
        break;
    case 2:
        Console.WriteLine($"O valor:{y1} é maior");
        break;
    case 3:
        Console.WriteLine($"O valor:{z1} é maior");
        break;
    default:
        Console.WriteLine("Error ao encontrar o maior valor");
        break;
}

