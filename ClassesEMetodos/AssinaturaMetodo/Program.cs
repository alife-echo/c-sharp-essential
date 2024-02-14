// See https://aka.ms/new-console-template for more information
Console.WriteLine("Assinatura de um método");

Email email = new Email();

email.Enviar("empresa.com.br");
email.Enviar("empresa.com.br","Proposta comercial");
email.Enviar("empresa.com.br",300);
email.Enviar(300,"empresa.com.br");


public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Somar(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;    
    }
    public double Somar(double d1, double d2) 
    {
        return d1 + d2; 
    }
    public double Somar (int n1, double d2)
    {
        return n1 + d2;
    }
}


public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
    }
    public void Enviar(string endereco,string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }
    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta Comercial");
        Console.WriteLine($"{valor}");
    }
    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }
}