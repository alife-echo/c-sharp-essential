// See https://aka.ms/new-console-template for more information
Console.WriteLine("ArraysII");

string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
}
Console.WriteLine("-------------------------------------------");
for (int i = 0;i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {nomes[i]}");
}