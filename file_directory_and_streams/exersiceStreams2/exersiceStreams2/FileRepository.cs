namespace exersiceStreams2;

public class FileRepository(string? path)
{
    private string? Path { get; } = path;
    

    public bool CreateFile()
    {
        
        return FileHelper.ExecuteWithHandling(() =>
        {
            using (FileStream fs = new FileStream(Path,FileMode.Create,FileAccess.Write)) { }
        });
    }

    public bool WriteInFile(string? content)
    {
        if (!File.Exists(Path) && string.IsNullOrEmpty(content))
            return false;

        return FileHelper.ExecuteWithHandling(() =>
        {
            using (StreamWriter writer = new StreamWriter(Path, true))
            {
                writer.WriteLine(content);
            }
        });
    }

    public void ReadFile()
    {
        if (!File.Exists(Path))
            Console.WriteLine("Diretorio sem caminho");

        FileHelper.ExecuteWithHandling(() =>
        {
            using (StreamReader sr = File.OpenText(Path))
            {
                string? row;

                while ((row = sr.ReadLine())!= null)
                {
                    Console.WriteLine(row);
                }
            }
        });
    }

    public void GetPositionTextInFile(string? contentToSearch)
    {
        if (!File.Exists(Path) && string.IsNullOrEmpty(contentToSearch))
            Console.WriteLine("Arquivo não existe");

        FileHelper.ExecuteWithHandling(() =>
        {
            using (StreamReader reader = new StreamReader(Path))
            {
                string? row;
                int numberRow = 0;
                while ((row = reader.ReadLine())!= null)
                {
                    numberRow++;
                    if(row.Contains(contentToSearch))
                       Console.WriteLine($"Numero:{numberRow},Linha:{row}");
                }
            }
        });
        
        }
    }
    
    
