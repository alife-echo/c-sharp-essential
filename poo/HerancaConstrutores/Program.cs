// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Aluno aluno1 = new Aluno();
Aluno aluno2 = new Aluno("Jose");

Console.ReadKey();


class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Constrotor da classe pessoa Com Parametro");
    }
}

//derivada
class Aluno : Pessoa
{
     public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }
    public Aluno(string nome) : base(nome)  
    {
        Console.WriteLine("Construtor da classe Aluno com parametro");
    }
}