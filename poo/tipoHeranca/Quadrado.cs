
namespace tipoHeranca;
internal class Quadrado : Forma,ICusto
{
    public int GetArea()
    {
        return (lado * lado);
    }
    public int GetCusto(int area)
    {
        return area * 10;
    }
}