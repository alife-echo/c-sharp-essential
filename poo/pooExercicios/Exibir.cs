
namespace pooExercicios;


interface INota1
{
    void Classificacao();
}
interface INota2
{
    void Classificacao();
}

public class Exibir : INota1, INota2
{

    void INota1.Classificacao()
    {
        Console.WriteLine("Classificação INota1");
    }
    void INota2.Classificacao()
    {
        Console.WriteLine("Classificação INota2");
    }


}

