// See https://aka.ms/new-console-template for more information

string a = "José";
string b = "Maria";

//Objetos diferentes sempre vão gerar um número diferente para GetHashCode 
Console.WriteLine(a + " = " + a.GetHashCode());
Console.WriteLine(b + " = " + b.GetHashCode());




//para tipos primitivs o equals compara valor, retornando true
var name = "Alife";
var name2 = "Alife";

Console.WriteLine(name.Equals(name2)); // true
Console.WriteLine(name.GetHashCode());
Console.WriteLine(name2.GetHashCode());

int x = 100;
int y = 100;

Console.WriteLine(x.Equals(y)); // true


//Aqui comparamos as refencias dos objetos,as referencias não são iguais retornando false
var pessoa1 = new Pessoa(1,"Alife");
var pessoa2 = new Pessoa(1,"Alife");

Console.WriteLine(pessoa1.Equals(pessoa2));
Console.WriteLine(pessoa1.GetHashCode());
Console.WriteLine(pessoa2.GetHashCode());
public class Pessoa
{
    public Pessoa(int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
}
