using aggregation_operations;

string[] cursos = {"C#","Java","Python","PHP","Go","ASP.NET","Node"};

// contar todos os elementos
var numeroCursos = cursos.Count();

Console.WriteLine($"numero total de cursos:{numeroCursos}");

// contar todos os elementos atraves de uma condição
var cursosTemP = cursos.Count(c => c.Contains('P'));

// podemos aplicar outros metodos para fazer a condição e aplicar o Count no final
var cursosTemPoutraForma = cursos.Where(c => c.Contains('P')).Count();

Console.WriteLine($"Curso que tem a letra P : {cursosTemP}");

// contar elementos em uma coleção gigante
var elementosComLongCount = cursos.LongCount();


int[] numeros = { 3, 5, 7, 9, 10, 12, 15, 20, 30, 39 };

// aplicando a somatoria de todos os numeros normalmente
int resultadoSum = numeros.Sum();

Console.WriteLine($"A somatoria dos números é : {resultadoSum}");

// podemos aplicar a soma depois de um filtro feito 
int numerosMaiorQ10 = numeros.Where(n => n > 10).Sum();

Console.WriteLine($"numeros maior que 10 com filtro antes : {numerosMaiorQ10}");

//podemos aplicar um filtro dentro do sum com uma expressão lambda
// a expressão é uma sobrecarga em sum
int numerosMaiorQ10Lambda = numeros.Sum(n =>
{
    if (n > 10)
        return n;
    else
        return 0;
});

Console.WriteLine($"Somatoria dos numeros com expressão lambda :{numerosMaiorQ10Lambda}");


List<Funcionario> funcionarios = new()
{
    new Funcionario() {Nome = "Maria", Idade = 36, Salario = 3850.00m},
    new Funcionario() {Nome = "Manoel", Idade = 33, Salario = 2490.00m},
    new Funcionario() {Nome = "Amanda", Idade = 21, Salario = 5257.50m},
    new Funcionario() {Nome = "Bob", Idade = 18, Salario = 3000.50m},
    new Funcionario() {Nome = "Richard", Idade = 15, Salario = 2500.50m},
};

// obtendo o valor maximo de uma propriedade
int maiorIdade = funcionarios.Max(i => i.Idade);

// obtendo o valor maximo de uma propriedade
decimal maiorSalario = funcionarios.Max(s => s.Salario);

Console.WriteLine("Maior idade e maior salario");
Console.WriteLine($"{maiorIdade} - {maiorSalario}");


// obtendo o valor minimo de uma propriedade
int menorIdade = funcionarios.Min(i => i.Idade);

// obtendo o valor minimo de uma propriedade

decimal menorSalario = funcionarios.Min(s => s.Salario);

Console.WriteLine("Menor idade e menor salario");
Console.WriteLine($"{menorIdade} : {menorSalario}");

// obtendo um valor  max de um propriedade atraves de uma condição em outra propriedade
var salarioIdadeMaior30 = funcionarios.Max(s =>
{
    if (s.Idade > 30)
    {
        return s.Salario;
    }
    else
        return 0;
});

Console.WriteLine($"Maior salario das idade acima de 30:{salarioIdadeMaior30}");

// obtendo o valor minimo de uma propriedade atraves de uma condição estabelecida em outro propriedade
var salarioIdadeMenor20 = funcionarios.Where(s => s.Idade < 20).Min(s => s.Salario);

Console.WriteLine($"Menor salario das idades menor que 20:{salarioIdadeMenor20}");
