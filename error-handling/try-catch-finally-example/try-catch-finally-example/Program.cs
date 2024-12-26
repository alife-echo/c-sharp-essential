
try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = dividendo / divisor;
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");
}

// Tipos de exceços que o codigo acima pode gerar:
// OverflowException,DivideByZeroException,FormatException

catch (FormatException)
{
    Console.WriteLine("\nInforme uma valor inteiro");
}
catch (OverflowException)
{
    Console.WriteLine("\n Informe um valor inteiro entre 1 e 999999");
}
catch (DivideByZeroException)
{
    Console.WriteLine("\n Não existe divisão por zero tente novamente");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadKey();