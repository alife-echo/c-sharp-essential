// AsEnumerable

using System.Collections;
using System.Linq.Expressions;

int[] numeros = { 1, 2, 3, 4, 5 };

// convertendo um array para IEnumerable
var resultado = numeros.AsEnumerable();

Exibir("AsEnumerable",resultado);
    

var paises = new List<string> {"US","India","UK","Australia","Canada"};

Exibir("de List para IEnumerable", paises);




// AsQueryable
List<int> numerosAleatorios = new List<int> { 78, 92, 100, 37, 81 };

IQueryable<int> resultado2 = numerosAleatorios.AsQueryable();

// Expression representa uma expressão lambda fortemente tipada
Expression expressionTree = resultado2.Expression;

Console.WriteLine("O nodetype da árvore de expressão é : " + expressionTree.NodeType.ToString());

Console.WriteLine(" O tipo da árvore  de expressão é : " + expressionTree.Type.Name);


Exibir("AsQueryAble", collectionQuery: resultado2);




var numerosAleatorios3 = new int[] {5,10,20,60,72,90,102,114};

// Queryable fornece um conjunto de métodos para consultar uma estrutura de dados que implementa IQueryable
double media = Queryable.Average(numerosAleatorios3.AsQueryable());
int soma = Queryable.Sum(numerosAleatorios3.AsQueryable());
int conta = Queryable.Count(numerosAleatorios3.AsQueryable());
int maximo = Queryable.Max(numerosAleatorios3.AsQueryable());
int min = Queryable.Min(numerosAleatorios3.AsQueryable());


var listaOperacoes = new List<int>{(int)media, soma,conta,maximo,min}.AsQueryable();

Exibir("metodos IQueryable", collectionQuery: listaOperacoes);




//Cast

ArrayList list = new ArrayList { 10,20,30 };

IEnumerable<int> resultado3 = list.Cast<int>(); // convertendo ArrayList para um IEnumerable<int>

// se eu tentar adicionar um valor que não seja do novo tipo eu obtereri uma exception
//list.Add("40"); // ERROR --> InvalidCastException

Exibir("Cast", collection: resultado3);



//OfType

List<object> dados = new List<object>()
{
    "Tania","Maria",50,"Manoel",10,20,30,40,"Tiago"
};

var dadosInt = dados.OfType<int>().ToList();

Exibir("Obtendo um tipo especifico com OfType", collection: dadosInt);

// posso aplicar um filtro
var dadosIntComFiltro = dados.OfType<int>().Where(num => num > 30).ToList();

Exibir("OfType com filtro", collection: dadosIntComFiltro);

static void Exibir<T>(string title,IEnumerable<T>? collection = null, IQueryable<T>? collectionQuery = null)
{
    Console.WriteLine();
    Console.WriteLine(title);
    foreach (var value in collection ?? collectionQuery ?? Enumerable.Empty<T>())
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}