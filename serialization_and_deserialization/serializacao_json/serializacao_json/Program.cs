

using serializacao_json;
using System.Text.Json;

var aluno = new Aluno(2, "Álife", "alife.silva@unifesspa.edu.br",20);

var path = @"C:\Users\alife\OneDrive\Desktop\dados\serializacao_json\AlunoSerializado.json";

/*
 * serialização
 * 
using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, aluno); // uso o JsonSerializer com o metodo Serialize
}
Console.WriteLine("Objetio serializado com sucesso");
*/

// Lê todo conteudo do arquivo json
string jsonContent = File.ReadAllText(path);

// Desserializa o objeto do arquivo json e retorna
var alunoDesserializado = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine($"Aluno desserializado - ID:{alunoDesserializado?.Id},Nome:{alunoDesserializado?.Nome}");

Console.ReadKey();