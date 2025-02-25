
namespace exercicio_serialization;
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int Idade { get; set; }

        public Aluno() { }
        public Aluno(int id, string nome, string email, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    
}

