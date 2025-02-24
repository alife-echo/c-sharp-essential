

using serializalition_and_deserialization_BINARY;
using System.Runtime.Serialization.Formatters.Binary;

var aluno = new Aluno(1, "Álife", "alifesilva90@gmail.com", 20);

string? path = @"C:\Users\alife\OneDrive\Desktop\dados\serializacao_e_deserializacao_binaria\AlunoSerializado.bin";



using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate,FileAccess.ReadWrite))
{
#pragma warning disable SYSLIB0011 // suprimir aviso de error
    var bf = new BinaryFormatter(); // instancia o binary formater
    bf.Serialize(stream, aluno); // passa a stream e o objeto para a serialização binaria
#pragma warning restore SYSLIB0011 // restaurar aviso de erro




    Console.WriteLine("Tecle algo para realizar a serialização");
    //Begin	0	Especifica o início de um fluxo.
    stream.Seek(0, SeekOrigin.Begin);


#pragma warning disable SYSLIB0011 // suprimir aviso de error
    var alunoDesserializado = (Aluno)bf.Deserialize(stream);
    Console.WriteLine(alunoDesserializado.Nome); // exibe o nome do aluno
#pragma warning restore SYSLIB0011 // restaurar aviso de erro


}



// Error : SYSLIB0011: A serialização do BinaryFormatter é obsoleta
Console.WriteLine("Objeto serializado com sucesso");

Console.ReadKey();