// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Inferencia tipos ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"Maria tem {idade} anos e ganha {salario.ToString("c")}");

// var limitações
var sal = null; // --> não é possivel atribuir um valor null
// -->Cannot assign 'expression' to an implicitly typed local

var titulo; // --> não é possivel só declarar a chave
// --> Implicitly typed locals must be initialized


var salario, imposto, total; // --> não é possivel encadear variaveis
// --> Implicitly-typed variables cannot have multiple declarators.
// --> Implicitly typed locals must be initialized



// não posso mudar o tipo apos inicializar
//Cannot implicitly convert type 'type' to 'type'
var num = 10;
num += 20;
num = "teste";


// posso utilizar o recurso na criação de classes
var test =  new Test();
test.MeuMetodo();
class Test
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}


// #  USOS DO VAR
// sugar syntax
// usado para declarar tipos anonimos
// usado em lações for e foreach
// usada em instruções using

Console.ReadKey();