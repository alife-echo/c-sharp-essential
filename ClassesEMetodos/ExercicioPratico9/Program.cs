// See https://aka.ms/new-console-template for more information
using _EnumerationCarro;
using System.Drawing;

Console.WriteLine("Digite um numero para escolher sua cor");
Car.ShowMenu();
int numberColor = Convert.ToInt32(Console.ReadLine());
Car c1 = new Car(numberColor);
Car.ShowInfo(numberColor);
public class Car
{
    private int color;
    public int Color { get { return color; } set { color = value; } }

    public Car(int Color)
    {
        this.Color = Color;
    }
    public  static  void ShowMenu()
    {
        foreach (var colors in Enum.GetValues(typeof(CarroEnum)))
        {
            
            Console.WriteLine($"{(int)colors} - {colors}");
        }
    }

    public static void ShowInfo(int? TypeColor = null)
    {
        if(TypeColor != null)
        {
            var color = (CarroEnum)TypeColor;
            Console.WriteLine($"Cor escolhida:{color.ToString()}");
        }
        else
        {
            Console.WriteLine("Nenhuma Cor Foi Selecionada");
        }
    }
}
