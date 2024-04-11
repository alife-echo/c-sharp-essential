// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicios");
Cliente cliente = new Cliente(Nome:"Álife",Email:"alife.silva@unifesspa.edu.br",Idade:15);

cliente.Exibir();
cliente.Exibir();

struct Cliente
{
    private string? nome;
    private int idade;   
    private string? email;
    
    public string Nome { get { return nome ?? "" ; } set { nome = value; } }
    public string Email { get {return email ?? "";}  set { email = value; } }
    public int Idade { get { return idade; } set { if (value < 18) { idade = 18; } else { idade = value; } }}

    public Cliente(string Nome,string Email,int Idade)
    {
        this.Nome = Nome;
        this.Email = Email;
        this.Idade = Idade;  
    }
    public void Exibir()
    {
        Console.WriteLine($"{Nome},{Email},{Idade}");
    }

}
