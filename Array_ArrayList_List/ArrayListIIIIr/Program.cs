// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("ArrayListIIII");


var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

var res1 = lista.Contains(5);

var res2 = lista.Contains(null);

bool res3 = lista.Contains(45);

bool res4 = lista.Contains("Maria");


var lista2 = new ArrayList() {"Maria","Ana","Zilda","Carlos","Dina"};

lista2.Sort();

lista2.Clear();

Console.ReadKey();