
Console.WriteLine("Append");

List<int> numeros = new List<int> { 1, 2, 3, 4 };

numeros.Append(5);

// não funciona pois a lista original não foi alterada
Console.WriteLine(string.Join(", ",numeros)); // saida : 1 ,2 ,3 ,4

// 1 metodo de acessar a copia

// usando a copia alterada da lista original
Console.WriteLine(string.Join(", ",numeros.Append(5))); // saida : 1,2,3,4,5

// 2 metodo de acessar a copia

// armazenando em uma variavel
var resultado = numeros.Append(5);

Console.WriteLine(string.Join(", ",resultado));



// criando uma nova sequencia explicitamente
List<string> frutas = new List<string> {"Uva","Banana","Laranja"};

var novasFrutas = frutas.Append("Abacaxi").ToList();

Console.WriteLine(string.Join(", ", novasFrutas));



// Prepend

Console.WriteLine();
Console.WriteLine("Prepend");
numeros.Prepend(0);

// não altera a lista original
Console.WriteLine(string.Join(", ",numeros)); // saida : 1,2,3,4

// mesmo processo para o append para acessar

// usando a copia alterada da lista original
Console.WriteLine(string.Join(", ",numeros.Prepend(0)));

// armazenando em uma variavel
var resultado2 = numeros.Prepend(0);

Console.WriteLine(string.Join(", ",resultado2));

//criando uma nova sequencia explicitamente
var novasFrutas2 = frutas.Prepend("caju").ToList();

Console.WriteLine(string.Join(", ",novasFrutas2));





// Zip

Console.WriteLine();
Console.WriteLine("Zip");
// ele trabalha mesclando cada par de valor das duas sequencias, caso exista um valor que não possua par na outra sequencia ele ignora
int[] numerosZip = { 10, 20, 30, 40, 50 };

string[] palavrasZip = {"Dez","Vinte","Trinta","Quarenta"};

// passo a primeira fonte e segunda fonte
// depois posso acessar cada par(prim,seg) na interação e fazer uma personalização
var resultado3 = numerosZip.Zip(palavrasZip, (prim, seg) => prim + " - " + seg);

foreach(var par in resultado3)
{
    Console.WriteLine(par);
}

var seq1 = new[] {1,2,3};
var seq2 = new[] {10,20,30};

var resultado4 = seq1.Zip(seq2, (m, n) => m * n);

Console.WriteLine();
foreach (var resultadoMult in resultado4)
{
    Console.WriteLine(resultadoMult);
}


var estados = new[] { "São Paulo","Rio De Janeiro","Belo Horizonte" };
var siglas = new[] { "SP","RJ","BH" };

var resultado5 = estados.Zip(siglas, (e, s) => e + "-" + s);

Console.WriteLine();
foreach (var localizacao in resultado5)
{
    Console.WriteLine(localizacao);
}

