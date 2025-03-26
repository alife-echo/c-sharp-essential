using aggregation_operation;

string[] cursos = { "C#", "Java", "Pyhton", "PHP", "GO" };

string resultado = cursos.Aggregate((s1, s2) => s1 + ", " + s2);

Console.WriteLine(resultado);
/*
 
 s1 começa com = C#
 s2 começa com = Java
 a expressão (s1, s2) => s1 + ", " + s2 é aplicada
 valor da expressão é C#, Java
 porem s1 armazena o resultado dessa expressão
 s1 = C#, Java
 s2 agora é Python
 a expressão (s1, s2) => s1 + ", " + s2 é aplicada
 s1 = C#, Java, Python
 assim até completar a lista
 entendimento = s1 é um acumulador e guarda as expressões apenas somando com ", " + s2
 */

Console.WriteLine();

int[] numeros = { 3, 5, 7, 9, 10 };

int total = numeros.Aggregate((n1, n2) => n1 * n2);

Console.WriteLine(total);


// segunda sobrecarga

List<Aluno> alunos = new()
{
    new Aluno {Nome = "Maria", Idade = 36},
    new Aluno {Nome = "Manoel", Idade = 33},
    new Aluno {Nome = "Amanda", Idade = 21},
};

string listaAlunos = alunos.Aggregate<Aluno, string, string>
    (
       "Nomes: ",
       (semente, aluno) => semente += aluno.Nome + ",",
       resultado => resultado.Substring(0, resultado.Length - 1)
    );

var mediaIdades = alunos.Average(a => a.Idade);
Console.WriteLine($"Média de idades: {mediaIdades} anos");
/*
 * 
int indice = listaAlunos.LastIndexOf(",");
listaAlunos = listaAlunos.Remove(indice);
*/
Console.WriteLine(listaAlunos);

