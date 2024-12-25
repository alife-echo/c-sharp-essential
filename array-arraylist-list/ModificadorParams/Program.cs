// See https://aka.ms/new-console-template for more information
Console.WriteLine("Modificador Params");


int[] valores = { 1, 2, 3 };

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);




var res2 = Calcular.Soma(1,2,3,4,5,6);

Console.WriteLine(res2);

public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;

        foreach (var numero in numeros)
        {
            total += numero;    
        }
        return total;
    }
}