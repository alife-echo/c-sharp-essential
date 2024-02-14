
Console.WriteLine("Exercicio");

Carro _ = new("Sedan", "Chevrolet");
Carro __ = new("SUV", "Ford");
Console.WriteLine(_.VelocidadeMaxima(300));
class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public Carro(string modelo, string montadora)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = "X";
        this.Ano = 0000;
        this.Potencia = 0000;
        this.Exibir();
        this.Acelerar(this);
    }
    public void Exibir()
    {
        Console.WriteLine($"{Modelo},{Montadora},{Marca},{Ano},{Potencia}");
    }
    public void Acelerar(Carro c)
    {
        Console.WriteLine($"Acelerando o meu {c.Marca}");
    }
    public double VelocidadeMaxima (int potencia)
    {
        return potencia * 1.75;            
    }
}



//h -> os valores posteriores do fornecido da questão serão estaticos
//j -> ira retorna um valor de um metodo ao seu chamador
