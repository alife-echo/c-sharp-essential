

namespace classeAbstrata;
public class Quadrado : Forma
{
    public double Side { get; set; }
    public override  void CalculateField()
    {
        this.Field = Side * Side;
    }
    public override void CalculatePerimeter()
    {
        this.Perimeter = 4 * this.Side;
  
    }

}

