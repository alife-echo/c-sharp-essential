// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Aluno aluno = new Aluno();
aluno.Nome = "Maria";
aluno.Curso = "Qumico";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, Eu sou o(a) {Nome}";

}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao() => $"Oi, Eu sou o(a) {Nome} do curso de : {Curso}";
}