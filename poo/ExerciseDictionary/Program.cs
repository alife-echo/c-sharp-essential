// See https://aka.ms/new-console-template for more information

var repository = new RepositoryStudent();

var st1 = new Student("Álife", 9);
var st2 = new Student("Bob", 5);
var st3 = new Student("Richard", 6);
var st4 = new Student("João", 8);
var st5 = new Student("Mary", 7);
var st6 = new Student("Vilma", 7);
repository.TryAddStudent(1, st1);
repository.TryAddStudent(2, st2);
repository.TryAddStudent(3, st3);
repository.TryAddStudent(4, st4);
repository.TryAddStudent(5, st5);

repository.ShowStudents();
repository.TryGetStudent(2, 7);
repository.TryGetStudent(3, 5);
repository.TryAddStudent(6, st6);
repository.OrderStudents();


public class RepositoryStudent
{
    private readonly Dictionary<int, Student> _students;

    public RepositoryStudent()
    {
        _students = new Dictionary<int,Student>();
    }
    
    public  void ShowStudents()
    {
        foreach (var student in  _students)
        {
            Console.WriteLine($"{student.Key} - {student.Value.NameStudent} - {student.Value.MaterialScore}");
        }
    }

    public void OrderStudents()
    {
        var orderedStudents = new SortedDictionary<int, Student>(_students).
            OrderBy(student => student.Value.NameStudent).ToList();

        foreach (var student in orderedStudents)
        {
            Console.WriteLine($"{student.Key} - {student.Value.NameStudent} - {student.Value.MaterialScore}");
        }
    }
    
    public string TryAddStudent(int key,Student student)
    {
       return  _students.TryAdd(key, student) ? "Studante Adicionado" : "Studante Não adicionado";
    }

    public void RemoveStudent(int key)
    {
        if (_students.Remove(key))
        {
            Console.WriteLine("Estudante removido com sucesso");
        }
        if (!_students.Remove(key))
        {
            throw new KeyNotFoundException("Aluno não encontrado");
        }
    }

    public string TryGetStudent(int key , int newScore)
    {
        if(_students.TryGetValue(key, out Student? student))
        {
            Console.WriteLine($"{key}: {student.NameStudent} encontrado");
            _students[key].MaterialScore = newScore;
            return "Estudante Atualizado com sucesoo";
        }
    
        return "";
    }

    public void ClearStudents()
    {
        _students.Clear();
        Console.WriteLine("Alunos removidos com sucesso");
    }
}



public class Student
{
    private string? _nameStudent;
    private int _scoreMaterial;
    public string? NameStudent
    {
        get => _nameStudent;
        set
        {
            if (!String.IsNullOrEmpty(value))
            {
                 _nameStudent = value;
            }
        }
    }

    public int MaterialScore
    {
        get => _scoreMaterial;
        set
        {
            if (value > 0)
            {
                _scoreMaterial = value;
            }
        }
    }
    
    public Student(string? nameStudent, int materialScore)
    {
        NameStudent = nameStudent;
        MaterialScore = materialScore;
    }
    
    
}





