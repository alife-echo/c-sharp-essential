// See https://aka.ms/new-console-template for more information
using PessoaExercicioArrays;
using ExercicioArrayListArrayList;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
/*
Console.WriteLine("Exercicio Array Unidimensional");
string[] frutas = new string[10]{"Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego","Amora"};
Console.WriteLine($"Quantidade elementos:{frutas.Length}");
Console.WriteLine($"Primeira fruta:{frutas[0]}");
Console.WriteLine($"Penultima Fruta:{frutas[frutas.Length - 2]}");
frutas[2] = "Kiwi";
frutas[frutas.Length - 1] = "Caqui";
Console.WriteLine("Ordenado:");
Exibir(frutas.OrderBy(f => f).ToArray());
frutas.Reverse();
Console.WriteLine("Inverso:");
Exibir(frutas.Reverse().ToArray());
static void Exibir(string[] frutas)
{
foreach (string fruta in frutas)
{
Console.Write($"{fruta} ");
}
Console.WriteLine("\n");
}
*/
/*
Console.WriteLine("Digite quantos valores vai inserir");
int tam = Convert.ToInt32(Console.ReadLine());
int[] arrayValores = new int[tam];
Console.WriteLine("Preencha os valores");
for (int i = 0; i < arrayValores.Length; i++)
{
      arrayValores[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Digite o valor a procurar no array");
int valor = Convert.ToInt32(Console.ReadLine());
int procurarValor = arrayValores.FirstOrDefault(v => v == valor);
Console.WriteLine($"Valor:{(procurarValor == 0 ? "Valor não existe":procurarValor)}");
Console.WriteLine("Fim");
*/
/*
float[,] notas = new float [2, 5];
float grupo1 = 0;
float grupo2 = 0;
Console.WriteLine("Digite as notas para o grupo 1 e grupo 2");
for (int i = 0; i < notas.GetLength(0); i++)
{
     for (int j = 0; j < notas.GetLength(1); j++)
    {
        Console.WriteLine($"[{i}][{j}]");
        float valor = Convert.ToInt32(Console.ReadLine());
        notas[i, j] = valor;
        if(i == 0)
        {
            grupo1 += valor;    
        }
        if(i == 1)
        {
            grupo2 += valor;
        }
    }
}
Console.WriteLine(grupo1);
Console.WriteLine(grupo2);
Console.WriteLine($"Media Grupo 1:{grupo1/notas.GetLength(1)}");
Console.WriteLine($"Media Grupo 2:{grupo2/notas.GetLength(1)}");
*/

/*
ArrayList pessoas = new ArrayList();
List<string> f = new List<string>();
int lim = 3;
for (int i = 0; i < lim; i++)
{
    Console.WriteLine("Nome:");
    string nome = Console.ReadLine() ?? String.Empty;
    Console.WriteLine("Idade:");
    int idade = Convert.ToInt32(Console.ReadLine());
    pessoas.Add(new Pessoa(nome,idade));
}

foreach (Pessoa pessoa in pessoas)
{
    f.Add(pessoa.ToString());
}
f.RemoveAt(f.Count - 1);
var format_separator_pessoas = string.Join(" - ", f);
Console.WriteLine(format_separator_pessoas);*/

string[] produtosNome = new string[5] {"Clips","Caneta","Lápis","Estojo","Caderno"};

double[] produtosPreco = new double[5] {3.95,5.99,4.15,6.99,7.55};

List <Produto> lista_produto = new List<Produto>();

for (int i = 0;i<5;i++)
{
    lista_produto.Add(new Produto(produtosNome[i], produtosPreco[i]));
}
Console.WriteLine("Lista");

Produto.ExibirDadosProduto(lista_produto);

lista_produto.Add(new Produto("Mochila", 22.44));

Console.WriteLine("------- Lista Ordenada --------");

Produto.ExibirDadosProduto(lista_produto.OrderBy(p => p.Nome).ToList());

Console.WriteLine("\n");

Console.WriteLine("------- Lista Filtrada --------");

Produto.ExibirDadosProduto(lista_produto.Where(p => p.Preco < 5.00).ToList());
static void processaObjetos(params object[] objects)
{
   Console.WriteLine("--------- Valores ---------");
   foreach (object obj in objects)
    {
        Console.WriteLine($"{obj},{obj.GetType()}");
    }

}
processaObjetos(1, "Maria", 3.45m, new Produto("meu zovo", 13.2));


Aluno a =  new Aluno(); 
for (int i = 0; i < 10; i++)
{
    a[i] = "Alife";
    Console.WriteLine(a[i]);
}