// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Métodos ##\n");

MyClass minhaClasse = new();

minhaClasse.Saudacao();

Console.ReadKey();


class MyClass
{
   public  void Saudacao()
    {
        Console.WriteLine("Bem-Vindo !!!");
        ExibirDataAtual();
    }
   public void ExibirDataAtual()=>
        Console.WriteLine(DateTime.Now.ToShortDateString());
    
}

