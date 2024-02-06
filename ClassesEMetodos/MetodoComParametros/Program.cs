// See https://aka.ms/new-console-template for more information
Console.WriteLine("Métodos com parâmetros");

Myclass p1 = new Myclass();

p1.Saudacao("Maria",DateTime.Now.ToShortDateString());

public class Myclass
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}


