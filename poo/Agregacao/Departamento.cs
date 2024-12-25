namespace Agregacao;
public class Departamento
{
    public string? Nome { get; set; }   
    private List<Professor>? Professores { get; set; }

    public void IncluirProfessor(Professor professor)
    {
       Professores?.Add(professor);
       
    }
    public Departamento(string? nome)
    {
        Nome = nome;
        Professores = new List<Professor>();
    }
    public void ListaProfessores()
    {
        Console.WriteLine($"\nDepartamento de : {Nome}");
        if(Professores?.Count > 0) {
         foreach (Professor prof in Professores)
        {
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
        }
        }
       
    }

}

