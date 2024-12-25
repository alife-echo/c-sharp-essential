namespace StackII;

public class EditorTexto
{
    private Stack<char> undoStack = new Stack<char>();
    private string texto = "";

    public void DigitarChar(char c)
    {
        texto += c; //abc
        undoStack.Push(c); //abc
        Console.WriteLine($"Texto : " + texto); //abc
    }

    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            char ultimoChar = undoStack.Pop(); // abc --> ab
            texto = texto.Substring(0, texto.Length - 1); // abc --> ab
            Console.WriteLine($"Texo : {texto}");// ab
        }
    }
}