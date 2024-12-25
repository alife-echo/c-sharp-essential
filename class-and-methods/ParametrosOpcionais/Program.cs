// See https://aka.ms/new-console-template for more information
Console.WriteLine("Parâmetros opcionais");

Console.WriteLine("Informe o destino");
string? destino = Console.ReadLine();

Console.WriteLine("Informe o titulo");
string titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto");
string assunto  = Console.ReadLine();   


Email e1 = new Email();

e1.Enviar(destino);
e1.Enviar(destino, titulo);
e1.Enviar(destino,titulo,assunto);
// não posso fazer
//email.Enviar(destino,,assunto); // causa um error
//
e1.Enviar(destino, assunto: assunto); // alternativa


Console.ReadKey();
public class Email
{
    public void Enviar(string destino, string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"{destino},{titulo} : {assunto}");
    }
}