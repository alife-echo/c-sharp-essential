// See https://aka.ms/new-console-template for more information
Console.WriteLine("Break e Continue");
/*
for(; ; )
{
    Console.WriteLine("Tecle algo (x-sair)");
    string? value = Console.ReadLine();

    Console.WriteLine(value?.ToUpper());

    if(value == "x" || value == "X")
    {
        break;
    }

}
Console.WriteLine("\n fim do processamento");
Console.ReadKey();
*/

/*
for(int i = 0; i < 10; i++)
{
    if(i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}*/

/*
int n = 1;
while (n <= 10)
{
    if(n == 5)
    {
        n = n + 1;
        continue;
    }
    Console.WriteLine($"n={n}");
    n++;
}*/

for(int i = 0; i < 10; i++)
{
    if (i == 5)
        continue;
    if (i > 8)
        break;
    Console.WriteLine($"{i}");
}
