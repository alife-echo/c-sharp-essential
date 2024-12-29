int dividendo = 0;
int divisor = 0;

try
{
    Console.WriteLine("Digite o dividendo");
    dividendo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o divisor");
    divisor = Convert.ToInt32(Console.ReadLine());
    int resultado = dividendo / divisor;
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");
}
/*
catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
{
    Console.WriteLine("Hoje é sabado, não trabalhamos mongol");
}*/
catch (Exception) when ((dividendo / divisor) == 0)
{
    Console.WriteLine("Esta linha nunca sera lida");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("Filtro de exceção com format");
    Console.WriteLine(ex.StackTrace);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
