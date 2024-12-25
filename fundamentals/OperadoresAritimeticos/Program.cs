// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores Aritimeticos \n");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");

int y = Convert.ToInt32(Console.ReadLine());

const double PI_NUMBER = Math.PI;
const double E_NUMBER = Math.E;

Console.WriteLine($"\n Raiz Quadrade de x = {Math.Sqrt(x)}");
Console.WriteLine($"\n Potencia de x = {Math.Pow(x,y)}");
Console.WriteLine($"\n Valor minimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"\n Valor Maximo entre x e y = {Math.Max(x,y)}");
Console.WriteLine($"\n Conseno de x = {Math.Cos(x)}");
Console.WriteLine($"\n Seno de x  = {Math.Sin(x)}");
Console.WriteLine($"\n Exponencial de x  = {Math.Exp(x)}");



Console.ReadKey();

//Operações basicas 

//Console.WriteLine($"Soma de x+y = {x+y}");
//Console.WriteLine($"Subtração de x-y = {x-y}");
//Console.WriteLine($"Multiplicação de x*y = {x*y}");
//Console.WriteLine($"Divisão de x/y = {(double)x/y}");
//Console.WriteLine($"Módulo de x%y = {x%y}");