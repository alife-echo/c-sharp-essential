// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercico Pratico V");

Carro c1 = new Carro();

c1.ExibirInfo(Modelo: "SUV", Montadora: "Chevrolet",Marca: "Hillux",Potencia:720,Ano:2020);
c1.ExibirInfo(Modelo: "Sedan", Montadora: "Chevrolet", Marca: "Chevrolet", Potencia: 200);
public class Carro
{
    public void ExibirInfo(string Modelo,string Montadora, string Marca, int Potencia, int Ano = 0)
    {
        Console.WriteLine($"Modelo:{Modelo},Montadora:{Montadora},Marca:{Marca},Potencia:{Potencia},Ano:{Ano}");
    }

}