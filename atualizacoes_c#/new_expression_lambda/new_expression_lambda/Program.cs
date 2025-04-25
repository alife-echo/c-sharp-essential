Console.WriteLine("\n Novos Recursos Lambda \n\n");

Console.ReadKey();

// Inferir um tipo natural em lambdas

//SINTAXE NORMAL
Func<int,bool> isPositivo= (int x) => x > 0;
Console.WriteLine($"O numero 9 é positivo: {isPositivo(9)}");

Action<int> imprimir = (int i ) => Console.WriteLine(i);
imprimir(10);


// Nova sintaxe com inferencia de tipo

var isNewPositivo = (int x) => x > 0;

var isPositivoError = (int x) => x > 0;

Console.WriteLine($"O numero 3 é positivo ? : {isNewPositivo(3)}");


// Inferir um tipo “natural” para um grupo de métodos nas lambdas

// inferindo o tipo desse grupo de metodos
var leitor = Console.Read;

// error, pois tenho muitas sobrecargas
//var escritor = Console.Write;

var EntradaDoUsuario = Console.ReadLine;
var DizAoUsuario  = (string texto) => Console.WriteLine(texto);
var AguardarEnter = Console.ReadLine;


DizAoUsuario("Informe o nome do usuario:");
var nome = EntradaDoUsuario();
DizAoUsuario($"Olá {nome} tudo bem ?");
DizAoUsuario("Digite Enter para encerrar");
AguardarEnter();



// Definindo tipo de retorno em lambdas

var escolha = object (bool b ) => b ? 1 : "dois";

Console.WriteLine(escolha(false));




// Definindo atributos para um lambda


var imprimirBaseadoDia = [Agenda] (string texto) => Console.WriteLine(texto);

imprimirBaseadoDia("bob");

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public  abstract class ExampleAttribute : Attribute
{
    public abstract bool CanRun(DateTime data);
}

public class Agenda : ExampleAttribute
{
    public override bool CanRun(DateTime data) =>
        data.DayOfWeek is >= DayOfWeek.Sunday;
}

