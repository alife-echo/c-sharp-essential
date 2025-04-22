

using records_II;

var cliente1 = new Cliente("Álife",30);

Console.WriteLine(cliente1.Nome);
Console.WriteLine(cliente1.Idade);


var (nome,idade) = cliente1;

Console.WriteLine(nome);
Console.WriteLine(idade);


var cliente2 = cliente1 with { Nome = "Bob" };

Console.WriteLine(cliente2.Nome);
Console.WriteLine(cliente2.Idade);


var (nome1, idade1) = cliente2;

Console.WriteLine(nome1);
Console.WriteLine(idade1);



var aluno = new Aluno()
{
    Nome = "Megan",
    Email = "meganfox@gmail.com",
    Curso = "T.i"
};

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Email);
Console.WriteLine(aluno.Curso);