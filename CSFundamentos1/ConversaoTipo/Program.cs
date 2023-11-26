// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversão de tipos ##\n");

// C# --> Estaticamente tipado em tempo de compilação
// Apos uma variavel se declarada ela não pode ser redeclarada
// Não pode armazenar valores de outros tipos de dados
// A menos que o tipo da variavel possa ser convetido


// Conversão Implícita 
// O C# faz a conversão automaticament  caso os tipos seja compativeis

//Conversão Explícita
// A conversão tem que ser feita manualmente


// A conversão automatica ocorre do menor tipo tamanho para uma maior tipo tamanho
// O oposto não e verdadeiro

// int --> double = ok 
// double --> int = error

//byte --> 1 byte
//short --> 2 bytes
//int --> 4 bytes
//long --> 8 bytes
//float --> 4 bytes
// double --> 8 bytes
// decimal -- 16 bytes

Console.WriteLine("Conversões implicitas\n");
//Conversões implicitas
int varInt = 100;
double varDouble = varInt;
Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float  numeroFloat = numeroInt;
decimal numeroDecimal = numeroInt;
double numeroDouble = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);   
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);






// Conversões Explicitas
Console.WriteLine("Conversões explicitas\n");
// Conversão de maneira manual
// Necessita de cast
// Cast definição do tipo a ser convertido usando (tipo) antes da variavel
double varDouble2 = 12.456; // 8 bytes
int varInt2 = (int)varDouble2; // 4 bytes (perda de precisão)
Console.WriteLine(varInt2);
//O resultado seria 2 pq foi convertido de flot para int
// usando o cast o resultado sera mostrando em float, 2,5
int num1 = 10;
int num2 = 4;
float resultado = (float)(num1 / num2);
Console.WriteLine(resultado);
Console.ReadLine();
