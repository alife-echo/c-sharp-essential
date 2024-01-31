// See https://aka.ms/new-console-template for more information
Console.WriteLine("Instrução for");
/*
for(int i = 1; i <= 10; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}X{j}={i*j}");
  
    }
    Console.WriteLine("\n");
}*/
/*
for(int i = 0, j = 0; i + j < 10; i++, j++)
{
    Console.WriteLine($"i = {i} e j {j}");
}
*/

int i = 1;
for(; i <= 5;)
{
    Console.WriteLine($"Loop for: Iteração {i}");
    i++;
}
