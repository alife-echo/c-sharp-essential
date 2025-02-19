namespace exercise_streams_file_and_io;
using System.Security.Cryptography;
using System.Text;

public class AesEncryption
{
    public static byte[] Encrypt(string plainText, byte[] key, byte[] iv)
    {
        using (Aes aesAlg = Aes.Create()) // cria a instancia AES
        {
            aesAlg.Key = key; // define a chave criptografica para o Aes
            aesAlg.IV = iv; // define o vetor de inicialização para o Aes

            // cria o objeto para o criptografia, passando a chave e o vetor de inicialização com os valores já definidos
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            byte[] encryptedBytes;

            using (var msEncrypt = new System.IO.MemoryStream()) // instancia a memoria para armazenar os dados criptograficos
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor , CryptoStreamMode.Write)) // cria o fluxo de criptografia, passando a memoria, objeto configurado, e o modo de ação que nesse caso é de escrita
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);  // converte a string para bytes
                    csEncrypt.Write(plainBytes, 0, plainBytes.Length); // escreve os dados criptografados
                }

                encryptedBytes = msEncrypt.ToArray(); // obtem os dados criptografados
            }

            return encryptedBytes;   // retorna os dados criptografados
        }
    }

    public static string Decrypt(byte[] cipherText, byte[] key, byte[] iv)
    {
        using(Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            // cria o objeto para descriptografia
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            byte[] decryptedBytes;

            using(MemoryStream msDecrypt = new System.IO.MemoryStream(cipherText)) // memoria com os dados criptografados
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var msPlain = new System.IO.MemoryStream())
                    {
                        csDecrypt.CopyTo(msPlain); // copia os dados descriptografados para o stream
                        decryptedBytes = msPlain.ToArray(); // obtem os bytes descriptografados
                    }
                }
            return Encoding.UTF8.GetString(decryptedBytes); // converte os bytes de volta para a string
            }
        }
    }
}


/*

 passos de criptografia

 cria a instancia do AES,
 define o vetor de inicialização e a chave
 cria o objeto de criptografia, passando a chave e o vetor de inicialização
 
 cria uma variavel para atribuir a manipulação posterior,
 
 cria uma stream de memoria
 cria a stream de cripografia passando a (stream de memoria,objeto de criptografia, e o modo de acesso que nesse caso e de leitura)

 converte o texto em bytes
 pega a stream de memoria e escreve os bytes com (texto em bytes, 0, e o tamanho dos bytes)
 
 fora da stream de crypto, atribuia a variavel a instancia da memoria no formato array
    
 retorna a variavel ficticia criada no começa com os dados criptografados
 */