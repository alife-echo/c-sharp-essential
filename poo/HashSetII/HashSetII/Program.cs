

var timesSP = new HashSet<string>(){"Santos","Palmeiras","São Paulo"};

var timesRJ = new HashSet<string>(){"Vasco","Flamengo","Fluminense"};

var timesBA = new HashSet<string>() { "Bahia","Vitória","Juazeiro"};

var timesMundiais = new HashSet<string>() {"Santos","Palmeiras","São Paulo","Flamengo"};

//verficar

if (!timesSP.Contains("Corinthians"))
{ 
    //Adicionar
    timesSP.Add("Corinthians");
    timesSP.Add("Santos");
}
//Remover
var resulltado = timesBA.Remove("Juazeiro");   
/*
//Verificar subconjunto
if (timesSP.IsSubsetOf(timesMundiais))
{
    Console.WriteLine("times SP é um subconjunto de times mundiais");
}

//Verificar superconjunto
if (timesMundiais.IsSupersetOf(timesSP))
{
    Console.WriteLine("Times mundiais é um super conjunto de times SP");
}

if (timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("Pelo menos um time do rio de janeiro tem título mundial");
}

if (!timesSP.SetEquals(timesRJ))
{
    Console.WriteLine("TimeSP e TimeRJ não contém os mesmos elementos");
}

Console.WriteLine("Juntando os HashSet<T>: SP,RJ e BA");
timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesBA);
ExibirColecao(timesSP);


Console.WriteLine("Juntando os times de SP,RJ e BA ordenados");
var todosTime = new SortedSet<string>(timesSP);
ExibirColecao(todosTime);
Console.WriteLine("\n");
*/

/*
Console.WriteLine("Intersecção HashSet<T> : times SP e times mundiais");
timesSP.IntersectWith(timesMundiais);
ExibirColecao(timesSP);*/

/*
Console.WriteLine("Diferença de dois HashSet<T> : times mundiais e timesSP");
timesMundiais.ExceptWith(timesSP);
ExibirColecao(timesMundiais);
*/

/*
//SymmetricExceptWith ==> retorna apenas os elmentos que não são comum entre os dois conjutos
Console.WriteLine("Diferenças de dois HashSet<T> : times mundiais e timesSP");
timesMundiais.SymmetricExceptWith(timesSP);
ExibirColecao(timesMundiais);
*/

timesMundiais.Clear();
Console.WriteLine("Remove todos os elementos de timesMundiais");
ExibirColecao(timesMundiais);

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    foreach (var time in colecao)
    {
        Console.WriteLine($"{time}");
    }
}