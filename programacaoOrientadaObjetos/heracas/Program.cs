// See https://aka.ms/new-console-template for more information
Console.WriteLine("Herança");


Funcionario func = new Funcionario();

func.Nome = "José";
func.Email = "jose@gmail.com";
func.Salario = 9000;
func.Identificar();

Aluno aluno = new Aluno();
aluno.Nome = "Richard";
aluno.Email = "bob@gmai.com";
aluno.Curso = "Mecatronica";
aluno.Nota = 3;
aluno.Identificar();




Console.ReadLine();


public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }    
}


public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }

}