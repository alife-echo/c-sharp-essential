
namespace classeAbstrata;
public abstract class Forma
{
    public string? Color { get; set; }
    public double Field { get; set; }
    public double Perimeter { get; set; }

    public abstract void CalculateField();
    public abstract void CalculatePerimeter();

    public string Description()
    {
        return "Sou a classe abstrata Forma";
    }
}