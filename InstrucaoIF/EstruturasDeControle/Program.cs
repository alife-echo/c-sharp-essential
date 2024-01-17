// See https://aka.ms/new-console-template for more information
Console.WriteLine("Instrução IF!");
/*
     if(expressao booleana)
    {
     //executa o bloco de instrução se expressão for true
    //instrução 1
    //instrução 2
    }
    ou

    if(expressao booleana)
       //executa apenas uma instrução se a expressão for true
       //uso de chaves opcional

 */
/*
    Console.WriteLine("Cliente Especial (S/N)");
    string? resposta = Console.ReadLine();
    if(resposta == "S")
    {
        Console.WriteLine("Desconto de 10%");
    }
    Console.WriteLine("Fim do processamento");
 */
/*
    Console.WriteLine("Cliente Especial (true/false)");
    var resposta = Convert.ToBoolean(Console.ReadLine());
    if(resposta)
    {
        Console.WriteLine("Desconto de 10%");
    }
    Console.WriteLine("Fim do processamento");
 */
/*
    Console.WriteLine("Cliente Especial (true/false)");
    var resposta = Convert.ToBoolean(Console.ReadLine());
    if(resposta)
    {
        Console.WriteLine("Desconto de 10%");
    }
    Console.WriteLine("Fim do processamento");
    Console.ReadKey();
*/
/*
    bool clientEspecial = false;
    Console.WriteLine("Cliente Especial (S/N)\t");
    var result = Console.ReadLine();

    if(result == "S")
    {
        clientEspecial = true;
    }
    if(clientEspecial)
    {
        Console.WriteLine("Desconto de 10%");
    }
    Console.WriteLine("Fim do processamento");
    Console.ReadKey();
*/
/*
    Console.WriteLine("Informe o valor x\t");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n Informe o valor y \t");
    int y = Convert.ToInt32(Console.ReadLine()); 

    if(x > y)
    {
        Console.WriteLine("x é maior que y");
    }
    if(x < y)
    {
        Console.WriteLine("x é menor que y");
    }
    if(x == y)
    {
        Console.WriteLine("x é igual a y");
    }
*/
/*
Console.WriteLine("Informe a nota do aluno");
var nota = Convert.ToInt32(Console.ReadLine());

if(nota > 5)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno reprovado");
}
*/
Console.WriteLine("Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());   

// if é else aninhados
if(x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    if(x < y)
    {
        Console.WriteLine("x é menor que y");
    }
    else
    {
        Console.WriteLine("x é igual a y");
    }
}
