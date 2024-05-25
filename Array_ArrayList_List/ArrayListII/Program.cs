// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("ArrayList II");

var lista = new ArrayList() {"Maria",5,true,null };

lista.Add(3.5);
lista.Insert(3, "Paulo");

foreach (var item in lista)
{
    Console.WriteLine(item);
}


var lista2 = new ArrayList() { "Bob",6,false,null};

int[] array1 = { 1, 2, 3 };

lista2.AddRange(array1);

lista2.InsertRange(2, array1);

Console.ReadKey();