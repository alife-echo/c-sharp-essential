// See https://aka.ms/new-console-template for more information
Console.WriteLine("Membros Estáticos");

A a1 = new A();
a1.x = 10;

A a2 = new A();
a2.x = 20;

public class A
{
    public int x;
    public static int y;
}