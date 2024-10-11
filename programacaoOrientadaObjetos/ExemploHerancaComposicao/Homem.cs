
namespace ExemploHerancaComposicao;
public class Homem : Animal
{
    private readonly Pe _pe;

    public Homem(Pe pe)
    {
        _pe = pe;
    }
    public void Locomocao()
    {
        _pe.Andar();
    }
}

