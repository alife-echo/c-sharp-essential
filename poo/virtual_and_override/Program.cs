// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var gato = new Gato();
gato.Nome = "Rogerio";
gato.ExibeNome();

var cao = new Cachorro();
cao.Nome = "Pipoca";
cao.ExibeNome();

Console.ReadKey();


class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"\n Meu nome é {Nome}");
    }
}

class Gato : Animal
{
    public override void  ExibeNome()
    {
        Console.WriteLine($"\n Eu sou um gato. Meu nome é : {Nome}");
    }
}

class Cachorro : Animal
{

}