
using System.Text.Json.Serialization;

namespace serializacao_json
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        [JsonIgnore] // caso eu queira marcar uma propriedade para não ser serializada
        public string Email { get; set; } = string.Empty;

        //por padrão campos não são serializados, apenas propriedades
        public int Idade;

        public Aluno() { }
        public Aluno(int id, string nome, string email, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }


}
