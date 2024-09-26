

namespace operador_is_e_as_fix;
public class Circulo : Forma
{
    public Circulo() { }
    public Circulo(int x, int y) : base(x, y) { }

    public override void Desenhar()
    {
        Console.WriteLine($"Desenhar círculo na posição : ({xpos},{ypos})");
    }
    public void PintarCirculo()
    {
        Console.WriteLine("Pintar o Circulo");
    }
}
