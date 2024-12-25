// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores Relacionais \n");

/*
  == -> igualdade
  > -> maior que
  < -> menor que
  >= -> maior que
  <=  -> menor que
  !=  -> diferente
 */

int x = 10;
int y = 20;

Console.WriteLine($"Valor de x {x}");
Console.WriteLine($"Valor de y {y}");
Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);
// vale tanto para numeros quanto para strings
// equals -> verifica a igualdade entre duas strings e numeros
// equals é igual a ==
Console.WriteLine("----------------------");
string a = "curso";
string b = "Curso";
int n1 = 1;
int n2 = 2;
string t = "1";
int t2 = 1;
Console.WriteLine(t.Equals(t2));
Console.WriteLine(a.Equals(b)) ;
Console.WriteLine(n1.Equals(n2));