// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio Pratico 4");
Console.WriteLine("Digite a potencia do carro");
int p = Convert.ToInt32(Console.ReadLine());
Carro c1 = new Carro();
int vc = c1.AumentarPotenciaVelocidade(p,out double velocidade);

Console.WriteLine($"Nova Potencia:{vc},Nova Velocidade:{velocidade}");

public class Carro
{
    public int AumentarPotenciaVelocidade (int potenciaVelocidade, out double velocidade)
    {
        potenciaVelocidade += 7;
        velocidade = potenciaVelocidade * 1.75;
        return potenciaVelocidade;
    }  
}