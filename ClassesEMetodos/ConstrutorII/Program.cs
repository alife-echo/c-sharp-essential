// See https://aka.ms/new-console-template for more information
Console.WriteLine("Criando mais de um construtor");

Aluno aluno = new Aluno("Alife",22,"feminino","A");

Console.WriteLine(aluno?.Nome == null ? "null" : aluno?.Nome);
Console.WriteLine(aluno?.Idade == 0 ? 0 : aluno?.Idade);
Console.WriteLine(aluno?.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno?.Aprovado == null ? "null" : aluno.Aprovado);
public class Aluno
{   
    public Aluno(string nome)=>Nome = nome;    

    public Aluno(string nome ,int idade, string sexo, string aprovado):this(nome)
    {
        Idade = idade;
        Sexo = sexo;    
        Aprovado = aprovado;
    }
    public string Nome;
    public int Idade;
    public string Sexo;
    public string Aprovado;
}