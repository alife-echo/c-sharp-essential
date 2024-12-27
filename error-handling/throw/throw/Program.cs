
try
{
    A.ProcessarA();
}
catch(Exception e)
{
    Console.WriteLine("\nTratando erro na main");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}


Console.ReadKey();

public class A
{
    
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            throw ex;
            Console.WriteLine("Tratando o erro em A");
        }

    }
}

public class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception ex)
        {
            throw ex;
            Console.WriteLine("Tratando erro em B");
        }
       
    }
}

public class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}