// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operador Térnario");

int positivo = 2;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);

Console.WriteLine("Operador Uniário  (+) e (-)");

Console.WriteLine("Informe o numero:\n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é igual a {-n}");

Console.ReadKey();



Console.WriteLine("Operador ternário\n");

Console.WriteLine("Informe a temperatura:\n");
double temp = Convert.ToDouble(Console.ReadLine());
string result = temp > 27 ? "Quente" : "Normal";
Console.WriteLine($"O tempo está {result}");


Console.WriteLine("Operador Condicional ternário (?:) - aninhando operaçoes");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string result2 = x > y ? "x é maior que y" : x < y ? "x é menor que y" : x == y ? "x é igual a y" : "Sem resultado";

Console.WriteLine(result2);