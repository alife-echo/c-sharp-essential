
namespace ExemploHerancaComposicao;
public class Animal
{
    public int Idade { get; set; }
    
    public virtual void Comer()
    {
        Console.WriteLine(".....Comendo");
    }
    public  virtual void Dormir()
    {
        Console.WriteLine("Dormindo");
    }
}

