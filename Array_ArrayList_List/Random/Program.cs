// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

/*
Random random = new Random();

Console.WriteLine(random.Next());
Console.WriteLine(random.Next(20));
Console.WriteLine(random.Next(0,20));
Console.WriteLine(random.NextDouble());

Random random2 = new Random(2023);


for (int i = 0; i < 20; i++)
{
    Console.WriteLine(random2.Next(0,100));
}

byte[] randBytes = new byte[10];
random2.NextBytes(randBytes);   

for (int i = 0;i < randBytes.Length;i++)
{
    Console.Write($"{randBytes[i]} ");
}*/

Console.WriteLine("Sorteio MegaSena \n");

Random random = new Random();
int[] numerosSorteados = new int[6];
for (int i = 0; i < numerosSorteados.Length; i++)
{
    int numeroAleatorio;

    do
    {
        numeroAleatorio = random.Next(1, 61);
    } while (numerosSorteados.Contains(numeroAleatorio));
    numerosSorteados[i] = numeroAleatorio;

}
Array.Sort(numerosSorteados);
Console.WriteLine("Números Sorteados \n");
Console.WriteLine(string.Join(" ",numerosSorteados));
Console.ReadKey();