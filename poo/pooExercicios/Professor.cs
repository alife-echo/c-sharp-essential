
namespace pooExercicios;
public class Professor : Pessoa
{
    public Professor(string Nome) : base(Nome){}

    public void Explicar()
    {
        Console.WriteLine($"O professor {Nome} esta explicando ....");
    }
}

