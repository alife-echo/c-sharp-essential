
// Take
List<int> numeros = new List<int> {1,2,3,4,5,6,7,8,9,10};

var quatroPrimeiros = numeros.Take(4);

Exibir(quatroPrimeiros,"ToTake");

// Take com ordenação
List<int> numerosDesordenados = new List<int> { 1, 3, 7, 10, 5, 8, 6, 9, 4, 2 };

var cincoPrimeirosDesc = numerosDesordenados.OrderByDescending(n => n).Take(5);

Exibir(cincoPrimeirosDesc, "Take com ordenação");

// Take com ordenação e Filtro
var quatroPrimeiroOrderMore5 = numerosDesordenados.OrderBy(n => 5).Where(n => n > 5).Take(4);

Exibir(quatroPrimeiroOrderMore5, "Take com ordenação e Filtro");

//Filtrando apos aplicar o Take
// Cuidado : A localização do Take pode mudar toda logica da consulta
// No codigo abaixo retornará 4 devido a esse numero ser maior que 3 dos 4 primeiros numeros obtidos do take
var quatroOrdenadoMaior3 = numerosDesordenados.OrderBy(n => n).Take(4).Where(num => num > 3);

Exibir(quatroOrdenadoMaior3, "Filtrando apos o Take");


// Se a fonte de dados for NULL será lançado um ArgumentNullException
//List<int> listaNull = null;
//var consultaNull = listaNull.Where(num => num > 3).Take(4);

//Exibir(consultaNull, "Consulta em um fonte null");




//TakeWhile

// Retornando os numeros menor que 6 e ignorando o resto
var numerosMenor6 = numeros.TakeWhile(num => num < 6);

Exibir(numerosMenor6, "TakeWhile");


//Diferença entre TakeWhile e Where
List<int> numerosDesordenados2 = new List<int> {1,2,3,6,7,8,9,10,4,5};

// ao chegar no valor 3 o TakeWhile ignora o restante posterior, pois não satisfaz a condição
// mesmo que alguns elementos posteriores possam ter valores que satisfazem a condição
var resultado1 = numerosDesordenados2.TakeWhile(num => num < 6); // 1,2,3
Exibir(resultado1, "Resultado com TakeWhile");

//Enquanto o Where vai do inicio ate o final verificando e retornando os valores que satisfazem a condição
var resultado2 = numerosDesordenados2.Where(num => num < 6); // 1,2,3,4,5
Exibir(resultado2, "Resultado com Where");

// usando a segunda sobrecarga do método (usando o indice na logica da condição)

List<string> nomes = new List<string> {"Sara","Raul","José","Ana","Pedro"};

// posso usar o takewhile para acessar o valor e indice de uma lista
// a segunda sobrecarga é do tipo Int32
// acessando os nomes em que sua quantidade de caracteres é maior que o numero do seu indice
var resultadoNomes = nomes.TakeWhile((nome, index) => nome.Length > index);

Exibir(resultadoNomes, "TakeWhile com sobrecarga");
static void Exibir<T>(IEnumerable<T> collection, string message)
{
    Console.WriteLine(message);
    foreach(var value in collection)
    {
        Console.Write($"{value} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}




// Skip

// Vou ignorar os 4 primeiros numeros e retornar o resto
var pular4Primeiros = numeros.Skip(4);

Exibir(pular4Primeiros, "Skip");

//Filtrando e aplicando skip
var filtrandoComSkip = numeros.Where(num => num > 3).Skip(4);

Exibir(filtrandoComSkip, "Filtrando e aplicando skip");

// Colcando skip antes do filtro
// Cuidado com a localização do skip, pois mudar a logica da consulta

var skipAntes = numeros.Skip(4).Where(num => num < 7);

Exibir(skipAntes, "Skip antes do filtro");






// SkipWhile

// ignorando os elementos menores que 5 e retornando o resto
var skipWhileNormalNumeros = numeros.SkipWhile(num => num < 5);

Exibir(skipWhileNormalNumeros, "SkipWhile");


var numerosDesordenados3 = new List<int> {1,4,5,6,7,8,9,10,2,3};

//Cuidado : pois da mesma maneira que o takewhile o skipwhile vai ignorar ate onde a condição for verdadeira
// mesmo que o restante retornado estaja elementos true para a condição
var skipVerificacaoOrdem = numerosDesordenados3.SkipWhile(num => num < 5);

Exibir(skipVerificacaoOrdem, "SkipWhile");


var skipWhile3Sobrecarga = nomes.SkipWhile((nome, index) => nome.Length > index); // Ana Pedro

Exibir(skipWhile3Sobrecarga, "SkipWhile com 3 sobrecarga"); 