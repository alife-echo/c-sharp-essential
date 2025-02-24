
using serializacao_xml;
using System.Xml.Serialization;

var aluno = new Aluno(101, "Álife", "alifesilva90@gmail.com", 30);

var path = @"C:\Users\alife\OneDrive\Desktop\dados\serialization_xml\AlunoSerializado.xml";

// Cria um XmlSerializer para o tipo do aluno
XmlSerializer serializer = new XmlSerializer(typeof(Aluno)); 

/*
 * 
 * Serialização
using(StreamWriter write = new StreamWriter(path))
{
    // faço a serialização xml passa a stream e o objeto aluno com os dados
    serializer.Serialize(write, aluno);
}
Console.WriteLine("Objeto serializado para XML com sucesso");
*/

using(StreamReader reader = new StreamReader(path))
{
 
    var alunoDeserializado = (Aluno?)serializer.Deserialize(reader);

    Console.WriteLine($"Aluno xml desserializado - Id:{alunoDeserializado?.Id}, " +
        $"Nome:{alunoDeserializado?.Nome}, " +
        $"Email:{alunoDeserializado?.Email}," +
        $" Idade:{alunoDeserializado?.Idade}");
}

Console.ReadKey();