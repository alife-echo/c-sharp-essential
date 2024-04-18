// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercício Prático 10");

Car c1 = new Car(2.3);
Car.ShowIpva();

Car c2 = new Car(3);
Car.ShowIpva(); 

class Car
{
    private static double ValorIpva;

    public Car(double ipva) 
    {
        ValorIpva = ipva;
    }    

    public static  void ShowIpva()
    {
        Console.WriteLine($"Valor Ipva${ValorIpva}");
    }
}