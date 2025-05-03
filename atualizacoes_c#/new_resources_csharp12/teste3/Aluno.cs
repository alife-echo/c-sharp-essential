namespace teste3;

public class Aluno
{
    public static string Nome { get; set; } = string.Empty;
    public static int Idade { get; set; }
    public static int nota { get; set; }
    
    public static void Mostrar() => Console.WriteLine($"Projeto B \n" +
                                               $"Nome: {Nome}, Idade: {Idade}");
}