

using exercicio_serialization;
using System.Text.Json;
using System.Xml.Serialization;

var listAlunos = new List<Aluno>()
{
    new (1,"Alife","alifesilva90@gmail.com", 20),
    new (2,"Bob","bob30@gmail.com",30),
    new (3,"Richard","richad@9gmail.com",25)
};

var pathJson = @"C:\Users\alife\OneDrive\Desktop\dados\serializacao_json\Alunos.json";


using (FileStream fs = new FileStream(pathJson, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(fs, listAlunos);
}
Console.WriteLine("Serialização de alunos realizado com sucesso - JSON");
 


var readFileAluno = File.ReadAllText(pathJson);
List<Aluno>? alunosDesserializados = JsonSerializer.Deserialize<List<Aluno>>(readFileAluno);

Console.WriteLine("\n");
Console.WriteLine("Desserialização de alunos realizada com sucesso - JSON");
Console.WriteLine("\n");

foreach (Aluno aluno in alunosDesserializados)
{
    Console.WriteLine($"Id:{aluno.Id},Nome:{aluno.Nome},Email:{aluno.Email},Idade:{aluno.Idade}");
}



var pathXml = @"C:\Users\alife\OneDrive\Desktop\dados\serialization_xml\Alunos.xml";

XmlSerializer serializer = new XmlSerializer(typeof(List<Aluno>));

using(StreamWriter sw = new StreamWriter(pathXml))
{
    serializer.Serialize(sw, listAlunos);
}

Console.WriteLine("\n");

Console.WriteLine("Serialização de alunos realizado com sucesso - XML");

Console.WriteLine("\n");
using (StreamReader sr = new StreamReader(pathXml))
{
    var alunoDesserializadoXml = (List<Aluno>?)serializer.Deserialize(sr);

    foreach (Aluno aluno in alunoDesserializadoXml)
    {
        Console.WriteLine($"Id:{aluno.Id},Nome:{aluno.Nome},Email:{aluno.Email},Idade:{aluno.Idade}");
    }
}