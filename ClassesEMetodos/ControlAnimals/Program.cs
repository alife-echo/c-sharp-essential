// See https://aka.ms/new-console-template for more information
using ControlAnimals;

Console.WriteLine("Animais");

Animals a1 = new Animals();
do
{
    Console.WriteLine("Digite o nome do animal");
    string? nameAnimal = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Digite o tipo do animal");
    string? typeAnimal = Convert.ToString(Console.ReadLine());
    a1.Name = nameAnimal;
    a1.Tipo = typeAnimal;   


} while (true);

