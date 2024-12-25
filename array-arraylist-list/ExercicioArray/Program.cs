// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio Array");

string[] nomesAlunos = new string[5];
double[] notasAlunos = new double[5];   

for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome do [{i}]-Aluno:");
    string? nome = Console.ReadLine();
    nomesAlunos.SetValue(value:nome, index: i);
    Console.WriteLine($"Digite a nota do [{i}]-Aluno:");
    double nota = Convert.ToDouble(Console.ReadLine());
    notasAlunos.SetValue(value:nota, index: i);
}

ExibirInformacoes(nomesAlunos);
ExibirInformacoes(notasAlunos);
Media(notasAlunos);
\
static void Media(double[] medias)
{
    Console.WriteLine($"Media turma:{medias.Average()}");
}

static void ExibirInformacoes<T>(T[] informacoes)
{
    foreach(T info in informacoes)
    {
        Console.WriteLine(info);
    }
}