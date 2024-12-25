// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n ## Entrada de dados");

//ReadLine(): le a linha digitada e retorna o que foi digitado
//Read(): le o que foi digitado(um unico caractere) e retorna o valor em ASCII correspodente
//ReadKey():le apenas um caractere, usando para segurar a tela até que o usuário pressione uma tecla

Console.WriteLine("\n Informe o seu nome");

string nome = Console.ReadLine() ?? "";

Console.WriteLine($"\nO seu nome é {nome}");

Console.WriteLine($"\n Informe sua idade {nome}");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n A idade de {nome} é {idade}");

Console.ReadKey();