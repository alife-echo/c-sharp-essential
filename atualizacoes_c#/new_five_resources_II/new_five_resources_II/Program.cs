
var texto = """Literal de string bruta """;

// as aspas duplas detro da string bruta se comportam como conteudo
var texto2 = """ Isto é uma "raw string literal" """;

var meuJson = """
                    "nome":"macoratti",
                    "pais":"Brasil"
              """;

Console.WriteLine(texto);
Console.WriteLine(texto2);
Console.WriteLine(meuJson);

// a expessão dentro dos colchetes sera resolvida

var resultado1 = $""" 21 + 34 = {21 + 34} """;

var resultado2 = $"""
                 
                 21 + 34 = {21 + 34}
                  
                 """;

Console.WriteLine(resultado1);
Console.WriteLine(resultado2);

// usando dois $$
// os {} serão vistos como conteudo
// os {{}} serão resolvidos
// usado caso eu queira usar colchetes para expressar algo

var resultado3 = $$""" {21 + 34} == {{21 + 34}} """; 

var resultado4 = $$"""
                    21 + 34 = {{21 + 34}}
                   """;

Console.WriteLine(resultado3);                    
Console.WriteLine(resultado4);

var nome = "Turma A";
var alunos = new List<string> { "Álife","Bob","Richard","Nandson","Raquel" };

var exemploJson = $$"""
                    {
                      "nome":""{{nome}}",
                      "alunos":"{{string.Join(",",alunos)}}"
                    }
                  """;
Console.WriteLine(exemploJson);  






// List pattern


// Discard pattern

// lista de numeros
int[] numeros = { 1, 2, 3, 4, 5, 8 };

var resultadoD = false;

// estou comparando a quantidade de elementos que existe nas duas lista
// assim como se o numero 1 esta presente no primeiro indice da lista de numeros
var comparacao = numeros is [1, _, _, _, _,_]; // true

Console.WriteLine(comparacao);

// false pois os elementos não corresponde e a quantidades de elementos nas duas não são iguais
var resultadoD2 = numeros is [2, _, 3, _, _];
Console.WriteLine(resultadoD2);

object obj = "Olá, mundo!";

// se objet for uma string executa o if, eu não preciso capturar seu valor _
if(obj is string _)
    Console.WriteLine("obj é uma string, mas não precisa de uma variavel para capturar o valor");





object obj2 = 42;


switch (obj2)
{
    case int _:
        // se obj2 for int executa o case, eu não preciso capturar seu valor _
        Console.WriteLine("É um inteiro");
        break;
    case string _:
        // se obj2 for string executa ocase, eu não preciso do seu valor _
        Console.WriteLine("É um string");
        break;
    default:
        Console.WriteLine("Outro tipo");
        break;
}





// Range Operator



var numerosO = new int[] { 10,20,30,40,50};
// pega do indice 1 ate 3 mas não inclui o 4
var fatia = numeros[1..4];

// do começo ate o indice 5
var doComeco = numeros[..5];

// pega do indice 0 ate o fim
var doFim = numeros[0..];


var resultadoO = false;

// verifica se existe o numero 50 no final da lista
resultadoO = numeros is [.., 50];

// percorre toda a lista verificando se existe o numero 40 como penultimo e ignora o ultimo elemento
resultadoO = numerosO is [..,40,_];

Console.WriteLine(resultadoO);

// posso fazer uma comparação e capturar um valor ou mais, deste que respeita a estrutura
if (numerosO is [.., var penultimo, var ultimo])
{
    Console.WriteLine($"Penultimo:{penultimo}");
    Console.WriteLine($"Ultimo:{ultimo}");
}
else
    Console.WriteLine("O padrão não corresponde");