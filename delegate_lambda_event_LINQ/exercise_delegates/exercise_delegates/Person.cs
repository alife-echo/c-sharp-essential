namespace exercise_delegates;

public class Person
{
    private string? _name;
    private int _age;
    public string Name
    {
        get => string.IsNullOrEmpty(_name) ? "No name" : _name; 
        set => _name = value;
    }

    public int Age
    {
        get => _age > 0 ? _age : 0; 
        set => _age = value;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static List<Person> GetPersons()
    {
        var persons = new List<Person>()
        {
            new Person("Bob", 17),
            new Person("Jane", 14),
            new Person("Mary", 13),
            new Person("Charlie", 25),
            new Person("Nig", 30),
            new Person("Tony", 18),
            new Person("Richard", 19),
        };
        
        return persons;

    }
    
}