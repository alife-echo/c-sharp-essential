
namespace ExemploHerancaComposicao;
public class Sardinha : Animal
{
    private readonly Nadadeira _na;
    public Sardinha(Nadadeira na)
    {
        _na = na;
    }
    public void Locomocao()
    {
        _na.Nadar();
    }
}

