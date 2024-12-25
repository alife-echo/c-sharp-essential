Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
Console.WriteLine();


string nome = "Curso C#";
string titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string";

valor = "Isto é uma string alterada";

valor = "teste";


object nota = 10;
object valor1 = 9.3m;
object nome1 = "bob";
object ativa = true;

dynamic nota3 = 2;
dynamic valor3 = 90.3m;

Console.WriteLine(nota3);
Console.WriteLine(valor3);

if (nota3 > nota)
{
    Console.WriteLine("MeuZovo");
}

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);

Console.ReadLine();
