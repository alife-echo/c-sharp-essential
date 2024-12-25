// See https://aka.ms/new-console-template for more information
Console.WriteLine("Instrução While II");

/*
int number;

while (true)
{
    Console.WriteLine("Digite um numero - (-1 Para Sair)");
    number = Convert.ToInt32(Console.ReadLine()); 
    switch(number % 2)
    {
        case 0:
            Console.WriteLine($" o {number} é par");
            break;
        case 1:
            Console.WriteLine($"o {number} é impar");
            break;
    }
    if(number == -1)
    {
        break;
    }
}
*/

int x = 0;

while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y})");
        y++;
    }
    x++;
    Console.WriteLine();
}

