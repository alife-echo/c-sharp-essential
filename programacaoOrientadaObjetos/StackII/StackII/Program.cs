using StackII;
    
Console.WriteLine("\n ### Stack - Undo ###");

EditorTexto editor = new EditorTexto();
Console.WriteLine("\n Digitando... \n");
editor.DigitarChar('a');
editor.DigitarChar('b');
editor.DigitarChar('c');

Console.WriteLine("\n Fazendo o Undo ... \n");
editor.Undo();

Console.WriteLine("\n Redigitando ....");
editor.DigitarChar('c');
editor.DigitarChar('d');
editor.DigitarChar('e');
Console.ReadKey();