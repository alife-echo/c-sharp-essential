// See https://aka.ms/new-console-template for more information
Console.WriteLine("Argumentos nomeados");


Email e1 = new Email();

e1.Enviar(assunto: "Reunião Orçamento",destino:"teste@gmail.com",titulo:"Urgente");

public class Email
{
    public void Enviar(string destino,string titulo,string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}
