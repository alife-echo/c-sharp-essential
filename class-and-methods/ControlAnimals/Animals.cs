
namespace ControlAnimals;
public class Animals
{
    int countDog = 0; int countCat = 0; int countFish = 0;
    private string? nome;
    private string? tipo;

    public string? Name { get { return String.IsNullOrEmpty(nome) ? "" : nome; } set { if (String.IsNullOrEmpty(value)) { Console.WriteLine("Não informado"); } if (!String.IsNullOrEmpty(value)) { nome = value; } } }

    public string? Tipo { get { return String.IsNullOrEmpty(tipo) ? "" : tipo; } set { if (String.IsNullOrEmpty(value)) { Console.WriteLine("Não informado"); } if (!String.IsNullOrEmpty(value) && (value == "Canino" || value == "Felino" || value == "Aquatico")) { tipo = value; } if (value != "Canino" || value != "Felino" || value != "Aquatico") { tipo = "Aquatico"; } } }
    enum Animais
    {
        Gato,
        Cachorro,
        Peixe
    }
    public static void ExibirInfo()
    {
        foreach (var animais in Enum.GetValues(typeof(Animais)))
        {
            Console.WriteLine($"{animais},Tipo:{((int)animais == 0 ? "Felino" : (int)animais == 1 ? "Canino" : (int)animais == 2 ? "Aquatico" : "Não encontrado")}");
        }
    }


}
