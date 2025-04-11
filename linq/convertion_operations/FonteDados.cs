

namespace convertion_operations;
class FonteDados
{
    public static IEnumerable<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
    {
        new Aluno() { Id = 1, Nome = "Maria", EnderecoId = 1, CursoId = 10 },
        new Aluno() { Id = 2, Nome = "Manoel", EnderecoId = 2, CursoId = 20 },
        new Aluno() { Id = 3, Nome = "Amanda", EnderecoId = 3, CursoId = 30 },
        new Aluno() { Id = 4, Nome = "Carlos", EnderecoId = 4, CursoId = 10 },
        new Aluno() { Id = 5, Nome = "Jaime", EnderecoId = 5, CursoId = 30 },
        new Aluno() { Id = 6, Nome = "Debora", EnderecoId = 6, CursoId = 40 },
        new Aluno() { Id = 7, Nome = "Alicia", EnderecoId = 7, CursoId = 10 },
        new Aluno() { Id = 8, Nome = "Sandra", EnderecoId = 8, CursoId = 40 },
        new Aluno() { Id = 9, Nome = "Marta", EnderecoId = 3, CursoId = 0 },
        new Aluno() { Id = 10, Nome = "Sueli", EnderecoId = 2, CursoId = 30 },
    };

        return alunos.AsEnumerable();
    }
}
