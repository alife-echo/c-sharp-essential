// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arrays Bidimensionais Exercicio !");


string[,] alunos = new string[2, 5];

for(int i = 0; i < alunos.GetLength(0); i++)
{
    for(int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Digite o nome para o aluno:[{i}][{j}]");
        string? nomeAluno = Console.ReadLine();
        alunos[i, j] = String.IsNullOrEmpty(nomeAluno) ? "" : nomeAluno;
    }
}

Console.WriteLine("\n");

for (int i = 0;i < alunos.GetLength(0); i++)
{
    for (int j = 0;j < alunos.GetLength(1);j++)
    {
        Console.Write($"[{i},{j}] = {alunos[i,j]}, ");
    }
    Console.WriteLine();    
}
