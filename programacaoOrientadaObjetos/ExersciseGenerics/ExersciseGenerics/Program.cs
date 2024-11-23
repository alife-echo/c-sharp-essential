// See https://aka.ms/new-console-template for more information


using System.Collections;

Generic<ArrayList> objArray1 = new Generic<ArrayList>();
objArray1.Add(new ArrayList(){2,"Steve","",true});

foreach (var data in objArray1[0])
{
    Console.WriteLine(data);
}

Generic<Student> objStudent1 = new Generic<Student>();
objStudent1.Add(new Student(){Name = "Alife"});

Console.WriteLine(objStudent1[0].Name);



Generic<int> obj1 = new Generic<int>();
obj1.Add(10);
Console.WriteLine(obj1[0]);





public class Generic<T>
{
    
    int count = 0;
    T[] array_generic = new T[5];

    public void Add(T currentObject)
    {
     
        if (count < 5)
        {
            array_generic[count] = currentObject;
        }

        count++;
    } 
    public T this[int index]
    {
        get => array_generic[index];
        set => array_generic[index] = value;
    }
}

public class Student
{
    public string? Name { get; set; }
}










