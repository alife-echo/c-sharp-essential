// See https://aka.ms/new-console-template for more information


using System.Collections;

ClassGeneric<Student> obj1 = new ClassGeneric<Student>();
obj1.Add(new Student{Name = "Alife"});

Console.WriteLine(obj1[0].Name);


public class  ClassGeneric<T>
{ 
     ArrayList list = new ArrayList(5);
     int count = 0;

    public void Add(T item)
    {
        if (count < 5)
        {
            objects[count] = item;
        }

        count++;
    }

    public T this[int index]
    {
        get
        {
            return objects[index];
        }
        set
        {
            objects[index] = value;
        }
    }
}

public class Student
{
    public string? Name { get; set; }
}