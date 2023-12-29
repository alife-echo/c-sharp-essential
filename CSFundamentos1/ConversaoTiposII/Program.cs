// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// conversão de tipos
// conversão para string
// ToString() --> converte para string

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.5678m;


string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

Console.WriteLine("\n-------------------------------\n");


// Conversão de tipos usando a classe Convert()
// ToBoolean() --> converte um tipo para valor booleano
// ToDouble() --> converte um tipo para o tipo double
// ToInt16() --> converte um tipo para o tipo 16-bit
// ToInt32() --> converte um tipo para o tipo 32-bit

int valorInt2 = 10;
double valorDouble2 = 5.35;
bool valorBoolean2 = true;

Console.WriteLine(Convert.ToString(valorInt2));
Console.WriteLine(Convert.ToDouble(valorInt2));
Console.WriteLine(Convert.ToString(valorBoolean2));
Console.WriteLine(Convert.ToInt32(valorDouble2));
Console.ReadLine();


// Erros de convesão

int varInt = 10000;
Console.WriteLine(Convert.ToByte(varInt));
// Error --> System.OverflowException 
// 'Value was either too large or too small for an unsigned byte'
// Estou tentando converter um int com intervalo de -2.147.483.648 a 2.147.483.647
// Para byte que é de 0 a 255
