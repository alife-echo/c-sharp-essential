// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saida de dados : Usando sequencia de escapes");
Console.WriteLine();

string local = "c:\\dados\\poesias.txt";
string frase = "Ele falou:\"Não fui eu\" \a";
string pizza = "\nPizza \nde \nMussarela ";
string bolo = "\nBolo \tde \tChocolate";
Console.WriteLine(frase);
Console.WriteLine(pizza);
Console.WriteLine(bolo);
Console.ReadLine();

//Formatação usando sequencias Escapses
/*
 
 \a   --> sinal sonoro (alerta)
 \b   --> Backspace
 \f   --> Alimentação de Formulário
 \n   --> Nova Linha
 \r   --> Carriage Return
 \t   --> Tabulação horizontal
 \v   --> Tabulação vertical
 \'  --> Aspas Simples
 \"  --> Aspas duplas
 \\  --> Barra invertida
 \?  --> Interrogação
 \u ooo --> ASCII unicode
 \x hh --> ASCII hexadecimal
 */