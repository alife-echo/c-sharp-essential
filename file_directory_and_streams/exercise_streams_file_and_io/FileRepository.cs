using System.Runtime.InteropServices.Marshalling;

namespace exercise_streams_file_and_io;

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

    public bool WriteInFile(string? content,bool subscriber)
    {
        if (!File.Exists(Path) && string.IsNullOrEmpty(content))
            return false;

        return FileHelper.ExecuteWithHandling(() =>
        {
            using var wr = new StreamWriter(Path,subscriber);
            wr.WriteLine(content);

        });
    }

    public void ReadFile()
    {
        if(!File.Exists(Path))
         Console.WriteLine("Arquivo não existe");

        FileHelper.ExecuteWithHandling(() =>
        {
            using var fileText = File.OpenText(Path);

            string? row;

            while ((row = fileText.ReadLine()) != null)
            {
                Console.WriteLine(row);
            }
        });
    }
}