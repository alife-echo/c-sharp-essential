using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListT;
public class Aluno
{
    private string? nome;
    private int nota;
    public string Nome { get => string.IsNullOrEmpty(nome) ? "" : nome; set => nome = value; } 
    public int Nota { get => nota; set { if (nota < 0) { nota = 0; } else { nota = value; } } }
    public Aluno() { }
    public Aluno(string nome,int nota)
    {
        this.Nome = nome;
        this.Nota = nota;
    }
   public static void ExbirDadosAluno (List<Aluno> alunos)
    {
        Console.WriteLine($"\n----------------- ALUNOS - ORDENADO -----------------");
        var sortedAlunos = alunos.OrderBy(a => a.Nome).ToList();  
        for (int i = 0; i < sortedAlunos.Count; i++)
        {
            Console.WriteLine($"Nome:{alunos[i].Nome},Nota:{alunos[i].Nota}");
        }
        Console.WriteLine($"\n-----------------------------------------------------");
    }
    public static void MenuAluno()
    {
        Console.WriteLine($"----------------- SIGAA 2 -----------------");
        Console.WriteLine($"Sececione As Opções Para Alunos");
        Console.WriteLine($"1 - Exibir Alunos");
        Console.WriteLine($"2 - Adicionar Aluno");
        Console.WriteLine($"3 - Excluir Aluno");
        Console.WriteLine($"4 - Localizar Aluno");
        Console.WriteLine($"5 - Exibir Alunos com nota maior que a nota de corte");
        Console.WriteLine($"6 - Sair Sistema");
        Console.WriteLine($"-------------------------------------------");

    }
    public static void FiltroNotas (List<Aluno> alunos,int notaCorte)
    {
        var filtro = alunos.Where(a => a.Nota > notaCorte).ToList();
        Console.WriteLine($"Aluno com nota maior que {notaCorte}");
        foreach (Aluno a in filtro)
        {
            Console.WriteLine($"Nome:{a.Nome},Nota:{a.Nota}");
        }
    }
}
