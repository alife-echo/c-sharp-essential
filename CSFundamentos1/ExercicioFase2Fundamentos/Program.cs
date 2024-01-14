// See https://aka.ms/new-console-template for more information
Console.WriteLine("Q1");
string nome = "Paulo";
int idade = 17;
float nota = 7.5f;

Console.WriteLine($"Aluno:{nome} tem {idade} anos e nota:{nota}");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");

Console.WriteLine("Q2");
Console.WriteLine($"{nome}\n{idade}\n{nota}");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");

Console.WriteLine("Q3");
Console.WriteLine("float para int");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");

Console.WriteLine("Q4");
Console.WriteLine("V\nF\nV\nV\nV\nV");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");

Console.WriteLine("Q5");
Console.WriteLine("Digite 3 letras");
string? letters = Console.ReadLine();
if(letters?.Length > 3 || letters?.Length <= 1){Console.WriteLine("Digite apenas 3 letras");}
else{ Console.WriteLine($"Letras invertidas {new string(letters?.Reverse().ToArray())}");}
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");




Console.WriteLine("Q6");
Console.WriteLine("F\nV\nV\nV\nF\nV\nF\nV\nV\nF");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");



Console.WriteLine("Q7");
double v1, v2;
Console.WriteLine("Digite o primeiro valor:");
v1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo valor:");
v2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Soma:{v1 + v2}");
Console.WriteLine($"Subtração:{v1 - v2}");
Console.WriteLine($"Multiplicação:{v1 * v2}");
Console.WriteLine($"Exponeciação:{Math.Pow(v1,v2)}");
Console.WriteLine($"Divisão:{v1 / v2}");
Console.WriteLine($"Resto:{v1 % v2}");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");



Console.WriteLine("Q8");
int a, b, c;
double x1, x2;
Console.WriteLine("Digite a:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite b:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite c:");
c = Convert.ToInt32(Console.ReadLine());    
x1 = (-b + (double)Math.Sqrt(Math.Pow(b,2) - 4 * a * c))/(2 * a);
x2 = (-b - (double)Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
Console.WriteLine($"x1:{x1}");
Console.WriteLine($"x2:{x2}");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");

Console.WriteLine("Q9");
string? nomeUser;
Console.WriteLine("Digite seu nome:");
nomeUser = Console.ReadLine();  
int senha;
Console.WriteLine("Digite sua senha:");
senha  = Convert.ToInt32(Console.ReadLine());   
string login = ((nomeUser == "admin" || nomeUser == "maria") && senha == 123) ? "Login feito com sucesso" : "Login inválido";
Console.WriteLine(login);
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");



Console.WriteLine("Q10");
Console.WriteLine("V\nF\nF\nV\nF\nF\nV\nF\nF\nV\nV");
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");


Console.WriteLine("Q11");
int xp, yp;
Console.WriteLine("Digite o valor de x");
xp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de y");
yp = Convert.ToInt32(Console.ReadLine());   
string resultP = (xp % 2 == 0 && yp % 2 == 0) ? "x é par e y é par" : (xp % 2 == 0 && yp % 2 != 0) ? "x é par e y é impar" : (xp % 2 != 0 && yp % 2 == 0) ? "x é impar e y é par" : "x é impar e y é impar";
Console.WriteLine(resultP);
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");



Console.WriteLine("Q12");
int xc;
Console.WriteLine("Digite o valor de x");
xc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(-6 + xc * 5);
Console.WriteLine((13 - 2)  * xc);
Console.WriteLine((xc + -2) * (20/xc)) ;
Console.WriteLine((12 + xc)/(xc - 4));
Console.WriteLine(3 * Math.Pow(xc,2) + xc + 10);
Console.WriteLine(3.1415 * Math.Pow(xc,2));
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");

Console.WriteLine("Q13");
int y13 = 5;
y13 = (y13++) + y13 + (++y13);
Console.WriteLine(y13);
Console.WriteLine("\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("\n");
