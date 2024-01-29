// See https://aka.ms/new-console-template for more information
Console.WriteLine("Do while!");
/*
int i = 1;
do
{
    Console.WriteLine($"{i}");
    i++;
    if (i>7)
        break;
 
} while (i<=10);
*/
int x = 0;

do
{
    int y = 0;
    do
    {
     
        Console.Write($"({x},{y}) ");
        y++;
    } while (y < 5);
 x++;
} while (x < 5);