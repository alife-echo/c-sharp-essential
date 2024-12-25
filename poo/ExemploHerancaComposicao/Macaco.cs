

namespace ExemploHerancaComposicao;

public class Macaco : Animal
{
    private readonly Pe _pe;

    public Macaco(Pe pe)
    {
        _pe = pe;
    }
    public void Locomocao()
    {
        _pe.Andar();
    }
}

