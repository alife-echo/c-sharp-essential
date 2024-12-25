
namespace ExerciseMaxAge;
public class People
{

    private int age;

    private string? name;

    public int Age { get { return age; } set {  age = value;  } }

    public string? Name { get { return String.IsNullOrEmpty(name) ? "" : name; }  set {
            if (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("Valor Não Informado");
            }
            if (!String.IsNullOrEmpty(value))
            {
                name = value; 
            } 
        } }   

   public People() { }

   public People(string Name, int Age)
    {
        this.Name = Name;   
        this.Age = Age;
    }

    public void ExibiDados()
    {

        Console.WriteLine($"Nome:{name},Idade:{age}");
    }
}
