// See https://aka.ms/new-console-template for more information
using ExercicioListT;
using System.Threading.Channels;

Console.WriteLine("List<T> - Exercício");


var alunos = new List<Aluno>();
Console.WriteLine("\n");
Aluno.MenuAluno();
for(;;)
{
    int opcao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");
    if (opcao == 1)
    {
       
        Aluno.ExbirDadosAluno(alunos);
        Aluno.MenuAluno();
    }
    else if (opcao == 2)
    {

            Console.WriteLine($"-------------------------------------------");
            Console.WriteLine("Informe o nome do aluno:");
            string nome = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Informe a nota do aluno:");
            int nota = Convert.ToInt32(Console.ReadLine());
            alunos.Add(new Aluno(nome, nota));
            Console.Clear();
            Aluno.MenuAluno();

    }
   else if (opcao == 3)
    {

            Aluno.ExbirDadosAluno(alunos);
            Console.WriteLine("Digite o Nome do aluno");
            string nomeAlunoExcluir = Console.ReadLine() ?? string.Empty;
            alunos.RemoveAt(alunos.FindIndex(a => a.Nome.Contains(nomeAlunoExcluir)));
            Console.Clear();
            Aluno.MenuAluno();


    }
    else if (opcao == 4)
    {

            Aluno.ExbirDadosAluno(alunos);
            Console.WriteLine("Digite o nome do aluno para localizar ou 6 para voltar");
            string nomeAlunoLocalizar = Console.ReadLine() ?? string.Empty;
            var aluno = alunos.Find(a => a.Nome.Contains(nomeAlunoLocalizar));
            Console.WriteLine($"Nome:{aluno?.Nome},Nota:{aluno?.Nota}");
            if(Convert.ToInt32(Console.ReadLine()) == 6 || Convert.ToInt32(nomeAlunoLocalizar) == 6)
            {
            Console.Clear();
            Aluno.MenuAluno();
            }
           
        
    }
   else if (opcao == 5)
    {
            Console.WriteLine("Digite a nota de corte ou -1 para sair");
            int notaCorte = Convert.ToInt32(Console.ReadLine());
            Aluno.FiltroNotas(alunos, notaCorte);
            if (Convert.ToInt32(Console.ReadLine()) == -1 || notaCorte == -1 || notaCorte < 0)
            {
                Console.Clear();
                Aluno.MenuAluno();
            }
        

    }
    else if (opcao == 6)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ocorreu um erro,contate o administrador");
    }
}
