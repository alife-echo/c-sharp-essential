// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arrays MultiDimensionaisII");


int[,] array1 = new int[2, 3] { { 1, 4, 2 }, { 3, 6, 8 } };

int[,] array2 = new int[2, 3] { {2,9,3}, {5,1,4} };


for(int i = 0; i < array1.GetLength(0); i++)
{
    for(int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i,j]);
    }
    Console.WriteLine();
}
Console.WriteLine("Foreach");
foreach (int n in array2)
{
    Console.Write(n);
}