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
/*
Console.WriteLine("Maneira 1");
for (int i = 10; i <= 20; i += 2)
{
    if (i == 16)
        continue;
    Console.WriteLine($"{i}");
}
Console.WriteLine("Maneira 2");
for (int j = 10; j<= 20; j++)
{
    if (j % 2 == 1)
        continue;
    if (j == 16)
        continue;
    Console.WriteLine($"{j}");
}
Console.WriteLine("Maneira 3");
for (int h = 10; ; h+=2)
{
    if (h == 16)
        continue;
    if (h > 20)
        break;
    Console.WriteLine($"{h}");
}*/
/*
string? star = "";
for(int i = 1; i <=1; i++)
{
    for(int j = 0; j <=4; j++)
    {
        star += "*";
        Console.WriteLine($"{star}");
    }
    Console.WriteLine("\n");
} 
*/
/*
int factor,result = 1;
Console.WriteLine("Digite um número para calcular fatorial:");
factor = Convert.ToInt32(Console.ReadLine());
for(int i = factor; i >= 1; i--)
{
    result *= i;
}
Console.WriteLine($"{result}");
*/
/*
int count = 2;
while (count <= 6)
{
    int x = 1;
    while (x <= 10)
    {
        Console.WriteLine($"{count}X{x} = {count * x}");
        x++;
    }
    Console.WriteLine("\n");
    count++;
}*/
/*
int nota;
while (true)
{
    Console.WriteLine("Digite a nota do aluno (999) sair");
    nota = Convert.ToInt32(Console.ReadLine());
    if (nota > 0 && nota <= 10)
    {
        switch (nota)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                Console.WriteLine("F");
                break;
            case 5:
                Console.WriteLine("E");
                break;
            case 6:
                Console.WriteLine("C");
                break;
            case 7:
            case 8:
                Console.WriteLine("B");
                break;
            case 9:
                Console.WriteLine("A");
                break;
            case 10:
                Console.WriteLine("A+");
                break;
            default:
                Console.WriteLine("Erro contate a administração");
                break;

        }
    }
    if (nota == 999)
        break;
    if (nota < 0)
    {
        Console.WriteLine("Informe os dados corretamente");
    }
}
*/
while (true)
{
    Console.WriteLine("Informe o primeiro número:");
    double v1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe o operando (+,-,/,*):");
    string? operating = Console.ReadLine();
    Console.WriteLine("Informe o segundo número:");
    double v2 = Convert.ToDouble(Console.ReadLine());   
    if((v1 == 0 || v2 == 0) && operating == "/")
    {
        Console.WriteLine("Não existe divisão por zero!!!");
    }
   if(v1 >= 0 && v2 >= 0)
    {
        switch (operating)
        {
            case "+":
                Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
                break;
            case "-":
                Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
                break;
            case "*":
                Console.WriteLine($"{v1} * {v2} = {v1 * v2}");
                break;
            case "/":
                Console.WriteLine($"{v1} / {v2} = {v1 / v2}");
                break;
            default:
                Console.WriteLine("Error contate a administração");
                break;
        }
    }
   else
    {
        Console.WriteLine("Error informe os dados corretamente");
    }
    Console.WriteLine("Sair (-1)");
    int quit = Convert.ToInt32(Console.ReadLine());
    if (quit == -1) 
        break;

}