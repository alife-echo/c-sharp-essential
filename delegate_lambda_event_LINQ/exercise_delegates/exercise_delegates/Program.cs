using System.Threading.Channels;
using exercise_delegates;


var persons = Person.GetPersons();

Console.WriteLine("---------- Todas Pessoas ----------");
Action<Person> personAction = (person) => Console.WriteLine($"{person.Name}, {person.Age}");
persons.ForEach(personAction);

Console.WriteLine("---------- Pessoas Maior que 18 ----------");
Predicate<Person> predicatePerson = (person) => person.Age > 18;
var resultPredicatePerson = persons.FindAll(predicatePerson).ToList();
resultPredicatePerson.ForEach(person => Console.WriteLine($"{person.Name}, {person.Age}"));

Console.WriteLine("---------- Pessoas Mais velha ----------");
Func<Person,int> personFunc = (person) => person.Age;
var maxAge =  persons.MaxBy(personFunc);
var oldPerson = persons.Find(p => p == maxAge);
Console.WriteLine($"Old Person: {oldPerson?.Name}, {oldPerson?.Age}");


