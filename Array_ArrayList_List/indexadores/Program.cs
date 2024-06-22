// See https://aka.ms/new-console-template for more information
Console.WriteLine("Indexadores");


Time t = new Time();
t[1] = "Palmeiras";
t[3] = "Santos";
t[7] = "Vasco";



string valor1 = t[1];
string valor2 = t[3];
string valor3 = t[7];   
string valor4 = t[-1];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);

public class Time
{
    string[] valor = new string[10];

    public string this[int i]
    {
        get { if (i >= 0 && i <= valor.Length) { return valor[i]; } return "Error"; }
        set { if(i>= 0 && i <= valor.Length){ valor[i] = value; } }
    }
}