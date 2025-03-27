using quantification_operation;

int[] numeros = {10,22,32,44,56,64,78};

// avalia se todos os elementos na coleção são pares
var resultado = numeros.All(n => n % 2 == 0);

Console.WriteLine($"{(resultado ? "Todos são pares" : "Nem todos são pares")}");

List<Funcionario> funcionarios = new()
{
    new Funcionario() {Nome = "Maria", Idade = 32, Salario = 3850.00m},
    new Funcionario() {Nome = "Manoel", Idade = 33 , Salario = 2490.00m },
    new Funcionario() {Nome = "Amanda", Idade = 21 , Salario = 5257.50m }
};

// verificando se todos os salarios estão acima de 2500
var todosSalarioAcima2500 = funcionarios.All(f => f.Salario > 2500.00m);

// verificando se todas as idades são maiores que 21
var todosMaiorQue21 = funcionarios.All(f => f.Idade > 21);

// verificando se todos os nomes possuem a letra 'a'
var todosContemAletraA = funcionarios.All(f => f.Nome.Contains('a'));

Console.WriteLine($"{todosMaiorQue21} - {todosMaiorQue21} - {todosContemAletraA}");

var pessoasComCachorros = FonteDeDados.GetPessoas();

var cachorrosComIdadeMaior5 = pessoasComCachorros.Where(pessoa => pessoa.Cachorro.All(pet => pet.Idade > 5));


Console.WriteLine($"Donos que tem cachorros com idade maior que 5");

foreach (var nome in cachorrosComIdadeMaior5)
{
    Console.WriteLine(nome.Nome);

}


string[] cursos = { "C#", "Java", "Python", "PHP", "ASP.NET", "Node" };

// verificar se existe alguma valor
var existemCursos = cursos.Any();

// verificar se existem algum valor baseado em uma condição
var cursosTamanhoMaiorQue2 = cursos.Any(c => c.Length > 2);


Console.WriteLine($"Existem cursos ? {existemCursos} - Cursos com tamanho maior que 2 : {cursosTamanhoMaiorQue2}");


List<Cachorro> cachorros = new()
{
    new Cachorro() {Nome = "Bilu", Idade=6, Vacinado=true},
    new Cachorro() {Nome = "Canelinha", Idade=3, Vacinado=false},
    new Cachorro() {Nome = "Pipoca", Idade=8, Vacinado=true},
};

// verificando com mais condições
bool naoVacinadosAcimade2 = cachorros.Any(c => c.Idade > 2 && c.Vacinado == false);

Console.WriteLine($"{(naoVacinadosAcimade2 ? "Existem" : "Não existem")} cães com mais de 2 anos não vacinados");



List<Aluno> alunos = new List<Aluno>()
{
    new Aluno() {Nome = "Maria", Pontos = 275},
    new Aluno() {Nome = "Marta", Pontos = 375},
    new Aluno() {Nome = "Pedro", Pontos = 299},
};

AlunoComparer alunoComparer = new AlunoComparer();

var aluno1 = new Aluno() { Nome = "Maria", Pontos = 275 };


var resultado1 = alunos.Contains(aluno1, alunoComparer);

Console.WriteLine($"{resultado1}");