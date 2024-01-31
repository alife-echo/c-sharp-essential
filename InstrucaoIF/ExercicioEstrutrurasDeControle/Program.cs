// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio Estruturas de controle");
/*
int x1 = 0, y1 = 0, z1 = 0;

Console.WriteLine("Digite o primeiro numero");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro numero");
z1 = Convert.ToInt32(Console.ReadLine());

int highestValue = (x1 > y1) && (x1 > z1) ? 1 : (y1 > z1) && (y1 > x1) ? 2 : (z1 > x1) && (z1 > y1) ? 3 : 0;

switch (highestValue)
{
    case 0:
        Console.WriteLine("Error ao encontrar o maior valor");
        break;
    case 1:
        Console.WriteLine($"O valor:{x1} é maior");
        break;
    case 2:
        Console.WriteLine($"O valor:{y1} é maior");
        break;
    case 3:
        Console.WriteLine($"O valor:{z1} é maior");
        break;
    default:
        Console.WriteLine("Error ao encontrar o maior valor");
        break;
}
*/
/*
int   a,b,c;
double x1, x2, delta;
Console.WriteLine("Informe o valor de a:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de b:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de c");
c = Convert.ToInt32(Console.ReadLine());
delta = Math.Pow(b, 2) - 4 * a * c;
x1 = (-b + Math.Sqrt(delta))/(2 * a) ;
x2 = (-b - Math.Sqrt(delta)) / (2 * a);

if(delta > 0)
{
    Console.WriteLine("As raizes são reais e diferentes");
    Console.WriteLine($"Primeira raiz x1={x1}");
    Console.WriteLine($"Segunda raiz x2={x2}");
}
else if (delta == 0)
{
    Console.WriteLine("As raizes são reais e iguais");
    Console.WriteLine($"Primeira raiz x1={x1}");
    Console.WriteLine($"Segunda raiz x2={x2}");
}
else
{
    Console.WriteLine("As raizes são complexas ou imaginarias");
}
*/

int swap = 0;
/*
Console.WriteLine("Os 10 primeiros números naturais são:");
for (int i = 1; i <= 10; i++)
{
    Console.Write($" {i}");
    swap += i;
}
Console.WriteLine("\n");
Console.WriteLine($"A soma dos números é:{swap}");*/


/*
int i = 1;
Console.WriteLine("Os 10 primeiros números naturais são:");
do
{
    Console.Write($" {i}");
    swap += i;
    i++;
} while (i <= 10);
Console.WriteLine("\n");
Console.WriteLine($"A soma dos números é:{swap}");
*/
/*
Console.WriteLine("Os 10 primeiros números naturais são:");
while (i <= 10)
{
    Console.Write($" {i}");
    swap += i;
    i++;
}
Console.WriteLine("\n");
Console.WriteLine($"A soma dos números é : {swap}");
*/
/*
int x;
while (true){
    Console.WriteLine("Digite um número (-1 sair)");
    x = Convert.ToInt32(Console.ReadLine()); 
    if( x > 0)
    {
        for(int i = 1; i <= 10; i++) {
            Console.WriteLine($"{i}X{x}={i*x}");
        }
    }
    if (x == -1)
    {
        break;
    }
    if ( x < 0 || x == 0 )
    {
        Console.WriteLine("Informe um valor corretamente");
    }
    
}
*/
/*
bool x = true;
string? correctValue;
while (x)
{
    Console.WriteLine("Qual a instrução para sair de um loop ?");
    Console.WriteLine("a.quit");
    Console.WriteLine("b.continue");
    Console.WriteLine("c.break");
    Console.WriteLine("d.exit");
    Console.WriteLine("Qual a opcção correta ? (Tecle x para sair)");
    correctValue = Console.ReadLine();
    if (correctValue == "x" || correctValue == "X")
    {
        x = false;
    }
    else if (correctValue != "c") {
        Console.WriteLine("Resposta errada");
    }
    if(correctValue == "c") {
        Console.WriteLine("Resposta correta");
    }
}*/