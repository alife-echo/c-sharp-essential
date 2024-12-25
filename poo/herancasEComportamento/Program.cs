// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


ClasseDerivada cd = new();
cd.VerificaAcesso();

Console.ReadKey();



public class ClasseDerivada : ClasseBase
{

    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_Internal_Membro();
        //Private_Membro();
        Console.WriteLine("\n Acesso ao campo private : private_var usando uma proprieade");
                                                                                        //Propriedade
        int soma = public_var + protected_var + internal_var + protected_internal_var + Private_Var;
        Console.WriteLine($"\n Total Soma:{soma}");
    }
}

public class ClasseBase
{
    //CAMPOS
    public int public_var = 1;
    internal int internal_var = 2;
    protected int protected_var = 3;
    protected internal int protected_internal_var = 4;
    private int private_var = 5;

    // Só posso acessar o campo private_var criando uma propriedade get e set para private_var
    //Propriedades
    public int Private_Var
    {
        get { return private_var; }
        set { private_var = value; }
    }
    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Internal");
    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected Internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método private");
    }
}