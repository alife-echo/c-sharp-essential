// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Exercicio");

Carro _ = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro __ = new("SUV", "Ford", "EcoSport", 2018, 120);

class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public Carro(string modelo , string montadora, string marca, int ano, int potencia )
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
        this.Exibir();
        this.Acelerar(this);
    }
    public void Exibir()
    {
        Console.WriteLine($"{Modelo},{Montadora},{Marca},{Ano},{Potencia}");
    }
    public void  Acelerar(Carro c)
    {
        Console.WriteLine($"Acelerando o meu {c.Marca}");
    }
}