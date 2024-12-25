// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.WriteLine("Método WriteLine");
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine("Método Write");
Console.Write(nome);
Console.Write(idade);
Console.WriteLine();
//Escreve na mesma linha 'Maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");
Console.WriteLine();
Console.WriteLine("-------------CONCATENAÇÃO---------------");

//Escreve na mesma linha 'Maria tem 25 anos'
// usar a concatenação : usando o operado +
Console.WriteLine(nome + " tem " + idade + " anos ");
Console.Write(nome + " tem " + idade + " anos ");


Console.WriteLine();
Console.WriteLine("-------------INTERPOLAÇÃO---------------");
//Escreve na mesma linha 'Maria tem 25 anos'
// usar a interpolação de srtings : $ -> interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");
Console.Write($"{nome} tem {idade} anos");

Console.WriteLine();
Console.WriteLine("-------------PLACEHOLDER---------------");
// usar place holders : usa {} com numeração com inicio em zero
// numeração indica quem sera mostrado primeiro
Console.WriteLine("{0} tem {1} anos",nome,idade);
Console.Write("{0} tem {1} anos", nome, idade);