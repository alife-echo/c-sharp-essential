// See https://aka.ms/new-console-template for more information
Cliente client1 = new Cliente();
client1.Idade = 20;
client1.Nome = "Álife";
Console.WriteLine($"{client1.Nome} {client1.Idade}");
public struct Cliente
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    public Cliente(string nome,int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}